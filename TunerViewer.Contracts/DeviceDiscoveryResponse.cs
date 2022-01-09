using System;
using System.Collections.Generic;
using System.Text;

namespace TunerViewer.Contracts
{
    /// <summary>
    /// DeviceDiscoveryResponse object.
    /// Returned by any of the DeviceDiscoverer methods.
    /// </summary>
    public class DeviceDiscoveryResponse
    {
        /// <summary>
        /// DeviceDiscovery Exception.
        /// </summary>
        public Exception Exception { get; set; }
        /// <summary>
        /// Discovered device lookup.
        /// </summary>
        public Dictionary<string, DeviceInfo> DeviceLookup { get; set; }
    }
}
