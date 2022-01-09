namespace TunerViewer.Contracts
{
    /// <summary>
    /// Device discover response object.
    /// Returned from the device from /discover.json.
    /// </summary>
    public class Discover
    {
        /// <summary>
        /// Device friendly name. (Model)
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Device model number.
        /// </summary>
        public string ModelNumber { get; set; }
        /// <summary>
        /// Device firmware version.
        /// </summary>
        public string FirmwareVersion { get; set; }
        /// <summary>
        /// Device ID.
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// Device tuner count.
        /// </summary>
        public int Tunercount { get; set; }
        /// <summary>
        /// Device firmware upgrade available.
        /// </summary>
        public string UpgradeAvailable { get; set; }
        /// <summary>
        /// Device lineup url. (Channel list)
        /// </summary>
        public string LineupURL { get; set; }
    }
}
