using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using TunerViewer.Contracts;
using TunerViewer.Library;

namespace TunerViewer2
{
    public partial class MainWindow : Form
    {
        // Some important things
        private readonly Dictionary<string, DeviceInfo> Devices = new Dictionary<string, DeviceInfo>();
        private TunerInfo SelectedTuner = null;
        private DeviceInfo SelectedDevice = null;

        // Control groups
        readonly List<Button> MenuButtons = new List<Button>();

        // Graphing
        readonly ChartValues<MeasureModel> StreamingRateValues = new ChartValues<MeasureModel>();
        readonly ChartValues<MeasureModel> SignalStrengthValues = new ChartValues<MeasureModel>();
        readonly ChartValues<MeasureModel> SignalQualityValues = new ChartValues<MeasureModel>();
        readonly ChartValues<MeasureModel> SymbolQualityValues = new ChartValues<MeasureModel>();
        readonly int GraphingDurationSeconds = 10;
        int MaximumStoredValues = 3600; // one per second, for an hour

        // Settings
        private int RefreshRate { get; set; } = 1000;

        // RT
        bool Scanning = false;
        bool Streaming = false;
        bool UDPDiscovery = true;
        bool UseHDHRRemoteDiscovery = true;
        bool RemoteDiscovery = false;
        bool UseHDHRConfig = false;

        // Open forms
        AdvancedGraphing AdvancedGraphing = null;


        public MainWindow()
        {
            InitializeComponent();
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            // output version to form text for cool points
            Text += string.Format(" v{0}", Assembly.GetEntryAssembly().GetName().Version);

            // Collect menu buttons for control
            foreach (Button btn in MenuButtonsPanel.Controls)
                MenuButtons.Add(btn);

            // Set min/max vals for gauges
            InitializeGauges();

            // Configure graphing
            InitializeGraphs();

            // Start the tunerdata refresher
            TunerDataRefresher()
                .Start();

            // Look for devices
            RefreshDevicesButton_Click(this, e);

            // Select TunerInfo tab
            MenuTunerInfoButton_Click(this, e);

            await Task.Delay(10);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        /// <summary>
        /// Background data control
        /// </summary>
        private async void InitializeGauges()
        {
            foreach (var control in GaugesPanel.Controls)
            {
                if (control is SolidGauge gauge)
                {
                    gauge.AnimationsSpeed = TimeSpan.Parse("00:00:00.5000000");
                    gauge.FromColor = Color.FromRgb(240, 31, 31);
                    gauge.ToColor = Color.FromRgb(135, 206, 250);

                    if (gauge.Name.ToUpper().Contains("STREAMING"))
                    {
                        gauge.To = 5;
                    }
                    else
                    {
                        gauge.To = 100;
                    }
                }
            }

            await Task.Delay(100);
        }

        private async void InitializeGraphs()
        {
            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            Charting.For<MeasureModel>(mapper);

            StreamingRateValues.Clear();
            SignalStrengthValues.Clear();
            SignalQualityValues.Clear();
            SymbolQualityValues.Clear();

            GraphingSignalGraph.AxisX.Clear();
            GraphingSignalGraph.AxisY.Clear();
            GraphingSignalGraph.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            GraphingSignalGraph.AxisY.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 100
            });

            GraphingSignalGraph.Series = new SeriesCollection()
            {
                new LineSeries("SignalStrength")
                {
                    Name = "SignalStrength",
                        DataLabels = false,
                        Title = "SignalStrength",
                        Stroke = Brushes.Orange,
                        Fill = Brushes.Transparent,
                        Values = SignalStrengthValues,
                        LineSmoothness = 0,
                        StrokeThickness = 3,
                        PointGeometrySize = 0,
                        PointGeometry = null
                },
                new LineSeries("SignalQuality")
                {
                    Name = "SignalQuality",
                        DataLabels = false,
                        Title = "SignalQuality",
                        Stroke = Brushes.Green,
                        Fill = Brushes.Transparent,
                        Values = SignalQualityValues,
                        LineSmoothness = 0,
                        StrokeThickness = 3,
                        PointGeometrySize = 0,
                        PointGeometry = null
                },
                new LineSeries("SymbolQuality")
                {
                    Name = "SymbolQuality",
                        DataLabels = false,
                        Title = "SymbolQuality",
                        Stroke = Brushes.Blue,
                        Fill = Brushes.Transparent,
                        Values = SymbolQualityValues,
                        LineSmoothness = 0,
                        StrokeThickness = 3,
                        PointGeometrySize = 0,
                        PointGeometry = null
                }
            };

