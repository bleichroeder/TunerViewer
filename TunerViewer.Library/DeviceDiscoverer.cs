using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using TunerViewer.Contracts;

namespace TunerViewer.Library
{
    /// <summary>
    /// Discovers any HDHR/Silicondust/Hauppague devices on the local or remote host subnet.
    /// </summary>
    public class DeviceDiscoverer
    {
        /// <summary>
        /// Path to hdhomerun_config.exe.
        /// Defaults to the default installation path: "c:\Program Files\Silicondust\HDHomeRun\hdhomerun_config.exe".
        /// Can be set using SetHDHomerunConfigPath(string path)
        /// </summary>
        public string HDHomerunConfigPath { get; set; } = @"c:\Program Files\Silicondust\HDHomeRun\hdhomerun_config.exe";

        /// <summary>
        /// Sets the path for hdhomerunconfig_.exe
        /// </summary>
        public void SetHDHomerunConfigPath(string path)
        {
            HDHomerunConfigPath = path;
        }

        /// <summary>
        /// Discovers local devices using UDP broadcast. This is the method hdhomerun_config.exe uses for discovery.
        /// </summary>
        /// <returns>
        /// DeviceDiscoveryResponse object.
        /// </returns>
        public DeviceDiscoveryResponse DiscoverLocalDevicesByUDPBroadcast()
        {
            List<IPAddress> ipAddresses = new List<IPAddress>();
            Exception rex = null;

            byte[] discBytes = { 0, 2, 0, 12, 1, 4, 255, 255, 255, 255, 2, 4, 255, 255, 255, 255, 115, 204, 125, 143 };

            using (var udpClient = new UdpClient())
            {

                udpClient.Client.ReceiveTimeout = 500;
                udpClient.Client.SendTimeout = 500;

                try
                {
                    udpClient.Send(discBytes, discBytes.Length, new IPEndPoint(IPAddress.Parse("255.255.255.255"), 65001));

                    var ep = new IPEndPoint(0, 0);

                    byte[] response = null;

                    while (true)
                    {
                        response = udpClient.Receive(ref ep);

                        if (response != null)
                        {
                            lock(ipAddresses)
                                ipAddresses.Add(ep.Address);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    rex = ex;
                }
            }

            DeviceDiscoveryResponse retVal = RetrieveDeviceInfoFromIPs(ipAddresses);

            retVal.Exception = rex;

            return RetrieveDeviceInfoFromIPs(ipAddresses);
        }

        /// <summary>
        /// Discovers local devices by partial MAC address. This will NOT return devices that are not actively communicating.
        /// </summary>
        /// <returns>
        /// DeviceDiscoveryResponse object.
        /// </returns>
        public DeviceDiscoveryResponse DiscoverLocalDevicesByMACAddress(string[] macAddresses = null)
        {
            if (macAddresses == null)
            {
                macAddresses = new string[] { "00-18-DD", "0018DD", "00-0D-FE", "000DFE" };
            }

            List<IPAddress> ipAddresses = new List<IPAddress>();

            Exception rex = null;

            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "arp",
                Arguments = "-a",
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process p = new Process()
            {
                StartInfo = info
            };

            try
            {
                p.Start();

                string output = p.StandardOutput.ReadToEnd().ToUpper();

                foreach (string mac in macAddresses)
                {
                    var parsedMACs = output.Split('\n').Where(x => x.Contains(mac));

                    if (parsedMACs.Any())
                    {
                        foreach (string line in parsedMACs)
                        {
                            Regex reg = new Regex
                                (@"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");

                            var match = reg.Match(line);

                            if (match.Groups.Count > 0)
                            {
                                string ip = match.Groups[0].Value.ToString().Trim();

                                lock(ipAddresses)
                                    ipAddresses.Add(IPAddress.Parse(ip));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                rex = ex;
            }

            DeviceDiscoveryResponse retVal = RetrieveDeviceInfoFromIPs(ipAddresses);

            retVal.Exception = rex;

            return RetrieveDeviceInfoFromIPs(ipAddresses);
        }

        /// <summary>
        /// Discovers remote devices on a specified host.
        /// Requires a RemoteDeviceDiscoveryRequest object containing a user, password, and host.
        /// </summary>
        /// <returns>
        /// DeviceDiscoveryResponse object.
        /// </returns>
        public DeviceDiscoveryResponse DiscoverRemoteDevices(RemoteDeviceDiscoveryRequest remoteRequest)
        {
            List<IPAddress> ipAddresses = new List<IPAddress>();

            Exception rex = null;

            string remPath = $"\\\\{remoteRequest.RemoteHost}\\c$\\temp";
            string remFile = @"discovery.txt";
            string locPath = $"c:\\temp";

            bool found = false;

            try
            {
                string processString = $"CMD.EXE /S /C arp -d && CMD.EXE /S /C arp -a  > \"{locPath}\\{remFile}\"";

                if (remoteRequest.UseHDHRConfig)
                {
                    processString = $"CMD.EXE /S /C CALL \"C:\\Program Files\\Silicondust\\HDHomeRun\\hdhomerun_config.exe\" discover > {locPath}\\{remFile}";
                }

                ConnectionOptions options = new ConnectionOptions
                {
                    Username = remoteRequest.User,
                    Password = remoteRequest.Password
                };

                ManagementScope scope = new ManagementScope($"\\\\{remoteRequest.RemoteHost}\\root\\cimv2", options);

                scope.Connect();

                ObjectGetOptions objectGetOptions = new ObjectGetOptions();

                ManagementPath managementPath = new ManagementPath("Win32_Process");

                using (ManagementClass processClass = new ManagementClass(scope, managementPath, objectGetOptions))
                {
                    processClass.InvokeMethod("Create", new object[] { processString });
                }

                try
                {
                    using (new NetworkConnection(remPath, new NetworkCredential(remoteRequest.User, remoteRequest.Password)))
                    {
                        int checks = 0;
                        while (!found && checks < 20)
                        {
                            if (File.Exists($"{remPath}\\{remFile}"))
                            {
                                int readTries = 0;
                                bool readSuccess = false;

                                string contents = null;

                                while (!readSuccess && readTries < 10)
                                {
                                    try
                                    {
                                        contents = File.ReadAllText($"{remPath}\\{remFile}").ToUpper();
                                        readSuccess = true;
                                    }
                                    catch (Exception)
                                    {
                                        readTries++;
                                    }
                                    Thread.Sleep(1000);
                                }

                                if (contents != null)
                                {
                                    if (remoteRequest.UseHDHRConfig)
                                    {
                                        var lines = contents.Split('\n');

                                        foreach (string line in lines)
                                        {
                                            if (!string.IsNullOrEmpty(line))
                                            {
                                                Regex reg = new Regex(@"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
                                                var match = reg.Match(line);
                                                if (match.Groups.Count > 0)
                                                {
                                                    IPAddress parsed = IPAddress.Parse(match.Groups[0].Value.ToString().Trim());

                                                    if (!ipAddresses.Contains(parsed))
                                                    {
                                                        lock (ipAddresses)
                                                            ipAddresses.Add(parsed);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        foreach (string mac in remoteRequest.TargetMACs)
                                        {
                                            var macs = contents.Split('\n').Where(x => x.Contains(mac));
                                            if (macs.Any())
                                            {
                                                foreach (string line in macs)
                                                {
                                                    Regex reg = new Regex(@"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
                                                    var match = reg.Match(line);
                                                    if (match.Groups.Count > 0)
                                                    {
                                                        IPAddress parsed = IPAddress.Parse(match.Groups[0].Value.ToString().Trim());

                                                        if (!ipAddresses.Contains(parsed))
                                                        {
                                                            lock (ipAddresses)
                                                                ipAddresses.Add(parsed);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    found = true;
                                }

                                File.Delete($"{remPath}\\{remFile}");
                            }
                            else
                            {
                                checks++;
                                Thread.Sleep(500);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0}: {1}", remoteRequest.RemoteHost, ex);
                    rex = ex;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}: {1}", remoteRequest.RemoteHost, ex);
                rex = ex;
            }

            DeviceDiscoveryResponse retVal = RetrieveDeviceInfoFromIPs(ipAddresses);

            retVal.Exception = rex;

            return RetrieveDeviceInfoFromIPs(ipAddresses);
        }

        /// <summary>
        /// Builds device info objects.
        /// </summary>
        private DeviceDiscoveryResponse RetrieveDeviceInfoFromIPs(List<IPAddress> iPAddresses)
        {
            DeviceDiscoveryResponse retVal = new DeviceDiscoveryResponse()
            {
                DeviceLookup = new Dictionary<string, DeviceInfo>()
            };

            foreach (IPAddress deviceIP in iPAddresses)
            {
                try
                {
                    DeviceInfo device = new DeviceInfo
                    {
                        DeviceIP = deviceIP
                    };

                    device.RefreshDeviceInfo();

                    for (int i = 0; i < device.TunerCount; i++)
                    {
                        TunerInfo t = new TunerInfo()
                        {
                            DeviceID = device.DeviceID,
                            TunerNumber = i,
                            TunerURI = $"http://{device.DeviceIP}/tuners.html?page=tuner{i}",
                            HDHomerunConfigPath = HDHomerunConfigPath
                        };

                        device.Tuners.Add(t);
                    }

                    if (!retVal.DeviceLookup.ContainsKey(device.DeviceID))
                    {
                        lock (retVal)
                        {
                            retVal.DeviceLookup.Add(device.DeviceID, device);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    retVal.Exception = ex;
                }
            }

            return retVal;
        }



        /// <summary>
        /// For remote file retrieval.. maybe not completely necessary
        /// </summary>
        private class NetworkConnection : IDisposable
        {
            readonly string _networkName;

            public NetworkConnection(string networkName,
                NetworkCredential credentials)
            {
                _networkName = networkName;

                var netResource = new NetResource()
                {
                    Scope = ResourceScope.GlobalNetwork,
                    ResourceType = ResourceType.Disk,
                    DisplayType = ResourceDisplaytype.Share,
                    RemoteName = networkName
                };

                var userName = string.IsNullOrEmpty(credentials.Domain)
                    ? credentials.UserName
                    : string.Format(@"{0}\{1}", credentials.Domain, credentials.UserName);

                var result = WNetAddConnection2(
                    netResource,
                    credentials.Password,
                    userName,
                    0);

                if (result != 0)
                {
                    throw new Win32Exception(result);
                }
            }

            ~NetworkConnection()
            {
                Dispose(false);
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                WNetCancelConnection2(_networkName, 0, true);
            }

            [DllImport("mpr.dll")]
            private static extern int WNetAddConnection2(NetResource netResource,
                string password, string username, int flags);

            [DllImport("mpr.dll")]
            private static extern int WNetCancelConnection2(string name, int flags,
                bool force);
        }

        [StructLayout(LayoutKind.Sequential)]
        public class NetResource
        {
            public ResourceScope Scope;
            public ResourceType ResourceType;
            public ResourceDisplaytype DisplayType;
            public int Usage;
            public string LocalName;
            public string RemoteName;
            public string Comment;
            public string Provider;
        }

        public enum ResourceScope : int
        {
            Connected = 1,
            GlobalNetwork,
            Remembered,
            Recent,
            Context
        };

        public enum ResourceType : int
        {
            Any = 0,
            Disk = 1,
            Print = 2,
            Reserved = 8,
        }

        public enum ResourceDisplaytype : int
        {
            Generic = 0x0,
            Domain = 0x01,
            Server = 0x02,
            Share = 0x03,
            File = 0x04,
            Group = 0x05,
            Network = 0x06,
            Root = 0x07,
            Shareadmin = 0x08,
            Directory = 0x09,
            Tree = 0x0a,
            Ndscontainer = 0x0b
        }
    }
}
