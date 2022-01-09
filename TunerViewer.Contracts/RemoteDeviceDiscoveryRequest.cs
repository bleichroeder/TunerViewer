namespace TunerViewer.Contracts
{
    /// <summary>
    /// RemoteDeviceDiscoveryRequest.
    /// Required for performing remote device discovery.
    /// </summary>
    public class RemoteDeviceDiscoveryRequest
    {
        /// <summary>
        /// Remote host username.
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Remote host password.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Remote host.
        /// </summary>
        public string RemoteHost { get; set; }
        /// <summary>
        /// Use hdhomerun_config.exe on remote host for device discovery.
        /// If set to false, will use ARP parsing method.
        /// </summary>
        public bool UseHDHRConfig { get; set; } = false;
        /// <summary>
        /// Array of full or partial MAC addresses to be used for remote discovery.
        /// Defaults to an array of known MAC addresses.
        /// </summary>
        public string[] TargetMACs { get; set; } = new string[] { "00-18-DD", "0018DD", "00-0D-FE", "000DFE" };

        /// <summary>
        /// RemoteDeviceDiscoveryRequest.
        /// Required for performing remote device discovery.
        /// </summary>
        public RemoteDeviceDiscoveryRequest(string user, string password, string remoteHost, bool useHDHRConfig = false)
        {
            User = user;
            Password = password;
            RemoteHost = remoteHost;
            UseHDHRConfig = useHDHRConfig;
        }
    }
}
