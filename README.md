# TunverViewer

WinForms application & Nuget package for monitoring/controlling HDHomerun/SiliconDust/Hauppauge capture devices.

## TunerViewer2

TunerViewer2 will automatically scan for local devices when opened. If no devices are found, the user is asked if they would like to attempt a remote host scan.\
![](https://github.com/bleichroeder/TunerViewer/blob/main/Images/RemoteScan.JPG)

When devices are found, they're displayed in a familiar tree view. Selecting a tuner in the device tree will start the polling of the tuner stats.\
![](https://github.com/bleichroeder/TunerViewer/blob/main/Images/TunerInfo.JPG)

The channels tab displays detailed information for the available channels, and allows for search/filtering the list.\
![](https://github.com/bleichroeder/TunerViewer/blob/main/Images/Channels.gif)

Device info is available in the DeviceInfo tab. Device logs, and pairing information can be retrieved here. Firmware updates can also be started from this page.\
![](https://github.com/bleichroeder/TunerViewer/blob/main/Images/DeviceInfo.JPG)

TunerViewer2 allows for streaming using the streaming tab. If a tuner is available on the device, TunerViewer will automatically locate the open tuner and begin streaming content from the selected channel.\
![](https://github.com/bleichroeder/TunerViewer/blob/main/Images/Streaming.gif)

Graphing and AdvancedGraphing allow for the recording and visualization of tuner statistics. Values are stored in memory and can be exported to a JSON for analysis.\
![](https://github.com/bleichroeder/TunerViewer/blob/main/Images/AdvancedGraphing.gif)


## TunerViewer.Library & TunerViewer.Contracts

TunerViewer.Library can be used to discover and monitor local and remote devices. This can be done in a few different ways.

Local discovery can be done using UDP broadcast, or by parsing the ARP table for partial MAC addresses. Both are performed by using the DeviceDiscoverer class and using either the DiscoverLocalDevicesByUDPBroadcast method or the DiscoverLocalDevicesByMACAddress method.

```
            DeviceDiscoveryResponse response = new DeviceDiscoverer()
                .DiscoverLocalDevicesByUDPBroadcast();

                ------------------ or ------------------
            
            DeviceDiscoveryResponse response = new DeviceDiscoverer()
                .DiscoverLocalDevicesByMACAddress();
```

Remote discovery can be performed by DeviceDiscoverer using one of two methods.\
If present on the remote host, the DeviceDiscoverer can call hdhomerun_config.exe on the remote host to discover devices, and parse the resulting output for IP addresses by using the DiscoverRemoteDevices method.

Alternatively, the DeviceDiscoverer can parse the ARP table on the remote host for partial MAC addresses/IP Addresses by using the DiscoverRemoteDevices method.

Both methods require a RemoteDeviceDiscoveryRequest. This object contains a RemoteHost name, the user and password for the remote host, and a boolean value instructing the method whether to use hdhomerun_config.exe or parse the ARP table.

```
RemoteDeviceDiscoveryRequest request = new RemoteDeviceDiscoveryRequest
                (@"foo/bar", @"foobar", "foo.bar.com", true);

            DeviceDiscoveryResponse response = new DeviceDiscoverer()
                .DiscoverRemoteDevices(request);
```

The DeviceDiscoveryResponse object contains a Dictionary<string, DeviceInfo>. Each DeviceInfo object contains device properties and a List<TunerInfo>, as well as various methods used to update/control it's list of TunerInfo objects ie. RefreshAllTunerInfos() or ReturnTunersWithStreamingRateBelow(double threshold) etc...

Each TunerInfo object can call the RefreshTunerInfo method to refresh tuner stats, as well as various methods for detecting issues like low signal or streaming rates.
