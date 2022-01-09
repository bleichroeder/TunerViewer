using Microsoft.VisualStudio.TestTools.UnitTesting;
using TunerViewer.Contracts;
using TunerViewer.Library;

namespace TunerViewer.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void DiscoverRemoteDevicesUsingHDHRConfig()
        {
            DeviceDiscoverer discoverer = new DeviceDiscoverer();

            RemoteDeviceDiscoveryRequest request = new RemoteDeviceDiscoveryRequest
                (@"eyes\tvuser", @"tvice", "bufcap01.tveyes.com", true);

            DeviceDiscoveryResponse response = discoverer.DiscoverRemoteDevices(request);

            Assert.IsTrue(response.DeviceLookup.Count > 0);
        }

        [TestMethod]
        public void DiscoverRemoteDevicesUsingARP()
        {
            DeviceDiscoverer discoverer = new DeviceDiscoverer();

            RemoteDeviceDiscoveryRequest request = new RemoteDeviceDiscoveryRequest
                (@"eyes\tvuser", @"tvice", "bufcap01.tveyes.com", false);

            DeviceDiscoveryResponse response = discoverer.DiscoverRemoteDevices(request);

            Assert.IsTrue(response.DeviceLookup.Count > 0);
        }
    }
}