            GraphingStreamingGraph.AxisX.Clear();
            GraphingStreamingGraph.AxisY.Clear();
            GraphingStreamingGraph.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            GraphingStreamingGraph.AxisY.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 20
            });

            GraphingStreamingGraph.Series = new SeriesCollection()
            {
                new LineSeries("StreamingRate")
                {
                    Name = "StreamingRate",
                        DataLabels = false,
                        Title = "StreamingRate",
                        Stroke = Brushes.Red,
                        Fill = Brushes.Transparent,
                        Values = StreamingRateValues,
                        LineSmoothness = 0,
                        StrokeThickness = 3,
                        PointGeometrySize = 0,
                        PointGeometry = null
                }
            };

            SetAxisLimits(DateTime.Now);

            await Task.Delay(10);
        }

        private void SetAxisLimits(DateTime now)
        {
            try
            {
                GraphingSignalGraph.Invoke(new Action(delegate ()
                {
                    GraphingSignalGraph.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks;
                    GraphingSignalGraph.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(GraphingDurationSeconds).Ticks;
                }));

                GraphingStreamingGraph.Invoke(new Action(delegate ()
                {
                    GraphingStreamingGraph.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks;
                    GraphingStreamingGraph.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(GraphingDurationSeconds).Ticks;
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private Thread TunerDataRefresher()
        {
            Thread retVal = new Thread(() =>
            {
                while (true)
                {
                    DateTime refreshStart = DateTime.Now;

                    if (Devices.Count > 0)
                    {
                        try
                        {


                            RefreshStatusLED.Invoke(new Action(delegate ()
                            {
                                RefreshStatusLED.BackColor = System.Drawing.Color.LightSkyBlue;
                            }));

                            Parallel.ForEach(Devices, device =>
                            {
                                device.Value.RefreshAllTunerData(UseHDHRConfig);
                            });

                            UpdateGaugeValues();
                            UpdateGraphValues();
                            UpdateHUDValues();

                            RefreshStatusLED.Invoke(new Action(delegate ()
                            {
                                RefreshStatusLED.BackColor = System.Drawing.Color.DodgerBlue;
                            }));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                    else
                    {
                        try
                        {
                            RefreshStatusLED.Invoke(new Action(delegate ()
                            {
                                RefreshStatusLED.BackColor = System.Drawing.Color.DarkGray;
                            }));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }

                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    // To get a more accurate refresh, subtract the time it took to gather values from refresh rate...
                    int sleep = (int)TimeSpan.FromMilliseconds(RefreshRate).Add(-(DateTime.Now - refreshStart)).TotalMilliseconds;

                    if (sleep >= 0)
                    {
                        Thread.Sleep(sleep);
                    }
                    else
                    {
                        Thread.Sleep(RefreshRate);
                    }
                }
            });
            return retVal;
        }

        private async void PopulateDeviceTree()
        {
            if (Devices.Count > 0)
            {
                List<TreeNode> nodes = new List<TreeNode>();

                foreach (var device in Devices)
                {
                    if (!DeviceTreeView.Nodes.ContainsKey(device.Key))
                    {
                        TreeNode deviceNode = new TreeNode(device.Key);

                        for (int i = 0; i < device.Value.TunerCount; i++)
                        {
                            TreeNode childNode = new TreeNode("Tuner " + i);
                            deviceNode.Nodes.Add(childNode);
                        }

                        nodes.Add(deviceNode);
                    }
                }

                if (nodes.Count > 0)
                {
                    DeviceTreeView.Invoke(new Action(delegate ()
                    {
                        DeviceTreeView.Nodes.Clear();
                        DeviceTreeView.Nodes.AddRange(nodes.ToArray());
                        DeviceTreeView.ExpandAll();
                        DeviceTreeView.SelectedNode = DeviceTreeView.Nodes[0];
                    }));
                }
            }

            await Task.Delay(10);
        }

        private async void PopulateChannelsTable(List<Channel> channels = null)
        {
            ChannelsDataGrid.Invoke(new Action(delegate ()
            {
                ChannelsDataGrid.Rows.Clear();
            }));

            if (SelectedDevice != null)
            {
                if (SelectedDevice.Channels.Count > 0)
                {
                    if (channels == null)
                        channels = SelectedDevice.Channels;

                    foreach (var channel in channels)
                    {
                        string[] input = {
                            channel.GuideNumber.ToString(),
                            channel.GuideName.ToString(),
                            channel.HD.ToString(),
                            channel.DRM.ToString(),
                            channel.AudioCodec.ToString(),
                            channel.VideoCodec.ToString(),
                            channel.URL
                        };

                        AddTableRow(input);
                    }
                }
            }

            await Task.Delay(10);
        }

        private void AddTableRow(string[] dataArray)
        {
            ChannelsDataGrid.Invoke(new MethodInvoker(() =>
            {
                ChannelsDataGrid.Rows.Add(dataArray);

                for (int i = 0; i < ChannelsDataGrid.Rows[ChannelsDataGrid.Rows.Count - 1].Cells.Count; i++)
                    ChannelsDataGrid.Rows[ChannelsDataGrid.Rows.Count - 1].Cells[i].ToolTipText = dataArray[i];
            }));
        }

        private async void UpdateGaugeValues()
        {
            try
            {
                if (SelectedTuner != null)
                {
                    SignalStrengthGauge.Invoke(new MethodInvoker(() =>
                    {
                        SignalStrengthGauge.Value = SelectedTuner.SignalStrength;
                    }));

                    SignalQualityGauge.Invoke(new MethodInvoker(() =>
                    {
                        SignalQualityGauge.Value = SelectedTuner.SignalQuality;
                    }));

                    SymbolQualityGauge.Invoke(new MethodInvoker(() =>
                    {
                        SymbolQualityGauge.Value = SelectedTuner.SymbolQuality;
                    }));

                    StreamingRateGauge.Invoke(new MethodInvoker(() =>
                    {
                        if (SelectedTuner.StreamingRate > StreamingRateGauge.To)
                        {
                            StreamingRateGauge.To = double.Parse(SelectedTuner.StreamingRate.ToString("0.0"));
                        }
                        StreamingRateGauge.Value = SelectedTuner.StreamingRate;
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            await Task.Delay(10);
        }

        private async void UpdateGraphValues()
        {
            DateTime now = DateTime.Now;

            lock (StreamingRateValues)
            {
                StreamingRateValues.Add(new MeasureModel() { DateTime = now, Value = SelectedTuner.StreamingRate });
                if (StreamingRateValues.Count > MaximumStoredValues)
                {
                    StreamingRateValues.RemoveAt(0);
                }
            }

            lock (SignalStrengthValues)
            {
                SignalStrengthValues.Add(new MeasureModel() { DateTime = now, Value = SelectedTuner.SignalStrength });
                if (SignalStrengthValues.Count > MaximumStoredValues)
                {
                    SignalStrengthValues.RemoveAt(0);
                }
            }

            lock (SignalQualityValues)
            {
                SignalQualityValues.Add(new MeasureModel() { DateTime = now, Value = SelectedTuner.SignalQuality });
                if (SignalQualityValues.Count > MaximumStoredValues)
                {
                    SignalQualityValues.RemoveAt(0);
                }
            }

            lock (SymbolQualityValues)
            {
                SymbolQualityValues.Add(new MeasureModel() { DateTime = now, Value = SelectedTuner.SymbolQuality });
                if (SymbolQualityValues.Count > MaximumStoredValues)
                {
                    SymbolQualityValues.RemoveAt(0);
                }
            }

            if (AdvancedGraphing != null)
                AdvancedGraphing.SetAxisLimits(DateTime.Now);

            SetAxisLimits(DateTime.Now);

            await Task.Delay(10);
        }

        private async void UpdateHUDValues()
        {
            if (SelectedTuner != null)
            {
                try
                {
                    HUDSignalQualityValue.Invoke(new Action(delegate ()
                    {
                        HUDSignalQualityValue.Text = SelectedTuner.SignalQuality.ToString() + "%";
                    }));
                    HUDSignalStrengthValue.Invoke(new Action(delegate ()
                    {
                        HUDSignalStrengthValue.Text = SelectedTuner.SignalStrength.ToString() + "%";
                    }));
                    HUDSymbolQualityValue.Invoke(new Action(delegate ()
                    {
                        HUDSymbolQualityValue.Text = SelectedTuner.SymbolQuality.ToString() + "%";
                    }));
                    HUDStreamingRateValue.Invoke(new Action(delegate ()
                    {
                        HUDStreamingRateValue.Text = SelectedTuner.StreamingRate.ToString() + "Mbps";
                    }));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                HUDSignalQualityValue.Invoke(new Action(delegate ()
                {
                    HUDSignalQualityValue.Text = "0%";
                }));
                HUDSignalStrengthValue.Invoke(new Action(delegate ()
                {
                    HUDSignalStrengthValue.Text = "0%";
                }));
                HUDSymbolQualityValue.Invoke(new Action(delegate ()
                {
                    HUDSymbolQualityValue.Text = "0%";
                }));
                HUDStreamingRateValue.Invoke(new Action(delegate ()
                {
                    HUDStreamingRateValue.Text = "0Mbps";
                }));
            }

            await Task.Delay(10);
        }

        private async Task RefreshDevices(string remoteHost = null, string user = null, string password = null)
        {
            await Task.Run(() =>
            {
                DeviceDiscoveryResponse response = null;

                if(!string.IsNullOrEmpty(remoteHost))
                {
                    RemoteDeviceDiscoveryRequest remoteRequest = new RemoteDeviceDiscoveryRequest(user, password, remoteHost, UseHDHRRemoteDiscovery);
                    response = new DeviceDiscoverer().DiscoverRemoteDevices(remoteRequest);
                }
                else
                {
                    if(UDPDiscovery)
                    {
                        response = new DeviceDiscoverer().DiscoverLocalDevicesByUDPBroadcast();
                    }
                    else
                    {
                        response = new DeviceDiscoverer().DiscoverLocalDevicesByMACAddress();
                    }
                }

                if(response != null)
                {
                    if (response.Exception != null)
                    {
                        MessageBox.Show(response.Exception.ToString());
                    }

                    if (response.DeviceLookup.Count > 0)
                    {
                        if (remoteHost != null)
                        {
                            RemoteDiscovery = true;
                        }

                        foreach (var device in response.DeviceLookup)
                        {
                            if (!Devices.ContainsKey(device.Key))
                            {
                                lock (Devices)
                                    Devices.Add(device.Key, device.Value);
                            }
                            else
                            {
                                device.Value.RefreshDeviceInfo();
                            }
                        }
                    }

                    if (Devices.Count > 0)
                    {
                        PopulateDeviceTree();
                    }
                }
            });
        }

        private Uri ReturnCurrentStreamUri()
        {
            try
            {
                if (SelectedTuner != null)
                {
                    if (SelectedTuner.VirtualChannel != null)
                    {
                        int.TryParse(SelectedTuner.VirtualChannel.Split(' ')[0], out int currentChannel);

                        if (currentChannel != 0)
                        {
                            Channel selectedChannel = SelectedDevice.Channels
                            .Find(x => x.GuideNumber == currentChannel);

                            if (selectedChannel != null)
                            {
                                return new Uri(selectedChannel.URL);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }

        private async void StartStream()
        {
            await Task.Run(() =>
            {
                if (RemoteDiscovery)
                {
                    MessageBox.Show("Streaming is disabled for remotely discovered devices.\nTry again from the local machine instead.", "Attention!");
                }
                else
                {
                    Uri streamUri = ReturnCurrentStreamUri();

                    if (streamUri != null)
                    {
                        try
                        {
                            StreamPlayer.Invoke(new Action(delegate ()
                            {
                                StreamPlayer.StartPlay(streamUri);
                            }));
                            StreamStatusTextBox.Invoke(new Action(delegate ()
                            {
                                StreamStatusTextBox.Clear();
                                StreamStatusTextBox.Text = "Opening Stream: " + streamUri.AbsoluteUri;
                            }));
                            OpenStreamButton.Invoke(new Action(delegate ()
                            {
                                OpenStreamButton.Text = "Close";
                            }));

                            Streaming = true;

                            DateTime sSTart = DateTime.Now;

                            while (Streaming)
                            {
                                TimeSpan duration = DateTime.Now - sSTart;

                                StreamTimeTextBox.Invoke(new Action(delegate ()
                                {
                                    StreamTimeTextBox.Text = new DateTime(duration.Ticks).ToString("HH:mm:ss");
                                }));

                                Thread.Sleep(100);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
            });
        }

        private async void StopStream()
        {
            if (Streaming)
            {
                try
                {
                    StreamPlayer.Invoke(new Action(delegate ()
                    {
                        StreamPlayer.Stop();
                    }));
                    StreamStatusTextBox.Invoke(new Action(delegate ()
                    {
                        StreamStatusTextBox.Clear();
                    }));
                    StreamTimeTextBox.Invoke(new Action(delegate ()
                    {
                        StreamTimeTextBox.Clear();
                    }));
                    OpenStreamButton.Invoke(new Action(delegate ()
                    {
                        OpenStreamButton.Text = "Open";
                    }));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Streaming = false;
            }
            await Task.Delay(100);
        }

        private async void RestartDevice()
        {
            string configPath = "c:\\Program Files\\SiliconDust\\HDHomerun\\hdhomerun_config.exe";
            if (!File.Exists(configPath))
            {
                MessageBox.Show("Unable to restart device.\nThis command requires hdhomerun_config.exe", "Oops!", MessageBoxButtons.OK);
            }
            else
            {
                Process p = new Process
                {
                    StartInfo = new ProcessStartInfo(configPath)
                    {
                        Arguments = $"{SelectedDevice.DeviceID} set /sys/restart self",
                        CreateNoWindow = true,
                        UseShellExecute = false
                    }
                };
                p.Start();
            }

            await Task.Delay(10);
        }

        private async void PopulateDeviceInfo()
        {
            DeviceAuthenticationTextBox.Text = SelectedDevice.Authenticated.ToString();
            DeviceFirmwareTextBox.Text = SelectedDevice.Firmware;
            DeviceModelTextBox.Text = SelectedDevice.Model;
            DeviceOOBLockTextBox.Text = SelectedDevice.OOBLock.ToString();
            DeviceIPTextBox.Text = SelectedDevice.DeviceIP.ToString();
            DeviceValidationTextBox.Text = SelectedDevice.Validated.ToString();
            DeviceMemoryTextBox.Text = SelectedDevice.MemoryReport;
            DeviceMACTextBox.Text = SelectedDevice.MACAddress;

            await Task.Delay(10);
        }

        private async void ClearGraphingValues()
        {
            StreamingRateValues.Clear();
            SignalQualityValues.Clear();
            SymbolQualityValues.Clear();
            SignalStrengthValues.Clear();

            await Task.Delay(10);
        }

        private async void OpenBrowser(bool large, string url = null, string content = null)
        {
            System.Drawing.Size size = new System.Drawing.Size(600, 600);

            if (large)
            {
                size.Width = 1500;
                size.Height = 1000;
            }

            Form form = new Form
            {
                Size = size
            };

            form.Controls.Add(new Panel()
            {
                Dock = DockStyle.Fill
            });

            WebBrowser browser = new WebBrowser()
            {
                Size = form.Controls[0].Size
            };

            if (content != null)
            {
                browser.DocumentText = content;
            }

            if (url != null)
            {
                browser.Navigate(url);
            }

            form.Controls[0].Controls.Add(browser);
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            browser.ScriptErrorsSuppressed = true;

            form.ShowDialog();

            await Task.Delay(10);
        }

        private async void StartFirmwareUpdate()
        {
            if (SelectedDevice != null)
            {
                try
                {
                    HttpWebRequest req = (HttpWebRequest)WebRequest.CreateHttp($"http://{SelectedDevice.DeviceIP}/system.post?upgrade=install");
                    req.Method = "POST";
                    req.Accept = "text/json";
                    using (HttpWebResponse startResponse = (HttpWebResponse)req.GetResponse())
                    {
                        if (startResponse.StatusCode == HttpStatusCode.OK)
                        {
                            OpenStreamButton.Invoke(new Action(delegate ()
                            {
                                FirmwareUpdateButton.Text = "Installing...";
                                FirmwareUpdateButton.Enabled = false;
                            }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            await Task.Delay(10);
        }



        /// <summary>
        /// Event Control
        /// </summary>
        // Devices
        private async void RefreshDevicesButton_Click(object sender, EventArgs e)
        {
            if (!Scanning)
            {
                RefreshDevicesButton.Text = "Scanning...";
                Scanning = true;

                await RefreshDevices();

                if (Devices.Count == 0)
                {
                    using (RemoteHostRequest request = new RemoteHostRequest())
                    {
                        request.ShowDialog();

                        if (request.DialogResult == DialogResult.OK)
                        {
                            if (!string.IsNullOrEmpty(request.HostName) && !string.IsNullOrEmpty(request.HostName) && !string.IsNullOrEmpty(request.Password))
                            {
                                if (UseHDHRConfig)
                                    UseHDHRConfigButton_Click(this, e); // disable the use of hdhrconfig for tuner data retrieval

                                if (request.HostName == "bananasip")
                                {
                                    string content = "<html><head>" +
                                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                                    "</head><body>" +
                                    "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/0GdXNaMos_w/" +
                                    " title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; " +
                                    "encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>" +
                                    "</body></html>";

                                    OpenBrowser(false, null, content);
                                }
                                else
                                {
                                    await RefreshDevices(request.HostName, request.User, request.Password);
                                }
                            }
                        }
                    };
                }

                RefreshDevicesButton.Text = "Refresh Devices";
                Scanning = false;
            }
        }

        private async void DeviceTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Set SelectedTuner and SelectedDevice here

            if (DeviceTreeView.SelectedNode != null)
            {
                if (DeviceTreeView.SelectedNode.Text.ToUpper().Contains("TUNER"))
                {
                    SelectedDevice = Devices[DeviceTreeView.SelectedNode.Parent.Text];
                    SelectedTuner = Devices[DeviceTreeView.SelectedNode.Parent.Text]
                        .Tuners[Convert.ToInt32(DeviceTreeView.SelectedNode.Text.Split(' ')[1])];
                }
                else
                {
                    SelectedDevice = Devices[DeviceTreeView.SelectedNode.Text];
                    SelectedTuner = SelectedDevice.Tuners.FirstOrDefault();
                }

                WebBrowser.Navigate(SelectedDevice.DeviceIP.ToString());

                string device = SelectedDevice.DeviceName;
                if (device.Length > 20)
                {
                    device = device.Substring(0, 20) + "...";
                }

                HUDDeviceTextBox.Text = device;
                HUDChannelTextBox.Text = SelectedTuner.VirtualChannel;

                TunerInfoChannelTextBox.Text = SelectedTuner.VirtualChannel;
                TunerInfoFrequencyTextBox.Text = SelectedTuner.Frequency.ToString() + "MHz";
                TunerInfoModulationTextBox.Text = SelectedTuner.ModulationLock;
                TunerInfoPCRTextBox.Text = SelectedTuner.PCRLock;
                TunerInfoProgramNumberTextBox.Text = SelectedTuner.ProgramNumber.ToString();

                if (SelectedDevice.UpdateAvailable)
                {
                    FirmwareUpdateButton.Enabled = true;
                    FirmwareUpdateButton.Text = SelectedDevice.AvailableRelease;
                }
                else
                {
                    FirmwareUpdateButton.Enabled = false;
                    FirmwareUpdateButton.Text = "Unavailable";
                }

                if (SelectedDevice.IsUpdating)
                {
                    FirmwareUpdateButton.Enabled = false;
                    FirmwareUpdateButton.Text = "Installing...";
                }

                if (AdvancedGraphing != null)
                {
                    AdvancedGraphing.Invoke(new Action(delegate ()
                    {
                        if (SelectedTuner != null)
                        {
                            AdvancedGraphing.DeviceID = SelectedDevice.DeviceID;
                            AdvancedGraphing.TunerNumber = SelectedTuner.TunerNumber;
                        }
                        AdvancedGraphing.ClearAllValues();
                    }));
                }

                // Populate device info panel
                PopulateDeviceInfo();

                // Clear all graphing values
                ClearGraphingValues();
                SetAxisLimits(DateTime.Now);

                // Populate channels tab
                PopulateChannelsTable();

                // Re-initialize and update gauges to reset peaks
                InitializeGauges();
                UpdateGaugeValues();
            }

            await Task.Delay(10);
        }

        private void RestartDeviceButton_Click(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                RestartDevice();
            }
        }


        // Streams
        private async void OpenStreamButton_Click(object sender, EventArgs e)
        {
            if (Streaming)
            {
                StopStream();
            }
            else
            {
                StartStream();
            }

            await Task.Delay(10);
        }


        // Channels
        private void ChannelsRefreshButton_Click(object sender, EventArgs e)
        {
            PopulateChannelsTable();
        }

        private void ChannelsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                if (SelectedDevice.Channels.Count > 0)
                {
                    if (!string.IsNullOrEmpty(ChannelsSearchTextBox.Text))
                    {
                        PopulateChannelsTable(SelectedDevice.Channels.Where(x => x.GuideName.Contains(ChannelsSearchTextBox.Text)).ToList());
                    }
                    else
                    {
                        PopulateChannelsTable();
                    }
                }
            }
        }


        // Browser
        private void BrowserOpenButton_Click(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                try
                {
                    Process p = new Process()
                    {
                        StartInfo = new ProcessStartInfo
                            ("chrome.exe", $"http://{SelectedDevice.DeviceIP}")
                    };

                    p.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void BrowserHomeButton_Click(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                WebBrowser.Navigate(SelectedDevice.DeviceIP.ToString());
            }
        }

        private void BrowserBackButton_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoBack)
            {
                WebBrowser.GoBack();
            }
        }

        private void BrowserForwardButton_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoForward)
            {
                WebBrowser.GoForward();
            }
        }

        private void GraphingAdvancedButton_Click(object sender, EventArgs e)
        {
            Thread advG = new Thread(() =>
            {
                GraphingSignalGraph.Invoke(new Action(delegate ()
                {
                    GraphingSignalGraph.Visible = false;
                    GraphingSignalGraph.UpdaterState = UpdaterState.Paused;
                }));
                GraphingStreamingGraph.Invoke(new Action(delegate ()
                {
                    GraphingStreamingGraph.Visible = false;
                    GraphingStreamingGraph.UpdaterState = UpdaterState.Paused;
                }));
                GraphingAdvancedButton.Invoke(new Action(delegate ()
                {
                    GraphingAdvancedButton.Enabled = false;
                }));

                using (AdvancedGraphing advGraphing = new AdvancedGraphing())
                {
                    AdvancedGraphing = advGraphing;

                    advGraphing.StreamingRateValues = StreamingRateValues;
                    advGraphing.SignalQualityValues = SignalQualityValues;
                    advGraphing.SignalStrengthValues = SignalStrengthValues;
                    advGraphing.SymbolQualityValues = SymbolQualityValues;
                    advGraphing.RefreshRate = RefreshRate;
                    advGraphing.GraphingDurationSeconds = GraphingDurationSeconds;

                    if (SelectedTuner != null)
                    {
                        advGraphing.DeviceID = SelectedDevice.DeviceID;
                        advGraphing.TunerNumber = SelectedTuner.TunerNumber;
                    }

                    advGraphing.ShowDialog();
                };

                AdvancedGraphing = null;

                GraphingSignalGraph.Invoke(new Action(delegate ()
                {
                    GraphingSignalGraph.Visible = true;
                    GraphingSignalGraph.UpdaterState = UpdaterState.Running;
                }));
                GraphingStreamingGraph.Invoke(new Action(delegate ()
                {
                    GraphingStreamingGraph.Visible = true;
                    GraphingStreamingGraph.UpdaterState = UpdaterState.Running;
                }));
                GraphingAdvancedButton.Invoke(new Action(delegate ()
                {
                    GraphingAdvancedButton.Enabled = true;
                }));
            });
            advG.SetApartmentState(ApartmentState.STA);
            advG.Start();
        }

        private void SettingsPageRefreshRateValue_ValueChanged(object sender, EventArgs e)
        {
            RefreshRate = (int)(SettingsPageRefreshRateValue.Value * 1000);
        }





        // Menu Control (buttons and shit)

        private void MenuButtonSelected(Button btn)
        {
            btn.BackColor = System.Drawing.Color.LightSkyBlue;
            btn.ForeColor = System.Drawing.Color.Black;
        }

        private void ResetMenuButtons()
        {
            foreach (Button button in MenuButtons)
            {
                button.ForeColor = System.Drawing.Color.White;
                button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }

        private void MenuTunerInfoButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
            ResetMenuButtons();
            MenuButtonSelected(MenuTunerInfoButton);
        }

        private void MenuBrowserButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
            ResetMenuButtons();
            MenuButtonSelected(MenuBrowserButton);
        }

        private void MenuStreamingButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;
            ResetMenuButtons();
            MenuButtonSelected(MenuStreamingButton);
        }

        private void MenuChannelsButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;
            ResetMenuButtons();
            MenuButtonSelected(MenuChannelsButton);
        }

        private void MenuGraphingButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 4;
            ResetMenuButtons();
            MenuButtonSelected(MenuGraphingButton);
        }

        private void MenuDeviceInfoButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 5;
            ResetMenuButtons();
            MenuButtonSelected(MenuDeviceInfoButton);
        }

        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 6;
            ResetMenuButtons();
            MenuButtonSelected(MenuSettingsButton);
        }

        private void GraphingEnabledButton_Click(object sender, EventArgs e)
        {
            if (GraphingSignalGraph.UpdaterState == UpdaterState.Paused && GraphingStreamingGraph.UpdaterState == UpdaterState.Paused)
            {
                InitializeGraphs();

                GraphingEnabledButton.Text = "Enabled";
                GraphingEnabledButton.BackColor = System.Drawing.Color.LightGreen;
                GraphingAdvancedButton.Enabled = true;
                GraphingSignalGraph.UpdaterState = UpdaterState.Running;
                GraphingSignalGraph.Visible = true;
                GraphingStreamingGraph.UpdaterState = UpdaterState.Running;
                GraphingStreamingGraph.Visible = true;
            }
            else
            {
                GraphingEnabledButton.Text = "Disabled";
                GraphingEnabledButton.BackColor = System.Drawing.Color.Gray;
                GraphingAdvancedButton.Enabled = false;
                GraphingSignalGraph.UpdaterState = UpdaterState.Paused;
                GraphingSignalGraph.Visible = false;
                GraphingStreamingGraph.UpdaterState = UpdaterState.Paused;
                GraphingStreamingGraph.Visible = false;
            }
        }

        private void CardPairingButton_Click(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                OpenBrowser(
                false,
                string.Format("http://{0}/cc.html",
                SelectedDevice.DeviceIP),
                null
                );
            }
        }

        private void FirmwareUpdateButton_Click(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                StartFirmwareUpdate();
            }
        }

        private void RestartDeviceButton2_Click(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                RestartDeviceButton_Click(this, e);
            }
        }

        private void DeviceLogsButton_Click(object sender, EventArgs e)
        {
            if (SelectedDevice != null)
            {
                OpenBrowser(true, $"{SelectedDevice.DeviceIP}/log.html", null);
            }
        }

        private void UDPDiscoveryButton_Click(object sender, EventArgs e)
        {
            if (!UDPDiscovery)
            {
                UDPDiscovery = true;
                UDPDiscoveryButton.Text = "Enabled";
                UDPDiscoveryButton.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                UDPDiscovery = false;
                UDPDiscoveryButton.Text = "Disabled";
                UDPDiscoveryButton.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void MaxStoredValues_ValueChanged(object sender, EventArgs e)
        {
            MaximumStoredValues = (int)MaxStoredValues.Value;
        }

        private void UseHDHRConfigButton_Click(object sender, EventArgs e)
        {
            if (!UseHDHRConfig)
            {
                if (!RemoteDiscovery)
                {
                    UseHDHRConfig = true;
                    UseHDHRConfigButton.Text = "Enabled";
                    UseHDHRConfigButton.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    MessageBox.Show("This feature can only be enabled for LOCAL devices.", "Sorry!");
                }

            }
            else
            {
                UseHDHRConfig = false;
                UseHDHRConfigButton.Text = "Disabled";
                UseHDHRConfigButton.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void HDHRDiscoverButton_Click(object sender, EventArgs e)
        {
            if (!UseHDHRRemoteDiscovery)
            {
                UseHDHRRemoteDiscovery = true;
                HDHRDiscoverButton.Text = "Enabled";
                HDHRDiscoverButton.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                UseHDHRRemoteDiscovery = false;
                HDHRDiscoverButton.Text = "Disabled";
                HDHRDiscoverButton.BackColor = System.Drawing.Color.Gray;
            }
        }
    }
}
