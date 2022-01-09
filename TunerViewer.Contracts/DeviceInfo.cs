using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TunerViewer.Contracts
{
    /// <summary>
    /// DeviceInfo object.
    /// </summary>
    public class DeviceInfo
    {
        /// <summary>
        /// Device ID.
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// Device IP Address
        /// </summary>
        public IPAddress DeviceIP { get; set; }
        /// <summary>
        /// Device's current firmware version.
        /// </summary>
        public string Firmware { get; set; }
        /// <summary>
        /// Device model name.
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Device name.
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// Number of tuners on the device.
        /// </summary>
        public int TunerCount { get; set; } = 0;
        /// <summary>
        /// True if an update is available for the device.
        /// </summary>
        public bool UpdateAvailable { get; set; } = false;
        /// <summary>
        /// The version of the available firmware update.
        /// </summary>
        public string AvailableRelease { get; set; }
        /// <summary>
        /// True if the device is in the process of performing a firmware update.
        /// </summary>
        public bool IsUpdating { get; set; } = false;
        /// <summary>
        /// Device authentication.
        /// </summary>
        public bool Authenticated { get; set; } = false;
        /// <summary>
        /// Device OOB lock.
        /// </summary>
        public bool OOBLock { get; set; } = false;
        /// <summary>
        /// Device validation.
        /// </summary>
        public bool Validated { get; set; } = false;
        /// <summary>
        /// Device memory report.
        /// </summary>
        public string MemoryReport { get; set; }
        /// <summary>
        /// Device MAC address.
        /// </summary>
        public string MACAddress { get; set; }
        /// <summary>
        /// Device subnet mask.
        /// </summary>
        public string SubnetMask { get; set; }
        /// <summary>
        /// List of TunerInfo objects.
        /// </summary>
        public List<TunerInfo> Tuners { get; set; } = new List<TunerInfo>();
        /// <summary>
        /// List of Channel objects.
        /// </summary>
        public List<Channel> Channels { get; set; } = new List<Channel>();

        /// <summary>
        /// Will refresh all tuner data on the device.
        /// If devices are local, setting useConfig to True will use hdhomerun_config.exe for tuner data retrieval.
        /// </summary>
        public void RefreshAllTunerData(bool useConfig = false)
        {
            if (Tuners.Count > 0)
            {
                Parallel.ForEach(Tuners, tuner =>
                {
                    tuner.RefreshTunerInfo(useConfig);
                });
            }
        }

        /// <summary>
        /// Finds any tuners with a streaming rate lower than the specified threshold.
        /// </summary>
        /// <returns>
        /// List of TunerInfo object.
        /// </returns>
        public List<TunerInfo> ReturnTunersWithStreamingRateBelow(double threshold)
        {
            List<TunerInfo> retVal = new List<TunerInfo>();

            if (Tuners.Count > 0)
            {
                for (int i = 0; i < Tuners.Count; i++)
                {
                    if (Tuners[i].StreamingRateLowerThan(threshold))
                    {
                        retVal.Add(Tuners[i]);
                    }
                }
            }

            return retVal;
        }

        /// <summary>
        /// Will refresh the device info.
        /// </summary>
        public void RefreshDeviceInfo()
        {
            Discover deviceInfo = null;

            try
            {
                using (WebClient c = new WebClient())
                {
                    deviceInfo = JsonConvert.DeserializeObject<Discover>
                        (c.DownloadString($"http://{DeviceIP}/discover.json"));

                    if (deviceInfo != null)
                    {
                        string devicePage = c.DownloadString($"http://{DeviceIP}/").ToUpper();
                        string systemPage = c.DownloadString($"http://{DeviceIP}/system.html");
                        string lineupPage = c.DownloadString($"http://{DeviceIP}/lineup.json?show=found");

                        MACAddress = ReturnMAC(systemPage);
                        MemoryReport = ReturnMemoryReport(systemPage);
                        SubnetMask = ReturnSubnetMask(systemPage);

                        Validated = IsValidated(devicePage);

                        Authenticated = IsAuthenticated(devicePage);

                        OOBLock = HasOOBLock(devicePage);

                        if (TunerCount == 0)
                        {
                            TunerCount = ReturnTunerCount
                                (c.DownloadString($"http://{DeviceIP}/tuners.html").ToUpper());
                        }
                        else
                        {
                            TunerCount = deviceInfo.Tunercount;
                        }

                        DeviceID = deviceInfo.DeviceID;
                        Firmware = deviceInfo.FirmwareVersion;
                        Model = deviceInfo.ModelNumber;
                        DeviceName = deviceInfo.FriendlyName;

                        if (!string.IsNullOrEmpty(deviceInfo.UpgradeAvailable))
                        {
                            AvailableRelease = deviceInfo.UpgradeAvailable;
                            UpdateAvailable = true;
                        }
                        else
                        {
                            UpdateAvailable = false;
                        }

                        Channels = JsonConvert.DeserializeObject<List<Channel>>(lineupPage);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <returns>
        /// Device tuner count.
        /// </returns>
        private static int ReturnTunerCount(string tunerPage)
        {
            bool tunerExists = true;
            int i = 0;
            while (tunerExists)
            {
                if (!tunerPage.ToUpper().Contains($"TUNER{i}"))
                    return i;
                i++;
            }
            return i;
        }

        /// <returns>
        /// Device authentication.
        /// </returns>
        private static bool IsAuthenticated(string devicePage)
        {
            Regex reg = new Regex(@"(CARD AUTHENTICATION<\/TD><TD>)(.*)(<\/TD><\/TR>)");
            var match = reg.Match(devicePage);
            if (match.Groups.Count > 1)
                if (match.Groups[2].Value.ToString() == "SUCCESS")
                    return true;
            return false;
        }

        /// <returns>
        /// Device memory report.
        /// </returns>
        private static string ReturnMemoryReport(string devicePage)
        {
            Regex reg = new Regex(@"(Memory Report</td><td>)(.*)(</td></tr>)");
            var match = reg.Match(devicePage);
            if (match.Groups.Count > 1)
                if (match.Groups[2].Value != null)
                    return match.Groups[2].Value;
            return null;
        }

        /// <returns>
        /// Device subnet mask.
        /// </returns>
        private static string ReturnSubnetMask(string devicePage)
        {
            Regex reg = new Regex(@"(Subnet Mask</td><td>)(.*)(</td></tr>)");
            var match = reg.Match(devicePage);
            if (match.Groups.Count > 1)
                if (match.Groups[2].Value != null)
                    return match.Groups[2].Value;
            return null;
        }

        /// <returns>
        /// Device MAC address.
        /// </returns>
        private static string ReturnMAC(string devicePage)
        {
            Regex reg = new Regex(@"(MAC Address</td><td>)(.*)(</td></tr>)");
            var match = reg.Match(devicePage);
            if (match.Groups.Count > 1)
                if (match.Groups[2].Value != null)
                    return match.Groups[2].Value;
            return null;
        }

        /// <returns>
        /// Device OOB lock.
        /// </returns>
        private static bool HasOOBLock(string devicePage)
        {
            Regex reg = new Regex(@"(CARD OOB LOCK<\/TD><TD>)(.*)(<\/TD><\/TR>)");
            var match = reg.Match(devicePage);
            if (match.Groups.Count > 1)
                if (match.Groups[2].Value.ToString() == "SUCCESS")
                    return true;
            return false;
        }

        /// <returns>
        /// Device validation.
        /// </returns>
        private static bool IsValidated(string devicePage)
        {
            Regex reg = new Regex(@"(CARD VALIDATION<\/TD><TD>)(.*)(<\/TD><\/TR>)");
            var match = reg.Match(devicePage);
            if (match.Groups.Count > 1)
                if (match.Groups[2].Value.ToString() == "SUCCESS")
                    return true;
            return false;
        }
    }
}
