using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;

namespace TunerViewer.Contracts
{
    /// <summary>
    /// TunerInfo object.
    /// </summary>
    public class TunerInfo
    {
        /// <summary>
        /// hdhomerun_config.exe path. Set by DeviceDiscoverer, can be changed in TunerInfo object as well.
        /// Used when 'useConfig' is set to True when calling the RefreshTunerInfo method.
        /// </summary>
        public string HDHomerunConfigPath { get; set; }
        /// <summary>
        /// Tuner's parent device ID.
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// Tuner URI.
        /// </summary>
        public string TunerURI { get; set; }
        /// <summary>
        /// Tuner number.
        /// </summary>
        public int TunerNumber { get; set; }
        /// <summary>
        /// Tuner's current channel name.
        /// </summary>
        public string VirtualChannel { get; set; }
        /// <summary>
        /// Tuner's currently tuned frequency.
        /// </summary>
        public double Frequency { get; set; }
        /// <summary>
        /// Tuner's currently tuned program number.
        /// </summary>
        public double ProgramNumber { get; set; }
        /// <summary>
        /// Tuner authorization.
        /// </summary>
        public string Authorization { get; set; }
        /// <summary>
        /// Tuner CCI Protection.
        /// </summary>
        public string CCIProtection { get; set; }
        /// <summary>
        /// Tuner modulation lock.
        /// </summary>
        public string ModulationLock { get; set; }
        /// <summary>
        /// Tuner PCR lock.
        /// </summary>
        public string PCRLock { get; set; }
        /// <summary>
        /// Current signal strength.
        /// </summary>
        public int SignalStrength { get; set; }
        /// <summary>
        /// Current signal quality.
        /// </summary>
        public int SignalQuality { get; set; }
        /// <summary>
        /// Current symbol quality.
        /// </summary>
        public int SymbolQuality { get; set; }
        /// <summary>
        /// Current streaming/network rate.
        /// </summary>
        public double StreamingRate { get; set; }
        /// <summary>
        /// Tuner's resource lock. (IPAddress)
        /// </summary>
        public IPAddress ResourceLock { get; set; }
        /// <summary>
        /// Tuner's network target.
        /// </summary>
        public string NetworkTarget { get; set; }

        /// <summary>
        /// Returns True if tuner's streaming rate is below a specified threshold.
        /// </summary>
        public bool StreamingRateLowerThan(double threshold)
        {
            if (StreamingRate < threshold && ResourceLock != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Refreshes tuner's info.
        /// If useConfig is set to True, will use hdhomerun_config.exe instead of parsing HTML.
        /// </summary>
        public void RefreshTunerInfo(bool useConfig = false)
        {
            if (useConfig)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = HDHomerunConfigPath,
                        Arguments = string.Format("{0} get /tuner{1}/status", DeviceID, TunerNumber),
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    };

                    Process p = new Process()
                    {
                        StartInfo = psi
                    };

                    p.Start();

                    var stdo = p.StandardOutput.ReadToEnd();

                    Regex reg = new Regex(@"(ch=)(.*)( )(lock=)(.*)( )(ss=)(.*)( )(snq=)(.*)( )(seq=)(.*)( )(bps=)(.*)( )(pps=)(.*)");
                    var match = reg.Match(stdo);
                    if (match.Groups.Count > 1)
                    {
                        ModulationLock = match.Groups[5].Value;
                        SignalStrength = int.Parse(match.Groups[8].Value);
                        SignalQuality = int.Parse(match.Groups[11].Value);
                        SymbolQuality = int.Parse(match.Groups[14].Value);
                        StreamingRate = Math.Truncate((double.Parse(match.Groups[17].Value) / 1000000) * 100) / 100;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                HtmlDocument doc = new HtmlDocument
                {
                    OptionFixNestedTags = true,
                    OptionOutputAsXml = true
                };

                using (WebClient c = new WebClient())
                    doc.LoadHtml(c.DownloadString(TunerURI));

                var tableData = doc.DocumentNode.SelectSingleNode("/html/body/div[2]/table");

                Authorization = ParseFor(tableData, "Authorization");
                CCIProtection = ParseFor(tableData, "CCI Protection");
                ModulationLock = ParseFor(tableData, "Modulation Lock");
                ProgramNumber = Convert.ToInt32(ParseFor(tableData, "Program Number"));
                VirtualChannel = ParseFor(tableData, "Virtual Channel");

                string freq = ParseFor(tableData, "Frequency");
                if (!string.IsNullOrEmpty(freq))
                {
                    var val = ParseFor(tableData, "Frequency");
                    string parsedVal = val.Split(' ')[0];
                    Frequency = Convert.ToDouble(parsedVal);
                }

                ModulationLock = ParseFor(tableData, "Modulation Lock");
                PCRLock = ParseFor(tableData, "PCR Lock");

                string sigQ = ParseFor(tableData, "Signal Quality");
                if (!string.IsNullOrEmpty(sigQ))
                {
                    string parsedVal = sigQ.Split(' ')[0].Replace("%", "");
                    SignalQuality = Convert.ToInt32(parsedVal);
                }

                string sigS = ParseFor(tableData, "Signal Strength");
                if (!string.IsNullOrEmpty(sigS))
                {
                    string parsedVal = sigS.Split(' ')[0].Replace("%", "");
                    SignalStrength = Convert.ToInt32(parsedVal);
                }

                string symQ = ParseFor(tableData, "Symbol Quality");
                if (!string.IsNullOrEmpty(symQ))
                {
                    string parsedVal = symQ.Split(' ')[0].Replace("%", "");
                    SymbolQuality = Convert.ToInt32(parsedVal);
                }

                string stR = ParseFor(tableData, "Streaming Rate");
                if (!string.IsNullOrEmpty(stR))
                {
                    string parsedVal = stR.Split(' ')[0];
                    StreamingRate = Convert.ToDouble(parsedVal);
                }


                string reLock = ParseFor(tableData, "Resource Lock");
                if (!string.IsNullOrEmpty(reLock))
                    ResourceLock = IPAddress.Parse(ParseFor(tableData, "Resource Lock"));
            }
        }

        /// <summary>
        /// Parses HTML node for specified string and returns value.
        /// </summary>
        private string ParseFor(HtmlNode targetNode, string request)
        {
            foreach (var tableRow in targetNode.ChildNodes)
            {
                if (tableRow.Name != "#text")
                {
                    string att = tableRow.FirstChild.InnerText;
                    string val = tableRow.LastChild.InnerText;

                    if (att == request && val.ToUpper() != "NONE")
                    {
                        return val;
                    }
                }
            }
            return null;
        }
    }
}
