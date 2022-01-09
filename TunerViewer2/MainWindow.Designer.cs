
namespace TunerViewer2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.DevicesPanel = new System.Windows.Forms.Panel();
            this.RefreshDevicesButton = new System.Windows.Forms.Button();
            this.RestartDeviceButton = new System.Windows.Forms.Button();
            this.DeviceTreeView = new System.Windows.Forms.TreeView();
            this.ControllerPanel = new System.Windows.Forms.Panel();
            this.MenuButtonsPanel = new System.Windows.Forms.Panel();
            this.MenuSettingsButton = new System.Windows.Forms.Button();
            this.MenuDeviceInfoButton = new System.Windows.Forms.Button();
            this.MenuGraphingButton = new System.Windows.Forms.Button();
            this.MenuChannelsButton = new System.Windows.Forms.Button();
            this.MenuStreamingButton = new System.Windows.Forms.Button();
            this.MenuBrowserButton = new System.Windows.Forms.Button();
            this.MenuTunerInfoButton = new System.Windows.Forms.Button();
            this.SelectedDeviceControllerPanel = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabTunerInfoPage = new System.Windows.Forms.TabPage();
            this.GaugesPanel = new System.Windows.Forms.Panel();
            this.SignalStrengthGauge = new LiveCharts.WinForms.SolidGauge();
            this.StreamingRateGauge = new LiveCharts.WinForms.SolidGauge();
            this.SignalQualityGauge = new LiveCharts.WinForms.SolidGauge();
            this.SymbolQualityGauge = new LiveCharts.WinForms.SolidGauge();
            this.TunerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TunerInfoGroupBoxPanel = new System.Windows.Forms.Panel();
            this.TunerInfoModulationTextBox = new System.Windows.Forms.TextBox();
            this.TunerInfoModulationLabel = new System.Windows.Forms.Label();
            this.TunerInfoProgramNumberTextBox = new System.Windows.Forms.TextBox();
            this.TunerInfoProgramNumberLabel = new System.Windows.Forms.Label();
            this.TunerInfoPCRTextBox = new System.Windows.Forms.TextBox();
            this.TunerInfoPCRLabel = new System.Windows.Forms.Label();
            this.TunerInfoFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.TunerInfoFrequencyLabel = new System.Windows.Forms.Label();
            this.TunerInfoChannelTextBox = new System.Windows.Forms.TextBox();
            this.TunerInfoChannelLabel = new System.Windows.Forms.Label();
            this.StreamingRateLabel = new System.Windows.Forms.Label();
            this.SymbolQualityLabel = new System.Windows.Forms.Label();
            this.SignalQualityLabel = new System.Windows.Forms.Label();
            this.SignalStrengthLabel = new System.Windows.Forms.Label();
            this.TabBrowserPage = new System.Windows.Forms.TabPage();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.BrowserControlPanel = new System.Windows.Forms.Panel();
            this.BrowserOpenButton = new System.Windows.Forms.Button();
            this.BrowserForwardButton = new System.Windows.Forms.Button();
            this.BrowserBackButton = new System.Windows.Forms.Button();
            this.BrowserHomeButton = new System.Windows.Forms.Button();
            this.TabStreamPage = new System.Windows.Forms.TabPage();
            this.OpenStreamButton = new System.Windows.Forms.Button();
            this.StreamTimeTextBox = new System.Windows.Forms.TextBox();
            this.StreamStatusTextBox = new System.Windows.Forms.TextBox();
            this.StreamPlayer = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.TabChannelsPage = new System.Windows.Forms.TabPage();
            this.ChannelsDataGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AudioCodec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoCodec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelsMenuPanel = new System.Windows.Forms.Panel();
            this.ChannelsSearchLabel = new System.Windows.Forms.Label();
            this.ChannelsSearchTextBox = new System.Windows.Forms.TextBox();
            this.ChannelsRefreshButton = new System.Windows.Forms.Button();
            this.TabGraphingPage = new System.Windows.Forms.TabPage();
            this.GraphingPanel = new System.Windows.Forms.Panel();
            this.GraphingAdvancedButton = new System.Windows.Forms.Button();
            this.GraphingStreamingGraph = new LiveCharts.WinForms.CartesianChart();
            this.GraphingSignalGraph = new LiveCharts.WinForms.CartesianChart();
            this.TabDevicePage = new System.Windows.Forms.TabPage();
            this.DeviceInfoGBPanel = new System.Windows.Forms.Panel();
            this.DeviceLogsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeviceValidationTextBox = new System.Windows.Forms.TextBox();
            this.DeviceOOBLockTextBox = new System.Windows.Forms.TextBox();
            this.DeviceAuthenticationTextBox = new System.Windows.Forms.TextBox();
            this.DeviceValidationLabel = new System.Windows.Forms.Label();
            this.DeviceOOBLockLabel = new System.Windows.Forms.Label();
            this.DeviceAuthenticationLabel = new System.Windows.Forms.Label();
            this.DeviceControlGroupBox = new System.Windows.Forms.GroupBox();
            this.CardPairingButton = new System.Windows.Forms.Button();
            this.CardPairingLabel = new System.Windows.Forms.Label();
            this.RestartDeviceButton2 = new System.Windows.Forms.Button();
            this.RestartDeviceLabel = new System.Windows.Forms.Label();
            this.FirmwareUpdateButton = new System.Windows.Forms.Button();
            this.FirmwareUpdateLabel = new System.Windows.Forms.Label();
            this.DeviceInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DeviceMACLabel = new System.Windows.Forms.Label();
            this.DeviceMACTextBox = new System.Windows.Forms.TextBox();
            this.DeviceMemoryTextBox = new System.Windows.Forms.TextBox();
            this.DeviceMemoryLabel = new System.Windows.Forms.Label();
            this.DeviceIPTextBox = new System.Windows.Forms.TextBox();
            this.DeviceFirmwareTextBox = new System.Windows.Forms.TextBox();
            this.DeviceModelTextBox = new System.Windows.Forms.TextBox();
            this.DeviceIPLabel = new System.Windows.Forms.Label();
            this.DeviceFirmwareLabel = new System.Windows.Forms.Label();
            this.DeviceModelLabel = new System.Windows.Forms.Label();
            this.TabSettingsPage = new System.Windows.Forms.TabPage();
            this.GraphingControlGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxStoredValuesLabel = new System.Windows.Forms.Label();
            this.MaxStoredValues = new System.Windows.Forms.NumericUpDown();
            this.GraphingEnabledLabel = new System.Windows.Forms.Label();
            this.GraphingEnabledButton = new System.Windows.Forms.Button();
            this.LocalDiscoveryGroupBox = new System.Windows.Forms.GroupBox();
            this.UDPDiscoveryLabel = new System.Windows.Forms.Label();
            this.UDPDiscoveryButton = new System.Windows.Forms.Button();
            this.TunerViewerLabel = new System.Windows.Forms.Label();
            this.SettingsDataGroupBox = new System.Windows.Forms.GroupBox();
            this.UseHDHRConfigLabel = new System.Windows.Forms.Label();
            this.SettingsPageRefreshRateValue = new System.Windows.Forms.NumericUpDown();
            this.UseHDHRConfigButton = new System.Windows.Forms.Button();
            this.RefreshRateLabel = new System.Windows.Forms.Label();
            this.DeviceInfoPanel = new System.Windows.Forms.Panel();
            this.RefreshStatusLED = new System.Windows.Forms.Button();
            this.HUDStreamingRateValue = new System.Windows.Forms.TextBox();
            this.HUDSymbolQualityValue = new System.Windows.Forms.TextBox();
            this.HUDSignalQualityValue = new System.Windows.Forms.TextBox();
            this.HUDSignalStrengthValue = new System.Windows.Forms.TextBox();
            this.HUDStreamingRateLabel = new System.Windows.Forms.Label();
            this.HUDSymbolQualityLabel = new System.Windows.Forms.Label();
            this.HUDSignalQualityLabel = new System.Windows.Forms.Label();
            this.HUDSignalStrengthLabel = new System.Windows.Forms.Label();
            this.HUDChannelTextBox = new System.Windows.Forms.TextBox();
            this.HUDChannelLabel = new System.Windows.Forms.Label();
            this.HUDDeviceTextBox = new System.Windows.Forms.TextBox();
            this.HUDDeviceLabel = new System.Windows.Forms.Label();
            this.UDPDiscoveryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UseHDHRConfigToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RemoteDiscoveryGroupBox = new System.Windows.Forms.GroupBox();
            this.HDHRDiscoverLabel = new System.Windows.Forms.Label();
            this.HDHRDiscoverButton = new System.Windows.Forms.Button();
            this.UseRemoteHDHRDiscovery = new System.Windows.Forms.ToolTip(this.components);
            this.DevicesPanel.SuspendLayout();
            this.ControllerPanel.SuspendLayout();
            this.MenuButtonsPanel.SuspendLayout();
            this.SelectedDeviceControllerPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabTunerInfoPage.SuspendLayout();
            this.GaugesPanel.SuspendLayout();
            this.TunerInfoGroupBox.SuspendLayout();
            this.TunerInfoGroupBoxPanel.SuspendLayout();
            this.TabBrowserPage.SuspendLayout();
            this.BrowserControlPanel.SuspendLayout();
            this.TabStreamPage.SuspendLayout();
            this.TabChannelsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelsDataGrid)).BeginInit();
            this.ChannelsMenuPanel.SuspendLayout();
            this.TabGraphingPage.SuspendLayout();
            this.GraphingPanel.SuspendLayout();
            this.TabDevicePage.SuspendLayout();
            this.DeviceInfoGBPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DeviceControlGroupBox.SuspendLayout();
            this.DeviceInfoGroupBox.SuspendLayout();
            this.TabSettingsPage.SuspendLayout();
            this.GraphingControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStoredValues)).BeginInit();
            this.LocalDiscoveryGroupBox.SuspendLayout();
            this.SettingsDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPageRefreshRateValue)).BeginInit();
            this.DeviceInfoPanel.SuspendLayout();
            this.RemoteDiscoveryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DevicesPanel
            // 
            this.DevicesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DevicesPanel.Controls.Add(this.RefreshDevicesButton);
            this.DevicesPanel.Controls.Add(this.RestartDeviceButton);
            this.DevicesPanel.Controls.Add(this.DeviceTreeView);
            this.DevicesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DevicesPanel.Location = new System.Drawing.Point(0, 0);
            this.DevicesPanel.Name = "DevicesPanel";
            this.DevicesPanel.Size = new System.Drawing.Size(123, 449);
            this.DevicesPanel.TabIndex = 0;
            // 
            // RefreshDevicesButton
            // 
            this.RefreshDevicesButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RefreshDevicesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RefreshDevicesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.RefreshDevicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshDevicesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshDevicesButton.Location = new System.Drawing.Point(-1, -1);
            this.RefreshDevicesButton.Name = "RefreshDevicesButton";
            this.RefreshDevicesButton.Size = new System.Drawing.Size(124, 27);
            this.RefreshDevicesButton.TabIndex = 1;
            this.RefreshDevicesButton.Text = "Refresh Devices";
            this.RefreshDevicesButton.UseVisualStyleBackColor = false;
            this.RefreshDevicesButton.Click += new System.EventHandler(this.RefreshDevicesButton_Click);
            // 
            // RestartDeviceButton
            // 
            this.RestartDeviceButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RestartDeviceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RestartDeviceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.RestartDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartDeviceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RestartDeviceButton.Location = new System.Drawing.Point(-1, 422);
            this.RestartDeviceButton.Name = "RestartDeviceButton";
            this.RestartDeviceButton.Size = new System.Drawing.Size(124, 26);
            this.RestartDeviceButton.TabIndex = 2;
            this.RestartDeviceButton.Text = "Restart Device";
            this.RestartDeviceButton.UseVisualStyleBackColor = false;
            this.RestartDeviceButton.Click += new System.EventHandler(this.RestartDeviceButton_Click);
            // 
            // DeviceTreeView
            // 
            this.DeviceTreeView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeviceTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceTreeView.Indent = 25;
            this.DeviceTreeView.Location = new System.Drawing.Point(-1, 24);
            this.DeviceTreeView.Name = "DeviceTreeView";
            this.DeviceTreeView.ShowNodeToolTips = true;
            this.DeviceTreeView.ShowPlusMinus = false;
            this.DeviceTreeView.Size = new System.Drawing.Size(124, 401);
            this.DeviceTreeView.TabIndex = 0;
            this.DeviceTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DeviceTreeView_AfterSelect);
            // 
            // ControllerPanel
            // 
            this.ControllerPanel.Controls.Add(this.MenuButtonsPanel);
            this.ControllerPanel.Controls.Add(this.SelectedDeviceControllerPanel);
            this.ControllerPanel.Controls.Add(this.DeviceInfoPanel);
            this.ControllerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControllerPanel.Location = new System.Drawing.Point(123, 0);
            this.ControllerPanel.Name = "ControllerPanel";
            this.ControllerPanel.Size = new System.Drawing.Size(667, 449);
            this.ControllerPanel.TabIndex = 1;
            // 
            // MenuButtonsPanel
            // 
            this.MenuButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuButtonsPanel.Controls.Add(this.MenuSettingsButton);
            this.MenuButtonsPanel.Controls.Add(this.MenuDeviceInfoButton);
            this.MenuButtonsPanel.Controls.Add(this.MenuGraphingButton);
            this.MenuButtonsPanel.Controls.Add(this.MenuChannelsButton);
            this.MenuButtonsPanel.Controls.Add(this.MenuStreamingButton);
            this.MenuButtonsPanel.Controls.Add(this.MenuBrowserButton);
            this.MenuButtonsPanel.Controls.Add(this.MenuTunerInfoButton);
            this.MenuButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuButtonsPanel.Location = new System.Drawing.Point(0, 61);
            this.MenuButtonsPanel.Name = "MenuButtonsPanel";
            this.MenuButtonsPanel.Size = new System.Drawing.Size(667, 33);
            this.MenuButtonsPanel.TabIndex = 3;
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.MenuSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSettingsButton.ForeColor = System.Drawing.Color.White;
            this.MenuSettingsButton.Location = new System.Drawing.Point(569, -1);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Size = new System.Drawing.Size(97, 33);
            this.MenuSettingsButton.TabIndex = 6;
            this.MenuSettingsButton.Text = "Settings";
            this.MenuSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuSettingsButton.UseMnemonic = false;
            this.MenuSettingsButton.UseVisualStyleBackColor = false;
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuDeviceInfoButton
            // 
            this.MenuDeviceInfoButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuDeviceInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuDeviceInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.MenuDeviceInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuDeviceInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDeviceInfoButton.ForeColor = System.Drawing.Color.White;
            this.MenuDeviceInfoButton.Location = new System.Drawing.Point(474, -1);
            this.MenuDeviceInfoButton.Name = "MenuDeviceInfoButton";
            this.MenuDeviceInfoButton.Size = new System.Drawing.Size(97, 33);
            this.MenuDeviceInfoButton.TabIndex = 5;
            this.MenuDeviceInfoButton.Text = "Device Info";
            this.MenuDeviceInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuDeviceInfoButton.UseMnemonic = false;
            this.MenuDeviceInfoButton.UseVisualStyleBackColor = false;
            this.MenuDeviceInfoButton.Click += new System.EventHandler(this.MenuDeviceInfoButton_Click);
            // 
            // MenuGraphingButton
            // 
            this.MenuGraphingButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuGraphingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuGraphingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.MenuGraphingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuGraphingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGraphingButton.ForeColor = System.Drawing.Color.White;
            this.MenuGraphingButton.Location = new System.Drawing.Point(379, -1);
            this.MenuGraphingButton.Name = "MenuGraphingButton";
            this.MenuGraphingButton.Size = new System.Drawing.Size(97, 33);
            this.MenuGraphingButton.TabIndex = 4;
            this.MenuGraphingButton.Text = "Graphing";
            this.MenuGraphingButton.UseVisualStyleBackColor = false;
            this.MenuGraphingButton.Click += new System.EventHandler(this.MenuGraphingButton_Click);
            // 
            // MenuChannelsButton
            // 
            this.MenuChannelsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuChannelsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuChannelsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.MenuChannelsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuChannelsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuChannelsButton.ForeColor = System.Drawing.Color.White;
            this.MenuChannelsButton.Location = new System.Drawing.Point(284, -1);
            this.MenuChannelsButton.Name = "MenuChannelsButton";
            this.MenuChannelsButton.Size = new System.Drawing.Size(97, 33);
            this.MenuChannelsButton.TabIndex = 3;
            this.MenuChannelsButton.Text = "Channels";
            this.MenuChannelsButton.UseVisualStyleBackColor = false;
            this.MenuChannelsButton.Click += new System.EventHandler(this.MenuChannelsButton_Click);
            // 
            // MenuStreamingButton
            // 
            this.MenuStreamingButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuStreamingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuStreamingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.MenuStreamingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuStreamingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStreamingButton.ForeColor = System.Drawing.Color.White;
            this.MenuStreamingButton.Location = new System.Drawing.Point(189, -1);
            this.MenuStreamingButton.Name = "MenuStreamingButton";
            this.MenuStreamingButton.Size = new System.Drawing.Size(97, 33);
            this.MenuStreamingButton.TabIndex = 2;
            this.MenuStreamingButton.Text = "Streaming";
            this.MenuStreamingButton.UseVisualStyleBackColor = false;
            this.MenuStreamingButton.Click += new System.EventHandler(this.MenuStreamingButton_Click);
            // 
            // MenuBrowserButton
            // 
            this.MenuBrowserButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBrowserButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuBrowserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.MenuBrowserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBrowserButton.ForeColor = System.Drawing.Color.White;
            this.MenuBrowserButton.Location = new System.Drawing.Point(94, -1);
            this.MenuBrowserButton.Name = "MenuBrowserButton";
            this.MenuBrowserButton.Size = new System.Drawing.Size(97, 33);
            this.MenuBrowserButton.TabIndex = 1;
            this.MenuBrowserButton.Text = "Browser";
            this.MenuBrowserButton.UseVisualStyleBackColor = false;
            this.MenuBrowserButton.Click += new System.EventHandler(this.MenuBrowserButton_Click);
            // 
            // MenuTunerInfoButton
            // 
            this.MenuTunerInfoButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuTunerInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuTunerInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.MenuTunerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuTunerInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTunerInfoButton.ForeColor = System.Drawing.Color.White;
            this.MenuTunerInfoButton.Location = new System.Drawing.Point(-2, -1);
            this.MenuTunerInfoButton.Name = "MenuTunerInfoButton";
            this.MenuTunerInfoButton.Size = new System.Drawing.Size(98, 33);
            this.MenuTunerInfoButton.TabIndex = 0;
            this.MenuTunerInfoButton.Text = "Tuner Info";
            this.MenuTunerInfoButton.UseVisualStyleBackColor = false;
            this.MenuTunerInfoButton.Click += new System.EventHandler(this.MenuTunerInfoButton_Click);
            // 
            // SelectedDeviceControllerPanel
            // 
            this.SelectedDeviceControllerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedDeviceControllerPanel.Controls.Add(this.TabControl);
            this.SelectedDeviceControllerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedDeviceControllerPanel.Location = new System.Drawing.Point(0, 94);
            this.SelectedDeviceControllerPanel.Name = "SelectedDeviceControllerPanel";
            this.SelectedDeviceControllerPanel.Size = new System.Drawing.Size(667, 355);
            this.SelectedDeviceControllerPanel.TabIndex = 2;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabTunerInfoPage);
            this.TabControl.Controls.Add(this.TabBrowserPage);
            this.TabControl.Controls.Add(this.TabStreamPage);
            this.TabControl.Controls.Add(this.TabChannelsPage);
            this.TabControl.Controls.Add(this.TabGraphingPage);
            this.TabControl.Controls.Add(this.TabDevicePage);
            this.TabControl.Controls.Add(this.TabSettingsPage);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(-7, -26);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(678, 387);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 5;
            // 
            // TabTunerInfoPage
            // 
            this.TabTunerInfoPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TabTunerInfoPage.Controls.Add(this.GaugesPanel);
            this.TabTunerInfoPage.Location = new System.Drawing.Point(4, 25);
            this.TabTunerInfoPage.Name = "TabTunerInfoPage";
            this.TabTunerInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabTunerInfoPage.Size = new System.Drawing.Size(670, 358);
            this.TabTunerInfoPage.TabIndex = 0;
            this.TabTunerInfoPage.Text = "Tuner Info";
            // 
            // GaugesPanel
            // 
            this.GaugesPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GaugesPanel.Controls.Add(this.SignalStrengthGauge);
            this.GaugesPanel.Controls.Add(this.StreamingRateGauge);
            this.GaugesPanel.Controls.Add(this.SignalQualityGauge);
            this.GaugesPanel.Controls.Add(this.SymbolQualityGauge);
            this.GaugesPanel.Controls.Add(this.TunerInfoGroupBox);
            this.GaugesPanel.Controls.Add(this.StreamingRateLabel);
            this.GaugesPanel.Controls.Add(this.SymbolQualityLabel);
            this.GaugesPanel.Controls.Add(this.SignalQualityLabel);
            this.GaugesPanel.Controls.Add(this.SignalStrengthLabel);
            this.GaugesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GaugesPanel.Location = new System.Drawing.Point(3, 3);
            this.GaugesPanel.Name = "GaugesPanel";
            this.GaugesPanel.Size = new System.Drawing.Size(664, 355);
            this.GaugesPanel.TabIndex = 4;
            // 
            // SignalStrengthGauge
            // 
            this.SignalStrengthGauge.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignalStrengthGauge.Location = new System.Drawing.Point(12, 9);
            this.SignalStrengthGauge.Name = "SignalStrengthGauge";
            this.SignalStrengthGauge.Size = new System.Drawing.Size(203, 129);
            this.SignalStrengthGauge.TabIndex = 0;
            this.SignalStrengthGauge.Text = "Signal Strength";
            // 
            // StreamingRateGauge
            // 
            this.StreamingRateGauge.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StreamingRateGauge.Location = new System.Drawing.Point(45, 207);
            this.StreamingRateGauge.Name = "StreamingRateGauge";
            this.StreamingRateGauge.Size = new System.Drawing.Size(142, 98);
            this.StreamingRateGauge.TabIndex = 3;
            this.StreamingRateGauge.Text = "Streaming Rate";
            // 
            // SignalQualityGauge
            // 
            this.SignalQualityGauge.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignalQualityGauge.Location = new System.Drawing.Point(229, 9);
            this.SignalQualityGauge.Name = "SignalQualityGauge";
            this.SignalQualityGauge.Size = new System.Drawing.Size(203, 129);
            this.SignalQualityGauge.TabIndex = 1;
            this.SignalQualityGauge.Text = "Signal Quality";
            // 
            // SymbolQualityGauge
            // 
            this.SymbolQualityGauge.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SymbolQualityGauge.Location = new System.Drawing.Point(446, 9);
            this.SymbolQualityGauge.Name = "SymbolQualityGauge";
            this.SymbolQualityGauge.Size = new System.Drawing.Size(203, 129);
            this.SymbolQualityGauge.TabIndex = 2;
            this.SymbolQualityGauge.Text = "Symbol Quality";
            // 
            // TunerInfoGroupBox
            // 
            this.TunerInfoGroupBox.Controls.Add(this.TunerInfoGroupBoxPanel);
            this.TunerInfoGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TunerInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TunerInfoGroupBox.Location = new System.Drawing.Point(226, 178);
            this.TunerInfoGroupBox.Name = "TunerInfoGroupBox";
            this.TunerInfoGroupBox.Size = new System.Drawing.Size(419, 164);
            this.TunerInfoGroupBox.TabIndex = 8;
            this.TunerInfoGroupBox.TabStop = false;
            this.TunerInfoGroupBox.Text = "Tuner Info";
            // 
            // TunerInfoGroupBoxPanel
            // 
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoModulationTextBox);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoModulationLabel);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoProgramNumberTextBox);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoProgramNumberLabel);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoPCRTextBox);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoPCRLabel);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoFrequencyTextBox);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoFrequencyLabel);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoChannelTextBox);
            this.TunerInfoGroupBoxPanel.Controls.Add(this.TunerInfoChannelLabel);
            this.TunerInfoGroupBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TunerInfoGroupBoxPanel.Location = new System.Drawing.Point(3, 17);
            this.TunerInfoGroupBoxPanel.Name = "TunerInfoGroupBoxPanel";
            this.TunerInfoGroupBoxPanel.Size = new System.Drawing.Size(413, 144);
            this.TunerInfoGroupBoxPanel.TabIndex = 0;
            // 
            // TunerInfoModulationTextBox
            // 
            this.TunerInfoModulationTextBox.Enabled = false;
            this.TunerInfoModulationTextBox.Location = new System.Drawing.Point(305, 100);
            this.TunerInfoModulationTextBox.Name = "TunerInfoModulationTextBox";
            this.TunerInfoModulationTextBox.ReadOnly = true;
            this.TunerInfoModulationTextBox.Size = new System.Drawing.Size(75, 21);
            this.TunerInfoModulationTextBox.TabIndex = 9;
            this.TunerInfoModulationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TunerInfoModulationLabel
            // 
            this.TunerInfoModulationLabel.AutoSize = true;
            this.TunerInfoModulationLabel.Location = new System.Drawing.Point(294, 79);
            this.TunerInfoModulationLabel.Name = "TunerInfoModulationLabel";
            this.TunerInfoModulationLabel.Size = new System.Drawing.Size(98, 15);
            this.TunerInfoModulationLabel.TabIndex = 8;
            this.TunerInfoModulationLabel.Text = "Modulation Lock";
            // 
            // TunerInfoProgramNumberTextBox
            // 
            this.TunerInfoProgramNumberTextBox.Enabled = false;
            this.TunerInfoProgramNumberTextBox.Location = new System.Drawing.Point(305, 44);
            this.TunerInfoProgramNumberTextBox.Name = "TunerInfoProgramNumberTextBox";
            this.TunerInfoProgramNumberTextBox.ReadOnly = true;
            this.TunerInfoProgramNumberTextBox.Size = new System.Drawing.Size(75, 21);
            this.TunerInfoProgramNumberTextBox.TabIndex = 7;
            this.TunerInfoProgramNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TunerInfoProgramNumberLabel
            // 
            this.TunerInfoProgramNumberLabel.AutoSize = true;
            this.TunerInfoProgramNumberLabel.Location = new System.Drawing.Point(289, 23);
            this.TunerInfoProgramNumberLabel.Name = "TunerInfoProgramNumberLabel";
            this.TunerInfoProgramNumberLabel.Size = new System.Drawing.Size(103, 15);
            this.TunerInfoProgramNumberLabel.TabIndex = 6;
            this.TunerInfoProgramNumberLabel.Text = "Program Number";
            // 
            // TunerInfoPCRTextBox
            // 
            this.TunerInfoPCRTextBox.Enabled = false;
            this.TunerInfoPCRTextBox.Location = new System.Drawing.Point(98, 103);
            this.TunerInfoPCRTextBox.Name = "TunerInfoPCRTextBox";
            this.TunerInfoPCRTextBox.ReadOnly = true;
            this.TunerInfoPCRTextBox.Size = new System.Drawing.Size(169, 21);
            this.TunerInfoPCRTextBox.TabIndex = 5;
            this.TunerInfoPCRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TunerInfoPCRLabel
            // 
            this.TunerInfoPCRLabel.AutoSize = true;
            this.TunerInfoPCRLabel.Location = new System.Drawing.Point(31, 106);
            this.TunerInfoPCRLabel.Name = "TunerInfoPCRLabel";
            this.TunerInfoPCRLabel.Size = new System.Drawing.Size(58, 15);
            this.TunerInfoPCRLabel.TabIndex = 4;
            this.TunerInfoPCRLabel.Text = "PCRLock";
            // 
            // TunerInfoFrequencyTextBox
            // 
            this.TunerInfoFrequencyTextBox.Enabled = false;
            this.TunerInfoFrequencyTextBox.Location = new System.Drawing.Point(98, 63);
            this.TunerInfoFrequencyTextBox.Name = "TunerInfoFrequencyTextBox";
            this.TunerInfoFrequencyTextBox.ReadOnly = true;
            this.TunerInfoFrequencyTextBox.Size = new System.Drawing.Size(169, 21);
            this.TunerInfoFrequencyTextBox.TabIndex = 3;
            this.TunerInfoFrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TunerInfoFrequencyLabel
            // 
            this.TunerInfoFrequencyLabel.AutoSize = true;
            this.TunerInfoFrequencyLabel.Location = new System.Drawing.Point(25, 66);
            this.TunerInfoFrequencyLabel.Name = "TunerInfoFrequencyLabel";
            this.TunerInfoFrequencyLabel.Size = new System.Drawing.Size(64, 15);
            this.TunerInfoFrequencyLabel.TabIndex = 2;
            this.TunerInfoFrequencyLabel.Text = "Frequency";
            // 
            // TunerInfoChannelTextBox
            // 
            this.TunerInfoChannelTextBox.Enabled = false;
            this.TunerInfoChannelTextBox.Location = new System.Drawing.Point(98, 23);
            this.TunerInfoChannelTextBox.Name = "TunerInfoChannelTextBox";
            this.TunerInfoChannelTextBox.ReadOnly = true;
            this.TunerInfoChannelTextBox.Size = new System.Drawing.Size(169, 21);
            this.TunerInfoChannelTextBox.TabIndex = 1;
            this.TunerInfoChannelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TunerInfoChannelLabel
            // 
            this.TunerInfoChannelLabel.AutoSize = true;
            this.TunerInfoChannelLabel.Location = new System.Drawing.Point(36, 26);
            this.TunerInfoChannelLabel.Name = "TunerInfoChannelLabel";
            this.TunerInfoChannelLabel.Size = new System.Drawing.Size(53, 15);
            this.TunerInfoChannelLabel.TabIndex = 0;
            this.TunerInfoChannelLabel.Text = "Channel";
            // 
            // StreamingRateLabel
            // 
            this.StreamingRateLabel.AutoSize = true;
            this.StreamingRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamingRateLabel.Location = new System.Drawing.Point(51, 314);
            this.StreamingRateLabel.Name = "StreamingRateLabel";
            this.StreamingRateLabel.Size = new System.Drawing.Size(135, 15);
            this.StreamingRateLabel.TabIndex = 7;
            this.StreamingRateLabel.Text = "Streaming Rate (Mbps)";
            // 
            // SymbolQualityLabel
            // 
            this.SymbolQualityLabel.AutoSize = true;
            this.SymbolQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolQualityLabel.Location = new System.Drawing.Point(497, 146);
            this.SymbolQualityLabel.Name = "SymbolQualityLabel";
            this.SymbolQualityLabel.Size = new System.Drawing.Size(110, 15);
            this.SymbolQualityLabel.TabIndex = 6;
            this.SymbolQualityLabel.Text = "Symbol Quality (%)";
            // 
            // SignalQualityLabel
            // 
            this.SignalQualityLabel.AutoSize = true;
            this.SignalQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignalQualityLabel.Location = new System.Drawing.Point(283, 146);
            this.SignalQualityLabel.Name = "SignalQualityLabel";
            this.SignalQualityLabel.Size = new System.Drawing.Size(104, 15);
            this.SignalQualityLabel.TabIndex = 5;
            this.SignalQualityLabel.Text = "Signal Quality (%)";
            // 
            // SignalStrengthLabel
            // 
            this.SignalStrengthLabel.AutoSize = true;
            this.SignalStrengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignalStrengthLabel.Location = new System.Drawing.Point(60, 146);
            this.SignalStrengthLabel.Name = "SignalStrengthLabel";
            this.SignalStrengthLabel.Size = new System.Drawing.Size(113, 15);
            this.SignalStrengthLabel.TabIndex = 4;
            this.SignalStrengthLabel.Text = "Signal Strength (%)";
            // 
            // TabBrowserPage
            // 
            this.TabBrowserPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TabBrowserPage.Controls.Add(this.WebBrowser);
            this.TabBrowserPage.Controls.Add(this.BrowserControlPanel);
            this.TabBrowserPage.Location = new System.Drawing.Point(4, 25);
            this.TabBrowserPage.Name = "TabBrowserPage";
            this.TabBrowserPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabBrowserPage.Size = new System.Drawing.Size(670, 358);
            this.TabBrowserPage.TabIndex = 1;
            this.TabBrowserPage.Text = "Browser";
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(1, 28);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.ScriptErrorsSuppressed = true;
            this.WebBrowser.Size = new System.Drawing.Size(668, 327);
            this.WebBrowser.TabIndex = 2;
            this.WebBrowser.Url = new System.Uri("http://my.hdhomerun.com", System.UriKind.Absolute);
            // 
            // BrowserControlPanel
            // 
            this.BrowserControlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrowserControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrowserControlPanel.Controls.Add(this.BrowserOpenButton);
            this.BrowserControlPanel.Controls.Add(this.BrowserForwardButton);
            this.BrowserControlPanel.Controls.Add(this.BrowserBackButton);
            this.BrowserControlPanel.Controls.Add(this.BrowserHomeButton);
            this.BrowserControlPanel.Location = new System.Drawing.Point(1, 0);
            this.BrowserControlPanel.Name = "BrowserControlPanel";
            this.BrowserControlPanel.Size = new System.Drawing.Size(669, 28);
            this.BrowserControlPanel.TabIndex = 1;
            // 
            // BrowserOpenButton
            // 
            this.BrowserOpenButton.BackColor = System.Drawing.SystemColors.Control;
            this.BrowserOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserOpenButton.Location = new System.Drawing.Point(536, -1);
            this.BrowserOpenButton.Name = "BrowserOpenButton";
            this.BrowserOpenButton.Size = new System.Drawing.Size(131, 29);
            this.BrowserOpenButton.TabIndex = 3;
            this.BrowserOpenButton.Text = "Open In Browser";
            this.BrowserOpenButton.UseVisualStyleBackColor = false;
            this.BrowserOpenButton.Click += new System.EventHandler(this.BrowserOpenButton_Click);
            // 
            // BrowserForwardButton
            // 
            this.BrowserForwardButton.BackColor = System.Drawing.SystemColors.Control;
            this.BrowserForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserForwardButton.Location = new System.Drawing.Point(152, -2);
            this.BrowserForwardButton.Name = "BrowserForwardButton";
            this.BrowserForwardButton.Size = new System.Drawing.Size(78, 29);
            this.BrowserForwardButton.TabIndex = 2;
            this.BrowserForwardButton.Text = "Forward";
            this.BrowserForwardButton.UseVisualStyleBackColor = false;
            this.BrowserForwardButton.Click += new System.EventHandler(this.BrowserForwardButton_Click);
            // 
            // BrowserBackButton
            // 
            this.BrowserBackButton.BackColor = System.Drawing.SystemColors.Control;
            this.BrowserBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserBackButton.Location = new System.Drawing.Point(75, -2);
            this.BrowserBackButton.Name = "BrowserBackButton";
            this.BrowserBackButton.Size = new System.Drawing.Size(78, 29);
            this.BrowserBackButton.TabIndex = 1;
            this.BrowserBackButton.Text = "Back";
            this.BrowserBackButton.UseVisualStyleBackColor = false;
            this.BrowserBackButton.Click += new System.EventHandler(this.BrowserBackButton_Click);
            // 
            // BrowserHomeButton
            // 
            this.BrowserHomeButton.BackColor = System.Drawing.SystemColors.Control;
            this.BrowserHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserHomeButton.Location = new System.Drawing.Point(-1, -2);
            this.BrowserHomeButton.Name = "BrowserHomeButton";
            this.BrowserHomeButton.Size = new System.Drawing.Size(78, 29);
            this.BrowserHomeButton.TabIndex = 0;
            this.BrowserHomeButton.Text = "Home";
            this.BrowserHomeButton.UseVisualStyleBackColor = false;
            this.BrowserHomeButton.Click += new System.EventHandler(this.BrowserHomeButton_Click);
            // 
            // TabStreamPage
            // 
            this.TabStreamPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TabStreamPage.Controls.Add(this.OpenStreamButton);
            this.TabStreamPage.Controls.Add(this.StreamTimeTextBox);
            this.TabStreamPage.Controls.Add(this.StreamStatusTextBox);
            this.TabStreamPage.Controls.Add(this.StreamPlayer);
            this.TabStreamPage.Location = new System.Drawing.Point(4, 25);
            this.TabStreamPage.Name = "TabStreamPage";
            this.TabStreamPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabStreamPage.Size = new System.Drawing.Size(670, 358);
            this.TabStreamPage.TabIndex = 2;
            this.TabStreamPage.Text = "Stream";
            // 
            // OpenStreamButton
            // 
            this.OpenStreamButton.BackColor = System.Drawing.SystemColors.Control;
            this.OpenStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenStreamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenStreamButton.Location = new System.Drawing.Point(18, 315);
            this.OpenStreamButton.Name = "OpenStreamButton";
            this.OpenStreamButton.Size = new System.Drawing.Size(81, 23);
            this.OpenStreamButton.TabIndex = 1;
            this.OpenStreamButton.Text = "Open Stream";
            this.OpenStreamButton.UseVisualStyleBackColor = false;
            this.OpenStreamButton.Click += new System.EventHandler(this.OpenStreamButton_Click);
            // 
            // StreamTimeTextBox
            // 
            this.StreamTimeTextBox.Location = new System.Drawing.Point(496, 315);
            this.StreamTimeTextBox.Name = "StreamTimeTextBox";
            this.StreamTimeTextBox.ReadOnly = true;
            this.StreamTimeTextBox.Size = new System.Drawing.Size(159, 23);
            this.StreamTimeTextBox.TabIndex = 4;
            this.StreamTimeTextBox.Text = "00:00:00";
            this.StreamTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StreamStatusTextBox
            // 
            this.StreamStatusTextBox.Location = new System.Drawing.Point(98, 315);
            this.StreamStatusTextBox.Name = "StreamStatusTextBox";
            this.StreamStatusTextBox.ReadOnly = true;
            this.StreamStatusTextBox.Size = new System.Drawing.Size(399, 23);
            this.StreamStatusTextBox.TabIndex = 3;
            this.StreamStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StreamPlayer
            // 
            this.StreamPlayer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StreamPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StreamPlayer.Location = new System.Drawing.Point(18, 23);
            this.StreamPlayer.Margin = new System.Windows.Forms.Padding(5);
            this.StreamPlayer.Name = "StreamPlayer";
            this.StreamPlayer.Size = new System.Drawing.Size(637, 293);
            this.StreamPlayer.TabIndex = 0;
            // 
            // TabChannelsPage
            // 
            this.TabChannelsPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TabChannelsPage.Controls.Add(this.ChannelsDataGrid);
            this.TabChannelsPage.Controls.Add(this.ChannelsMenuPanel);
            this.TabChannelsPage.Location = new System.Drawing.Point(4, 25);
            this.TabChannelsPage.Name = "TabChannelsPage";
            this.TabChannelsPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabChannelsPage.Size = new System.Drawing.Size(670, 358);
            this.TabChannelsPage.TabIndex = 3;
            this.TabChannelsPage.Text = "Channels";
            // 
            // ChannelsDataGrid
            // 
            this.ChannelsDataGrid.AllowUserToAddRows = false;
            this.ChannelsDataGrid.AllowUserToDeleteRows = false;
            this.ChannelsDataGrid.AllowUserToResizeColumns = false;
            this.ChannelsDataGrid.AllowUserToResizeRows = false;
            this.ChannelsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChannelsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ChannelName,
            this.HD,
            this.DRM,
            this.AudioCodec,
            this.VideoCodec,
            this.StreamURL});
            this.ChannelsDataGrid.Location = new System.Drawing.Point(2, 28);
            this.ChannelsDataGrid.MultiSelect = false;
            this.ChannelsDataGrid.Name = "ChannelsDataGrid";
            this.ChannelsDataGrid.ReadOnly = true;
            this.ChannelsDataGrid.RowHeadersVisible = false;
            this.ChannelsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ChannelsDataGrid.ShowCellErrors = false;
            this.ChannelsDataGrid.ShowEditingIcon = false;
            this.ChannelsDataGrid.Size = new System.Drawing.Size(665, 330);
            this.ChannelsDataGrid.TabIndex = 3;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChannelName
            // 
            this.ChannelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChannelName.HeaderText = "Name";
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.ReadOnly = true;
            this.ChannelName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HD
            // 
            this.HD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HD.HeaderText = "HD";
            this.HD.Name = "HD";
            this.HD.ReadOnly = true;
            this.HD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DRM
            // 
            this.DRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DRM.HeaderText = "DRM";
            this.DRM.Name = "DRM";
            this.DRM.ReadOnly = true;
            this.DRM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AudioCodec
            // 
            this.AudioCodec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AudioCodec.HeaderText = "AudioCodec";
            this.AudioCodec.Name = "AudioCodec";
            this.AudioCodec.ReadOnly = true;
            this.AudioCodec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VideoCodec
            // 
            this.VideoCodec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VideoCodec.HeaderText = "VideoCodec";
            this.VideoCodec.Name = "VideoCodec";
            this.VideoCodec.ReadOnly = true;
            this.VideoCodec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StreamURL
            // 
            this.StreamURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamURL.HeaderText = "Stream URL";
            this.StreamURL.Name = "StreamURL";
            this.StreamURL.ReadOnly = true;
            this.StreamURL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChannelsMenuPanel
            // 
            this.ChannelsMenuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChannelsMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelsMenuPanel.Controls.Add(this.ChannelsSearchLabel);
            this.ChannelsMenuPanel.Controls.Add(this.ChannelsSearchTextBox);
            this.ChannelsMenuPanel.Controls.Add(this.ChannelsRefreshButton);
            this.ChannelsMenuPanel.Location = new System.Drawing.Point(3, 0);
            this.ChannelsMenuPanel.Name = "ChannelsMenuPanel";
            this.ChannelsMenuPanel.Size = new System.Drawing.Size(664, 29);
            this.ChannelsMenuPanel.TabIndex = 2;
            // 
            // ChannelsSearchLabel
            // 
            this.ChannelsSearchLabel.AutoSize = true;
            this.ChannelsSearchLabel.Location = new System.Drawing.Point(364, 4);
            this.ChannelsSearchLabel.Name = "ChannelsSearchLabel";
            this.ChannelsSearchLabel.Size = new System.Drawing.Size(53, 17);
            this.ChannelsSearchLabel.TabIndex = 2;
            this.ChannelsSearchLabel.Text = "Search";
            // 
            // ChannelsSearchTextBox
            // 
            this.ChannelsSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelsSearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ChannelsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelsSearchTextBox.Location = new System.Drawing.Point(420, 2);
            this.ChannelsSearchTextBox.Name = "ChannelsSearchTextBox";
            this.ChannelsSearchTextBox.Size = new System.Drawing.Size(243, 23);
            this.ChannelsSearchTextBox.TabIndex = 1;
            this.ChannelsSearchTextBox.TextChanged += new System.EventHandler(this.ChannelsSearchTextBox_TextChanged);
            // 
            // ChannelsRefreshButton
            // 
            this.ChannelsRefreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.ChannelsRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChannelsRefreshButton.Location = new System.Drawing.Point(-1, -2);
            this.ChannelsRefreshButton.Name = "ChannelsRefreshButton";
            this.ChannelsRefreshButton.Size = new System.Drawing.Size(96, 30);
            this.ChannelsRefreshButton.TabIndex = 0;
            this.ChannelsRefreshButton.Text = "Refresh";
            this.ChannelsRefreshButton.UseVisualStyleBackColor = false;
            this.ChannelsRefreshButton.Click += new System.EventHandler(this.ChannelsRefreshButton_Click);
            // 
            // TabGraphingPage
            // 
            this.TabGraphingPage.Controls.Add(this.GraphingPanel);
            this.TabGraphingPage.Controls.Add(this.GraphingStreamingGraph);
            this.TabGraphingPage.Controls.Add(this.GraphingSignalGraph);
            this.TabGraphingPage.Location = new System.Drawing.Point(4, 25);
            this.TabGraphingPage.Name = "TabGraphingPage";
            this.TabGraphingPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabGraphingPage.Size = new System.Drawing.Size(670, 358);
            this.TabGraphingPage.TabIndex = 4;
            this.TabGraphingPage.Text = "Graphing";
            this.TabGraphingPage.UseVisualStyleBackColor = true;
            // 
            // GraphingPanel
            // 
            this.GraphingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.GraphingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphingPanel.Controls.Add(this.GraphingAdvancedButton);
            this.GraphingPanel.Location = new System.Drawing.Point(3, 0);
            this.GraphingPanel.Name = "GraphingPanel";
            this.GraphingPanel.Size = new System.Drawing.Size(667, 27);
            this.GraphingPanel.TabIndex = 2;
            // 
            // GraphingAdvancedButton
            // 
            this.GraphingAdvancedButton.BackColor = System.Drawing.SystemColors.Control;
            this.GraphingAdvancedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphingAdvancedButton.Location = new System.Drawing.Point(568, -1);
            this.GraphingAdvancedButton.Name = "GraphingAdvancedButton";
            this.GraphingAdvancedButton.Size = new System.Drawing.Size(97, 27);
            this.GraphingAdvancedButton.TabIndex = 3;
            this.GraphingAdvancedButton.Text = "Advanced";
            this.GraphingAdvancedButton.UseVisualStyleBackColor = false;
            this.GraphingAdvancedButton.Click += new System.EventHandler(this.GraphingAdvancedButton_Click);
            // 
            // GraphingStreamingGraph
            // 
            this.GraphingStreamingGraph.Location = new System.Drawing.Point(6, 250);
            this.GraphingStreamingGraph.Name = "GraphingStreamingGraph";
            this.GraphingStreamingGraph.Size = new System.Drawing.Size(658, 101);
            this.GraphingStreamingGraph.TabIndex = 1;
            this.GraphingStreamingGraph.Text = "Streaming Rate";
            // 
            // GraphingSignalGraph
            // 
            this.GraphingSignalGraph.Location = new System.Drawing.Point(6, 30);
            this.GraphingSignalGraph.Name = "GraphingSignalGraph";
            this.GraphingSignalGraph.Size = new System.Drawing.Size(658, 214);
            this.GraphingSignalGraph.TabIndex = 0;
            this.GraphingSignalGraph.Text = "Signal";
            // 
            // TabDevicePage
            // 
            this.TabDevicePage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TabDevicePage.Controls.Add(this.DeviceInfoGBPanel);
            this.TabDevicePage.Location = new System.Drawing.Point(4, 25);
            this.TabDevicePage.Name = "TabDevicePage";
            this.TabDevicePage.Padding = new System.Windows.Forms.Padding(3);
            this.TabDevicePage.Size = new System.Drawing.Size(670, 358);
            this.TabDevicePage.TabIndex = 5;
            this.TabDevicePage.Text = "Device Info";
            // 
            // DeviceInfoGBPanel
            // 
            this.DeviceInfoGBPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DeviceInfoGBPanel.Controls.Add(this.DeviceLogsButton);
            this.DeviceInfoGBPanel.Controls.Add(this.groupBox1);
            this.DeviceInfoGBPanel.Controls.Add(this.DeviceControlGroupBox);
            this.DeviceInfoGBPanel.Controls.Add(this.DeviceInfoGroupBox);
            this.DeviceInfoGBPanel.Location = new System.Drawing.Point(1, 0);
            this.DeviceInfoGBPanel.Name = "DeviceInfoGBPanel";
            this.DeviceInfoGBPanel.Size = new System.Drawing.Size(669, 355);
            this.DeviceInfoGBPanel.TabIndex = 1;
            // 
            // DeviceLogsButton
            // 
            this.DeviceLogsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeviceLogsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeviceLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceLogsButton.Location = new System.Drawing.Point(463, 28);
            this.DeviceLogsButton.Name = "DeviceLogsButton";
            this.DeviceLogsButton.Size = new System.Drawing.Size(188, 31);
            this.DeviceLogsButton.TabIndex = 7;
            this.DeviceLogsButton.Text = "Logs";
            this.DeviceLogsButton.UseVisualStyleBackColor = false;
            this.DeviceLogsButton.Click += new System.EventHandler(DeviceLogsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeviceValidationTextBox);
            this.groupBox1.Controls.Add(this.DeviceOOBLockTextBox);
            this.groupBox1.Controls.Add(this.DeviceAuthenticationTextBox);
            this.groupBox1.Controls.Add(this.DeviceValidationLabel);
            this.groupBox1.Controls.Add(this.DeviceOOBLockLabel);
            this.groupBox1.Controls.Add(this.DeviceAuthenticationLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card";
            // 
            // DeviceValidationTextBox
            // 
            this.DeviceValidationTextBox.Location = new System.Drawing.Point(166, 82);
            this.DeviceValidationTextBox.Name = "DeviceValidationTextBox";
            this.DeviceValidationTextBox.ReadOnly = true;
            this.DeviceValidationTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceValidationTextBox.TabIndex = 10;
            this.DeviceValidationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceOOBLockTextBox
            // 
            this.DeviceOOBLockTextBox.Location = new System.Drawing.Point(166, 53);
            this.DeviceOOBLockTextBox.Name = "DeviceOOBLockTextBox";
            this.DeviceOOBLockTextBox.ReadOnly = true;
            this.DeviceOOBLockTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceOOBLockTextBox.TabIndex = 9;
            this.DeviceOOBLockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceAuthenticationTextBox
            // 
            this.DeviceAuthenticationTextBox.Location = new System.Drawing.Point(166, 23);
            this.DeviceAuthenticationTextBox.Name = "DeviceAuthenticationTextBox";
            this.DeviceAuthenticationTextBox.ReadOnly = true;
            this.DeviceAuthenticationTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceAuthenticationTextBox.TabIndex = 8;
            this.DeviceAuthenticationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceValidationLabel
            // 
            this.DeviceValidationLabel.AutoSize = true;
            this.DeviceValidationLabel.Location = new System.Drawing.Point(80, 85);
            this.DeviceValidationLabel.Name = "DeviceValidationLabel";
            this.DeviceValidationLabel.Size = new System.Drawing.Size(74, 17);
            this.DeviceValidationLabel.TabIndex = 2;
            this.DeviceValidationLabel.Text = "Validation:";
            // 
            // DeviceOOBLockLabel
            // 
            this.DeviceOOBLockLabel.AutoSize = true;
            this.DeviceOOBLockLabel.Location = new System.Drawing.Point(77, 56);
            this.DeviceOOBLockLabel.Name = "DeviceOOBLockLabel";
            this.DeviceOOBLockLabel.Size = new System.Drawing.Size(77, 17);
            this.DeviceOOBLockLabel.TabIndex = 1;
            this.DeviceOOBLockLabel.Text = "OOB Lock:";
            // 
            // DeviceAuthenticationLabel
            // 
            this.DeviceAuthenticationLabel.AutoSize = true;
            this.DeviceAuthenticationLabel.Location = new System.Drawing.Point(52, 26);
            this.DeviceAuthenticationLabel.Name = "DeviceAuthenticationLabel";
            this.DeviceAuthenticationLabel.Size = new System.Drawing.Size(102, 17);
            this.DeviceAuthenticationLabel.TabIndex = 0;
            this.DeviceAuthenticationLabel.Text = "Authentication:";
            // 
            // DeviceControlGroupBox
            // 
            this.DeviceControlGroupBox.Controls.Add(this.CardPairingButton);
            this.DeviceControlGroupBox.Controls.Add(this.CardPairingLabel);
            this.DeviceControlGroupBox.Controls.Add(this.RestartDeviceButton2);
            this.DeviceControlGroupBox.Controls.Add(this.RestartDeviceLabel);
            this.DeviceControlGroupBox.Controls.Add(this.FirmwareUpdateButton);
            this.DeviceControlGroupBox.Controls.Add(this.FirmwareUpdateLabel);
            this.DeviceControlGroupBox.Location = new System.Drawing.Point(463, 76);
            this.DeviceControlGroupBox.Name = "DeviceControlGroupBox";
            this.DeviceControlGroupBox.Size = new System.Drawing.Size(188, 268);
            this.DeviceControlGroupBox.TabIndex = 5;
            this.DeviceControlGroupBox.TabStop = false;
            this.DeviceControlGroupBox.Text = "Control";
            // 
            // CardPairingButton
            // 
            this.CardPairingButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CardPairingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardPairingButton.Location = new System.Drawing.Point(33, 144);
            this.CardPairingButton.Name = "CardPairingButton";
            this.CardPairingButton.Size = new System.Drawing.Size(131, 29);
            this.CardPairingButton.TabIndex = 5;
            this.CardPairingButton.Text = "View";
            this.CardPairingButton.UseVisualStyleBackColor = false;
            this.CardPairingButton.Click += new System.EventHandler(CardPairingButton_Click);
            // 
            // CardPairingLabel
            // 
            this.CardPairingLabel.AutoSize = true;
            this.CardPairingLabel.Location = new System.Drawing.Point(40, 118);
            this.CardPairingLabel.Name = "CardPairingLabel";
            this.CardPairingLabel.Size = new System.Drawing.Size(113, 17);
            this.CardPairingLabel.TabIndex = 4;
            this.CardPairingLabel.Text = "Card Pairing Info";
            // 
            // RestartDeviceButton2
            // 
            this.RestartDeviceButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RestartDeviceButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartDeviceButton2.Location = new System.Drawing.Point(33, 221);
            this.RestartDeviceButton2.Name = "RestartDeviceButton2";
            this.RestartDeviceButton2.Size = new System.Drawing.Size(131, 29);
            this.RestartDeviceButton2.TabIndex = 3;
            this.RestartDeviceButton2.Text = "Restart";
            this.RestartDeviceButton2.UseVisualStyleBackColor = false;
            this.RestartDeviceButton2.Click += new System.EventHandler(RestartDeviceButton2_Click);
            // 
            // RestartDeviceLabel
            // 
            this.RestartDeviceLabel.AutoSize = true;
            this.RestartDeviceLabel.Location = new System.Drawing.Point(49, 197);
            this.RestartDeviceLabel.Name = "RestartDeviceLabel";
            this.RestartDeviceLabel.Size = new System.Drawing.Size(101, 17);
            this.RestartDeviceLabel.TabIndex = 2;
            this.RestartDeviceLabel.Text = "Restart Device";
            // 
            // FirmwareUpdateButton
            // 
            this.FirmwareUpdateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirmwareUpdateButton.Enabled = false;
            this.FirmwareUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirmwareUpdateButton.Location = new System.Drawing.Point(33, 66);
            this.FirmwareUpdateButton.Name = "FirmwareUpdateButton";
            this.FirmwareUpdateButton.Size = new System.Drawing.Size(131, 29);
            this.FirmwareUpdateButton.TabIndex = 1;
            this.FirmwareUpdateButton.Text = "Unavailable";
            this.FirmwareUpdateButton.UseVisualStyleBackColor = false;
            this.FirmwareUpdateButton.Click += new System.EventHandler(FirmwareUpdateButton_Click);
            // 
            // FirmwareUpdateLabel
            // 
            this.FirmwareUpdateLabel.AutoSize = true;
            this.FirmwareUpdateLabel.Location = new System.Drawing.Point(40, 40);
            this.FirmwareUpdateLabel.Name = "FirmwareUpdateLabel";
            this.FirmwareUpdateLabel.Size = new System.Drawing.Size(115, 17);
            this.FirmwareUpdateLabel.TabIndex = 0;
            this.FirmwareUpdateLabel.Text = "Firmware Update";
            // 
            // DeviceInfoGroupBox
            // 
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceMACLabel);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceMACTextBox);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceMemoryTextBox);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceMemoryLabel);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceIPTextBox);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceFirmwareTextBox);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceModelTextBox);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceIPLabel);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceFirmwareLabel);
            this.DeviceInfoGroupBox.Controls.Add(this.DeviceModelLabel);
            this.DeviceInfoGroupBox.Location = new System.Drawing.Point(17, 14);
            this.DeviceInfoGroupBox.Name = "DeviceInfoGroupBox";
            this.DeviceInfoGroupBox.Size = new System.Drawing.Size(427, 207);
            this.DeviceInfoGroupBox.TabIndex = 4;
            this.DeviceInfoGroupBox.TabStop = false;
            this.DeviceInfoGroupBox.Text = "Info";
            // 
            // DeviceMACLabel
            // 
            this.DeviceMACLabel.AutoSize = true;
            this.DeviceMACLabel.Location = new System.Drawing.Point(113, 164);
            this.DeviceMACLabel.Name = "DeviceMACLabel";
            this.DeviceMACLabel.Size = new System.Drawing.Size(41, 17);
            this.DeviceMACLabel.TabIndex = 11;
            this.DeviceMACLabel.Text = "MAC:";
            // 
            // DeviceMACTextBox
            // 
            this.DeviceMACTextBox.Location = new System.Drawing.Point(166, 161);
            this.DeviceMACTextBox.Name = "DeviceMACTextBox";
            this.DeviceMACTextBox.ReadOnly = true;
            this.DeviceMACTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceMACTextBox.TabIndex = 10;
            this.DeviceMACTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceMemoryTextBox
            // 
            this.DeviceMemoryTextBox.Location = new System.Drawing.Point(166, 127);
            this.DeviceMemoryTextBox.Name = "DeviceMemoryTextBox";
            this.DeviceMemoryTextBox.ReadOnly = true;
            this.DeviceMemoryTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceMemoryTextBox.TabIndex = 9;
            this.DeviceMemoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceMemoryLabel
            // 
            this.DeviceMemoryLabel.AutoSize = true;
            this.DeviceMemoryLabel.Location = new System.Drawing.Point(45, 130);
            this.DeviceMemoryLabel.Name = "DeviceMemoryLabel";
            this.DeviceMemoryLabel.Size = new System.Drawing.Size(109, 17);
            this.DeviceMemoryLabel.TabIndex = 8;
            this.DeviceMemoryLabel.Text = "Memory Report:";
            // 
            // DeviceIPTextBox
            // 
            this.DeviceIPTextBox.Location = new System.Drawing.Point(166, 94);
            this.DeviceIPTextBox.Name = "DeviceIPTextBox";
            this.DeviceIPTextBox.ReadOnly = true;
            this.DeviceIPTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceIPTextBox.TabIndex = 7;
            this.DeviceIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceFirmwareTextBox
            // 
            this.DeviceFirmwareTextBox.Location = new System.Drawing.Point(166, 62);
            this.DeviceFirmwareTextBox.Name = "DeviceFirmwareTextBox";
            this.DeviceFirmwareTextBox.ReadOnly = true;
            this.DeviceFirmwareTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceFirmwareTextBox.TabIndex = 6;
            this.DeviceFirmwareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceModelTextBox
            // 
            this.DeviceModelTextBox.Location = new System.Drawing.Point(166, 31);
            this.DeviceModelTextBox.Name = "DeviceModelTextBox";
            this.DeviceModelTextBox.ReadOnly = true;
            this.DeviceModelTextBox.Size = new System.Drawing.Size(240, 23);
            this.DeviceModelTextBox.TabIndex = 5;
            this.DeviceModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceIPLabel
            // 
            this.DeviceIPLabel.AutoSize = true;
            this.DeviceIPLabel.Location = new System.Drawing.Point(74, 96);
            this.DeviceIPLabel.Name = "DeviceIPLabel";
            this.DeviceIPLabel.Size = new System.Drawing.Size(80, 17);
            this.DeviceIPLabel.TabIndex = 3;
            this.DeviceIPLabel.Text = "IP Address:";
            // 
            // DeviceFirmwareLabel
            // 
            this.DeviceFirmwareLabel.AutoSize = true;
            this.DeviceFirmwareLabel.Location = new System.Drawing.Point(85, 65);
            this.DeviceFirmwareLabel.Name = "DeviceFirmwareLabel";
            this.DeviceFirmwareLabel.Size = new System.Drawing.Size(69, 17);
            this.DeviceFirmwareLabel.TabIndex = 2;
            this.DeviceFirmwareLabel.Text = "Firmware:";
            // 
            // DeviceModelLabel
            // 
            this.DeviceModelLabel.AutoSize = true;
            this.DeviceModelLabel.Location = new System.Drawing.Point(104, 34);
            this.DeviceModelLabel.Name = "DeviceModelLabel";
            this.DeviceModelLabel.Size = new System.Drawing.Size(50, 17);
            this.DeviceModelLabel.TabIndex = 1;
            this.DeviceModelLabel.Text = "Model:";
            // 
            // TabSettingsPage
            // 
            this.TabSettingsPage.BackColor = System.Drawing.SystemColors.Control;
            this.TabSettingsPage.Controls.Add(this.RemoteDiscoveryGroupBox);
            this.TabSettingsPage.Controls.Add(this.GraphingControlGroupBox);
            this.TabSettingsPage.Controls.Add(this.LocalDiscoveryGroupBox);
            this.TabSettingsPage.Controls.Add(this.TunerViewerLabel);
            this.TabSettingsPage.Controls.Add(this.SettingsDataGroupBox);
            this.TabSettingsPage.Location = new System.Drawing.Point(4, 25);
            this.TabSettingsPage.Name = "TabSettingsPage";
            this.TabSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabSettingsPage.Size = new System.Drawing.Size(670, 358);
            this.TabSettingsPage.TabIndex = 6;
            this.TabSettingsPage.Text = "Settings";
            // 
            // GraphingControlGroupBox
            // 
            this.GraphingControlGroupBox.Controls.Add(this.MaxStoredValuesLabel);
            this.GraphingControlGroupBox.Controls.Add(this.MaxStoredValues);
            this.GraphingControlGroupBox.Controls.Add(this.GraphingEnabledLabel);
            this.GraphingControlGroupBox.Controls.Add(this.GraphingEnabledButton);
            this.GraphingControlGroupBox.Location = new System.Drawing.Point(16, 190);
            this.GraphingControlGroupBox.Name = "GraphingControlGroupBox";
            this.GraphingControlGroupBox.Size = new System.Drawing.Size(300, 153);
            this.GraphingControlGroupBox.TabIndex = 5;
            this.GraphingControlGroupBox.TabStop = false;
            this.GraphingControlGroupBox.Text = "Graphing Control";
            // 
            // MaxStoredValuesLabel
            // 
            this.MaxStoredValuesLabel.AutoSize = true;
            this.MaxStoredValuesLabel.Location = new System.Drawing.Point(20, 100);
            this.MaxStoredValuesLabel.Name = "MaxStoredValuesLabel";
            this.MaxStoredValuesLabel.Size = new System.Drawing.Size(130, 17);
            this.MaxStoredValuesLabel.TabIndex = 2;
            this.MaxStoredValuesLabel.Text = "Max Stored Values:";
            // 
            // MaxStoredValues
            // 
            this.MaxStoredValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxStoredValues.Location = new System.Drawing.Point(190, 98);
            this.MaxStoredValues.Maximum = new decimal(new int[] {
            172800,
            0,
            0,
            0});
            this.MaxStoredValues.Minimum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.MaxStoredValues.Name = "MaxStoredValues";
            this.MaxStoredValues.Size = new System.Drawing.Size(91, 23);
            this.MaxStoredValues.TabIndex = 2;
            this.MaxStoredValues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxStoredValues.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.MaxStoredValues.ValueChanged += new System.EventHandler(this.MaxStoredValues_ValueChanged);
            // 
            // GraphingEnabledLabel
            // 
            this.GraphingEnabledLabel.AutoSize = true;
            this.GraphingEnabledLabel.Location = new System.Drawing.Point(20, 51);
            this.GraphingEnabledLabel.Name = "GraphingEnabledLabel";
            this.GraphingEnabledLabel.Size = new System.Drawing.Size(71, 17);
            this.GraphingEnabledLabel.TabIndex = 4;
            this.GraphingEnabledLabel.Text = "Graphing:";
            // 
            // GraphingEnabledButton
            // 
            this.GraphingEnabledButton.BackColor = System.Drawing.Color.LightGreen;
            this.GraphingEnabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphingEnabledButton.Location = new System.Drawing.Point(172, 45);
            this.GraphingEnabledButton.Name = "GraphingEnabledButton";
            this.GraphingEnabledButton.Size = new System.Drawing.Size(109, 28);
            this.GraphingEnabledButton.TabIndex = 3;
            this.GraphingEnabledButton.Text = "Enabled";
            this.GraphingEnabledButton.UseVisualStyleBackColor = false;
            this.GraphingEnabledButton.Click += new System.EventHandler(this.GraphingEnabledButton_Click);
            // 
            // LocalDiscoveryGroupBox
            // 
            this.LocalDiscoveryGroupBox.Controls.Add(this.UDPDiscoveryLabel);
            this.LocalDiscoveryGroupBox.Controls.Add(this.UDPDiscoveryButton);
            this.LocalDiscoveryGroupBox.Location = new System.Drawing.Point(322, 20);
            this.LocalDiscoveryGroupBox.Name = "LocalDiscoveryGroupBox";
            this.LocalDiscoveryGroupBox.Size = new System.Drawing.Size(335, 99);
            this.LocalDiscoveryGroupBox.TabIndex = 4;
            this.LocalDiscoveryGroupBox.TabStop = false;
            this.LocalDiscoveryGroupBox.Text = "Local Discovery";
            // 
            // UDPDiscoveryLabel
            // 
            this.UDPDiscoveryLabel.AutoSize = true;
            this.UDPDiscoveryLabel.Location = new System.Drawing.Point(18, 45);
            this.UDPDiscoveryLabel.Name = "UDPDiscoveryLabel";
            this.UDPDiscoveryLabel.Size = new System.Drawing.Size(192, 17);
            this.UDPDiscoveryLabel.TabIndex = 6;
            this.UDPDiscoveryLabel.Text = "Use UDP Discovery Protocol:";
            // 
            // UDPDiscoveryButton
            // 
            this.UDPDiscoveryButton.BackColor = System.Drawing.Color.LightGreen;
            this.UDPDiscoveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UDPDiscoveryButton.Location = new System.Drawing.Point(212, 39);
            this.UDPDiscoveryButton.Name = "UDPDiscoveryButton";
            this.UDPDiscoveryButton.Size = new System.Drawing.Size(109, 28);
            this.UDPDiscoveryButton.TabIndex = 5;
            this.UDPDiscoveryButton.Text = "Enabled";
            this.UDPDiscoveryToolTip.SetToolTip(this.UDPDiscoveryButton, resources.GetString("UDPDiscoveryButton.ToolTip"));
            this.UDPDiscoveryButton.UseVisualStyleBackColor = false;
            this.UDPDiscoveryButton.Click += new System.EventHandler(this.UDPDiscoveryButton_Click);
            // 
            // TunerViewerLabel
            // 
            this.TunerViewerLabel.AutoSize = true;
            this.TunerViewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TunerViewerLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TunerViewerLabel.Location = new System.Drawing.Point(563, 339);
            this.TunerViewerLabel.Name = "TunerViewerLabel";
            this.TunerViewerLabel.Size = new System.Drawing.Size(106, 13);
            this.TunerViewerLabel.TabIndex = 3;
            this.TunerViewerLabel.Text = "TunerViewer2 - 2021";
            // 
            // SettingsDataGroupBox
            // 
            this.SettingsDataGroupBox.Controls.Add(this.UseHDHRConfigLabel);
            this.SettingsDataGroupBox.Controls.Add(this.SettingsPageRefreshRateValue);
            this.SettingsDataGroupBox.Controls.Add(this.UseHDHRConfigButton);
            this.SettingsDataGroupBox.Controls.Add(this.RefreshRateLabel);
            this.SettingsDataGroupBox.Location = new System.Drawing.Point(16, 20);
            this.SettingsDataGroupBox.Name = "SettingsDataGroupBox";
            this.SettingsDataGroupBox.Size = new System.Drawing.Size(300, 165);
            this.SettingsDataGroupBox.TabIndex = 2;
            this.SettingsDataGroupBox.TabStop = false;
            this.SettingsDataGroupBox.Text = "Data Control";
            // 
            // UseHDHRConfigLabel
            // 
            this.UseHDHRConfigLabel.AutoSize = true;
            this.UseHDHRConfigLabel.Location = new System.Drawing.Point(20, 102);
            this.UseHDHRConfigLabel.Name = "UseHDHRConfigLabel";
            this.UseHDHRConfigLabel.Size = new System.Drawing.Size(121, 17);
            this.UseHDHRConfigLabel.TabIndex = 6;
            this.UseHDHRConfigLabel.Text = "Use HDHRConfig:";
            // 
            // SettingsPageRefreshRateValue
            // 
            this.SettingsPageRefreshRateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPageRefreshRateValue.DecimalPlaces = 1;
            this.SettingsPageRefreshRateValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SettingsPageRefreshRateValue.Location = new System.Drawing.Point(225, 48);
            this.SettingsPageRefreshRateValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SettingsPageRefreshRateValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SettingsPageRefreshRateValue.Name = "SettingsPageRefreshRateValue";
            this.SettingsPageRefreshRateValue.Size = new System.Drawing.Size(56, 23);
            this.SettingsPageRefreshRateValue.TabIndex = 0;
            this.SettingsPageRefreshRateValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsPageRefreshRateValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.SettingsPageRefreshRateValue.ValueChanged += new System.EventHandler(this.SettingsPageRefreshRateValue_ValueChanged);
            // 
            // UseHDHRConfigButton
            // 
            this.UseHDHRConfigButton.BackColor = System.Drawing.Color.Gray;
            this.UseHDHRConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseHDHRConfigButton.Location = new System.Drawing.Point(172, 96);
            this.UseHDHRConfigButton.Name = "UseHDHRConfigButton";
            this.UseHDHRConfigButton.Size = new System.Drawing.Size(109, 28);
            this.UseHDHRConfigButton.TabIndex = 5;
            this.UseHDHRConfigButton.Text = "Disabled";
            this.UseHDHRConfigToolTip.SetToolTip(this.UseHDHRConfigButton, resources.GetString("UseHDHRConfigButton.ToolTip"));
            this.UseHDHRConfigButton.UseVisualStyleBackColor = false;
            this.UseHDHRConfigButton.Click += new System.EventHandler(this.UseHDHRConfigButton_Click);
            // 
            // RefreshRateLabel
            // 
            this.RefreshRateLabel.AutoSize = true;
            this.RefreshRateLabel.Location = new System.Drawing.Point(20, 50);
            this.RefreshRateLabel.Name = "RefreshRateLabel";
            this.RefreshRateLabel.Size = new System.Drawing.Size(199, 17);
            this.RefreshRateLabel.TabIndex = 1;
            this.RefreshRateLabel.Text = "Data Refresh Rate (Seconds):";
            // 
            // DeviceInfoPanel
            // 
            this.DeviceInfoPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeviceInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceInfoPanel.Controls.Add(this.RefreshStatusLED);
            this.DeviceInfoPanel.Controls.Add(this.HUDStreamingRateValue);
            this.DeviceInfoPanel.Controls.Add(this.HUDSymbolQualityValue);
            this.DeviceInfoPanel.Controls.Add(this.HUDSignalQualityValue);
            this.DeviceInfoPanel.Controls.Add(this.HUDSignalStrengthValue);
            this.DeviceInfoPanel.Controls.Add(this.HUDStreamingRateLabel);
            this.DeviceInfoPanel.Controls.Add(this.HUDSymbolQualityLabel);
            this.DeviceInfoPanel.Controls.Add(this.HUDSignalQualityLabel);
            this.DeviceInfoPanel.Controls.Add(this.HUDSignalStrengthLabel);
            this.DeviceInfoPanel.Controls.Add(this.HUDChannelTextBox);
            this.DeviceInfoPanel.Controls.Add(this.HUDChannelLabel);
            this.DeviceInfoPanel.Controls.Add(this.HUDDeviceTextBox);
            this.DeviceInfoPanel.Controls.Add(this.HUDDeviceLabel);
            this.DeviceInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeviceInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.DeviceInfoPanel.Name = "DeviceInfoPanel";
            this.DeviceInfoPanel.Size = new System.Drawing.Size(667, 61);
            this.DeviceInfoPanel.TabIndex = 1;
            // 
            // RefreshStatusLED
            // 
            this.RefreshStatusLED.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RefreshStatusLED.Enabled = false;
            this.RefreshStatusLED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshStatusLED.Location = new System.Drawing.Point(656, -1);
            this.RefreshStatusLED.Name = "RefreshStatusLED";
            this.RefreshStatusLED.Size = new System.Drawing.Size(10, 61);
            this.RefreshStatusLED.TabIndex = 9;
            this.RefreshStatusLED.UseVisualStyleBackColor = false;
            // 
            // HUDStreamingRateValue
            // 
            this.HUDStreamingRateValue.Location = new System.Drawing.Point(560, 11);
            this.HUDStreamingRateValue.Name = "HUDStreamingRateValue";
            this.HUDStreamingRateValue.ReadOnly = true;
            this.HUDStreamingRateValue.Size = new System.Drawing.Size(76, 20);
            this.HUDStreamingRateValue.TabIndex = 14;
            this.HUDStreamingRateValue.Text = "0Mbps";
            this.HUDStreamingRateValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HUDSymbolQualityValue
            // 
            this.HUDSymbolQualityValue.Location = new System.Drawing.Point(466, 11);
            this.HUDSymbolQualityValue.Name = "HUDSymbolQualityValue";
            this.HUDSymbolQualityValue.ReadOnly = true;
            this.HUDSymbolQualityValue.Size = new System.Drawing.Size(76, 20);
            this.HUDSymbolQualityValue.TabIndex = 13;
            this.HUDSymbolQualityValue.Text = "0%";
            this.HUDSymbolQualityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HUDSignalQualityValue
            // 
            this.HUDSignalQualityValue.Location = new System.Drawing.Point(371, 11);
            this.HUDSignalQualityValue.Name = "HUDSignalQualityValue";
            this.HUDSignalQualityValue.ReadOnly = true;
            this.HUDSignalQualityValue.Size = new System.Drawing.Size(76, 20);
            this.HUDSignalQualityValue.TabIndex = 12;
            this.HUDSignalQualityValue.Text = "0%";
            this.HUDSignalQualityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HUDSignalStrengthValue
            // 
            this.HUDSignalStrengthValue.Location = new System.Drawing.Point(277, 11);
            this.HUDSignalStrengthValue.Name = "HUDSignalStrengthValue";
            this.HUDSignalStrengthValue.ReadOnly = true;
            this.HUDSignalStrengthValue.Size = new System.Drawing.Size(76, 20);
            this.HUDSignalStrengthValue.TabIndex = 11;
            this.HUDSignalStrengthValue.Text = "0%";
            this.HUDSignalStrengthValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HUDStreamingRateLabel
            // 
            this.HUDStreamingRateLabel.AutoSize = true;
            this.HUDStreamingRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDStreamingRateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HUDStreamingRateLabel.Location = new System.Drawing.Point(558, 37);
            this.HUDStreamingRateLabel.Name = "HUDStreamingRateLabel";
            this.HUDStreamingRateLabel.Size = new System.Drawing.Size(80, 13);
            this.HUDStreamingRateLabel.TabIndex = 10;
            this.HUDStreamingRateLabel.Text = "Streaming Rate";
            // 
            // HUDSymbolQualityLabel
            // 
            this.HUDSymbolQualityLabel.AutoSize = true;
            this.HUDSymbolQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDSymbolQualityLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HUDSymbolQualityLabel.Location = new System.Drawing.Point(466, 37);
            this.HUDSymbolQualityLabel.Name = "HUDSymbolQualityLabel";
            this.HUDSymbolQualityLabel.Size = new System.Drawing.Size(76, 13);
            this.HUDSymbolQualityLabel.TabIndex = 9;
            this.HUDSymbolQualityLabel.Text = "Symbol Quality";
            // 
            // HUDSignalQualityLabel
            // 
            this.HUDSignalQualityLabel.AutoSize = true;
            this.HUDSignalQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDSignalQualityLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HUDSignalQualityLabel.Location = new System.Drawing.Point(374, 37);
            this.HUDSignalQualityLabel.Name = "HUDSignalQualityLabel";
            this.HUDSignalQualityLabel.Size = new System.Drawing.Size(71, 13);
            this.HUDSignalQualityLabel.TabIndex = 8;
            this.HUDSignalQualityLabel.Text = "Signal Quality";
            // 
            // HUDSignalStrengthLabel
            // 
            this.HUDSignalStrengthLabel.AutoSize = true;
            this.HUDSignalStrengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDSignalStrengthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HUDSignalStrengthLabel.Location = new System.Drawing.Point(275, 37);
            this.HUDSignalStrengthLabel.Name = "HUDSignalStrengthLabel";
            this.HUDSignalStrengthLabel.Size = new System.Drawing.Size(79, 13);
            this.HUDSignalStrengthLabel.TabIndex = 7;
            this.HUDSignalStrengthLabel.Text = "Signal Strength";
            // 
            // HUDChannelTextBox
            // 
            this.HUDChannelTextBox.Location = new System.Drawing.Point(94, 32);
            this.HUDChannelTextBox.Name = "HUDChannelTextBox";
            this.HUDChannelTextBox.ReadOnly = true;
            this.HUDChannelTextBox.Size = new System.Drawing.Size(157, 20);
            this.HUDChannelTextBox.TabIndex = 6;
            this.HUDChannelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HUDChannelLabel
            // 
            this.HUDChannelLabel.AutoSize = true;
            this.HUDChannelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDChannelLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HUDChannelLabel.Location = new System.Drawing.Point(39, 35);
            this.HUDChannelLabel.Name = "HUDChannelLabel";
            this.HUDChannelLabel.Size = new System.Drawing.Size(49, 13);
            this.HUDChannelLabel.TabIndex = 5;
            this.HUDChannelLabel.Text = "Channel:";
            // 
            // HUDDeviceTextBox
            // 
            this.HUDDeviceTextBox.Location = new System.Drawing.Point(94, 8);
            this.HUDDeviceTextBox.Name = "HUDDeviceTextBox";
            this.HUDDeviceTextBox.ReadOnly = true;
            this.HUDDeviceTextBox.Size = new System.Drawing.Size(157, 20);
            this.HUDDeviceTextBox.TabIndex = 4;
            this.HUDDeviceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HUDDeviceLabel
            // 
            this.HUDDeviceLabel.AutoSize = true;
            this.HUDDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDDeviceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HUDDeviceLabel.Location = new System.Drawing.Point(17, 11);
            this.HUDDeviceLabel.Name = "HUDDeviceLabel";
            this.HUDDeviceLabel.Size = new System.Drawing.Size(71, 13);
            this.HUDDeviceLabel.TabIndex = 2;
            this.HUDDeviceLabel.Text = "Device Type:";
            // 
            // UDPDiscoveryToolTip
            // 
            this.UDPDiscoveryToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.UDPDiscoveryToolTip.ToolTipTitle = "UDP Discovery";
            // 
            // UseHDHRConfigToolTip
            // 
            this.UseHDHRConfigToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.UseHDHRConfigToolTip.ToolTipTitle = "Use HDHRConfig.exe";
            // 
            // RemoteDiscoveryGroupBox
            // 
            this.RemoteDiscoveryGroupBox.Controls.Add(this.HDHRDiscoverLabel);
            this.RemoteDiscoveryGroupBox.Controls.Add(this.HDHRDiscoverButton);
            this.RemoteDiscoveryGroupBox.Location = new System.Drawing.Point(322, 125);
            this.RemoteDiscoveryGroupBox.Name = "RemoteDiscoveryGroupBox";
            this.RemoteDiscoveryGroupBox.Size = new System.Drawing.Size(335, 99);
            this.RemoteDiscoveryGroupBox.TabIndex = 7;
            this.RemoteDiscoveryGroupBox.TabStop = false;
            this.RemoteDiscoveryGroupBox.Text = "Remote Discovery";
            // 
            // HDHRDiscoverLabel
            // 
            this.HDHRDiscoverLabel.AutoSize = true;
            this.HDHRDiscoverLabel.Location = new System.Drawing.Point(18, 45);
            this.HDHRDiscoverLabel.Name = "HDHRDiscoverLabel";
            this.HDHRDiscoverLabel.Size = new System.Drawing.Size(140, 17);
            this.HDHRDiscoverLabel.TabIndex = 6;
            this.HDHRDiscoverLabel.Text = "Use HDHR Discover:";
            // 
            // HDHRDiscoverButton
            // 
            this.HDHRDiscoverButton.BackColor = System.Drawing.Color.LightGreen;
            this.HDHRDiscoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HDHRDiscoverButton.Location = new System.Drawing.Point(212, 39);
            this.HDHRDiscoverButton.Name = "HDHRDiscoverButton";
            this.HDHRDiscoverButton.Size = new System.Drawing.Size(109, 28);
            this.HDHRDiscoverButton.TabIndex = 5;
            this.HDHRDiscoverButton.Text = "Enabled";
            this.UseRemoteHDHRDiscovery.SetToolTip(this.HDHRDiscoverButton, resources.GetString("HDHRDiscoverButton.ToolTip"));
            this.HDHRDiscoverButton.UseVisualStyleBackColor = false;
            this.HDHRDiscoverButton.Click += new System.EventHandler(this.HDHRDiscoverButton_Click);
            // 
            // UseRemoteHDHRDiscovery
            // 
            this.UseRemoteHDHRDiscovery.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.UseRemoteHDHRDiscovery.ToolTipTitle = "Use HDHR Remote Discovery";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 449);
            this.Controls.Add(this.ControllerPanel);
            this.Controls.Add(this.DevicesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "TunerViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.DevicesPanel.ResumeLayout(false);
            this.ControllerPanel.ResumeLayout(false);
            this.MenuButtonsPanel.ResumeLayout(false);
            this.SelectedDeviceControllerPanel.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabTunerInfoPage.ResumeLayout(false);
            this.GaugesPanel.ResumeLayout(false);
            this.GaugesPanel.PerformLayout();
            this.TunerInfoGroupBox.ResumeLayout(false);
            this.TunerInfoGroupBoxPanel.ResumeLayout(false);
            this.TunerInfoGroupBoxPanel.PerformLayout();
            this.TabBrowserPage.ResumeLayout(false);
            this.BrowserControlPanel.ResumeLayout(false);
            this.TabStreamPage.ResumeLayout(false);
            this.TabStreamPage.PerformLayout();
            this.TabChannelsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChannelsDataGrid)).EndInit();
            this.ChannelsMenuPanel.ResumeLayout(false);
            this.ChannelsMenuPanel.PerformLayout();
            this.TabGraphingPage.ResumeLayout(false);
            this.GraphingPanel.ResumeLayout(false);
            this.TabDevicePage.ResumeLayout(false);
            this.DeviceInfoGBPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DeviceControlGroupBox.ResumeLayout(false);
            this.DeviceControlGroupBox.PerformLayout();
            this.DeviceInfoGroupBox.ResumeLayout(false);
            this.DeviceInfoGroupBox.PerformLayout();
            this.TabSettingsPage.ResumeLayout(false);
            this.TabSettingsPage.PerformLayout();
            this.GraphingControlGroupBox.ResumeLayout(false);
            this.GraphingControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStoredValues)).EndInit();
            this.LocalDiscoveryGroupBox.ResumeLayout(false);
            this.LocalDiscoveryGroupBox.PerformLayout();
            this.SettingsDataGroupBox.ResumeLayout(false);
            this.SettingsDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPageRefreshRateValue)).EndInit();
            this.DeviceInfoPanel.ResumeLayout(false);
            this.DeviceInfoPanel.PerformLayout();
            this.RemoteDiscoveryGroupBox.ResumeLayout(false);
            this.RemoteDiscoveryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DevicesPanel;
        private System.Windows.Forms.Panel ControllerPanel;
        private System.Windows.Forms.Button RestartDeviceButton;
        private System.Windows.Forms.Button RefreshDevicesButton;
        private System.Windows.Forms.TreeView DeviceTreeView;
        private System.Windows.Forms.Panel DeviceInfoPanel;
        private System.Windows.Forms.TextBox HUDChannelTextBox;
        private System.Windows.Forms.Label HUDChannelLabel;
        private System.Windows.Forms.TextBox HUDDeviceTextBox;
        private System.Windows.Forms.Label HUDDeviceLabel;
        private System.Windows.Forms.TextBox HUDStreamingRateValue;
        private System.Windows.Forms.TextBox HUDSymbolQualityValue;
        private System.Windows.Forms.TextBox HUDSignalQualityValue;
        private System.Windows.Forms.TextBox HUDSignalStrengthValue;
        private System.Windows.Forms.Label HUDStreamingRateLabel;
        private System.Windows.Forms.Label HUDSymbolQualityLabel;
        private System.Windows.Forms.Label HUDSignalQualityLabel;
        private System.Windows.Forms.Label HUDSignalStrengthLabel;
        private System.Windows.Forms.Button RefreshStatusLED;
        private System.Windows.Forms.Panel SelectedDeviceControllerPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabTunerInfoPage;
        private System.Windows.Forms.Panel GaugesPanel;
        private LiveCharts.WinForms.SolidGauge SignalStrengthGauge;
        private LiveCharts.WinForms.SolidGauge StreamingRateGauge;
        private LiveCharts.WinForms.SolidGauge SignalQualityGauge;
        private LiveCharts.WinForms.SolidGauge SymbolQualityGauge;
        private System.Windows.Forms.GroupBox TunerInfoGroupBox;
        private System.Windows.Forms.Panel TunerInfoGroupBoxPanel;
        private System.Windows.Forms.TextBox TunerInfoModulationTextBox;
        private System.Windows.Forms.Label TunerInfoModulationLabel;
        private System.Windows.Forms.TextBox TunerInfoProgramNumberTextBox;
        private System.Windows.Forms.Label TunerInfoProgramNumberLabel;
        private System.Windows.Forms.TextBox TunerInfoPCRTextBox;
        private System.Windows.Forms.Label TunerInfoPCRLabel;
        private System.Windows.Forms.TextBox TunerInfoFrequencyTextBox;
        private System.Windows.Forms.Label TunerInfoFrequencyLabel;
        private System.Windows.Forms.TextBox TunerInfoChannelTextBox;
        private System.Windows.Forms.Label TunerInfoChannelLabel;
        private System.Windows.Forms.Label StreamingRateLabel;
        private System.Windows.Forms.Label SymbolQualityLabel;
        private System.Windows.Forms.Label SignalQualityLabel;
        private System.Windows.Forms.Label SignalStrengthLabel;
        private System.Windows.Forms.TabPage TabBrowserPage;
        private System.Windows.Forms.Panel BrowserControlPanel;
        private System.Windows.Forms.Button BrowserOpenButton;
        private System.Windows.Forms.Button BrowserForwardButton;
        private System.Windows.Forms.Button BrowserBackButton;
        private System.Windows.Forms.Button BrowserHomeButton;
        private System.Windows.Forms.TabPage TabStreamPage;
        private System.Windows.Forms.Button OpenStreamButton;
        private System.Windows.Forms.TextBox StreamTimeTextBox;
        private System.Windows.Forms.TextBox StreamStatusTextBox;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl StreamPlayer;
        private System.Windows.Forms.TabPage TabChannelsPage;
        private System.Windows.Forms.DataGridView ChannelsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn AudioCodec;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoCodec;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamURL;
        private System.Windows.Forms.Panel ChannelsMenuPanel;
        private System.Windows.Forms.Label ChannelsSearchLabel;
        private System.Windows.Forms.Button ChannelsRefreshButton;
        private System.Windows.Forms.TabPage TabGraphingPage;
        private System.Windows.Forms.Panel GraphingPanel;
        private System.Windows.Forms.Button GraphingAdvancedButton;
        private LiveCharts.WinForms.CartesianChart GraphingStreamingGraph;
        private LiveCharts.WinForms.CartesianChart GraphingSignalGraph;
        private System.Windows.Forms.TabPage TabDevicePage;
        private System.Windows.Forms.TabPage TabSettingsPage;
        private System.Windows.Forms.GroupBox SettingsDataGroupBox;
        private System.Windows.Forms.NumericUpDown SettingsPageRefreshRateValue;
        private System.Windows.Forms.Label RefreshRateLabel;
        private System.Windows.Forms.Panel MenuButtonsPanel;
        private System.Windows.Forms.Button MenuBrowserButton;
        private System.Windows.Forms.Button MenuTunerInfoButton;
        private System.Windows.Forms.Button MenuSettingsButton;
        private System.Windows.Forms.Button MenuDeviceInfoButton;
        private System.Windows.Forms.Button MenuGraphingButton;
        private System.Windows.Forms.Button MenuChannelsButton;
        private System.Windows.Forms.Button MenuStreamingButton;
        private System.Windows.Forms.Button GraphingEnabledButton;
        private System.Windows.Forms.Label GraphingEnabledLabel;
        private System.Windows.Forms.Label TunerViewerLabel;
        private System.Windows.Forms.TextBox ChannelsSearchTextBox;
        private System.Windows.Forms.GroupBox LocalDiscoveryGroupBox;
        private System.Windows.Forms.Label UDPDiscoveryLabel;
        private System.Windows.Forms.Button UDPDiscoveryButton;
        private System.Windows.Forms.ToolTip UDPDiscoveryToolTip;
        private System.Windows.Forms.GroupBox GraphingControlGroupBox;
        private System.Windows.Forms.Label MaxStoredValuesLabel;
        private System.Windows.Forms.NumericUpDown MaxStoredValues;
        private System.Windows.Forms.Panel DeviceInfoGBPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DeviceValidationTextBox;
        private System.Windows.Forms.TextBox DeviceOOBLockTextBox;
        private System.Windows.Forms.TextBox DeviceAuthenticationTextBox;
        private System.Windows.Forms.Label DeviceValidationLabel;
        private System.Windows.Forms.Label DeviceOOBLockLabel;
        private System.Windows.Forms.Label DeviceAuthenticationLabel;
        private System.Windows.Forms.GroupBox DeviceControlGroupBox;
        private System.Windows.Forms.Button CardPairingButton;
        private System.Windows.Forms.Label CardPairingLabel;
        private System.Windows.Forms.Button RestartDeviceButton2;
        private System.Windows.Forms.Label RestartDeviceLabel;
        private System.Windows.Forms.Button FirmwareUpdateButton;
        private System.Windows.Forms.Label FirmwareUpdateLabel;
        private System.Windows.Forms.GroupBox DeviceInfoGroupBox;
        private System.Windows.Forms.Label DeviceMACLabel;
        private System.Windows.Forms.TextBox DeviceMACTextBox;
        private System.Windows.Forms.TextBox DeviceMemoryTextBox;
        private System.Windows.Forms.Label DeviceMemoryLabel;
        private System.Windows.Forms.TextBox DeviceIPTextBox;
        private System.Windows.Forms.TextBox DeviceFirmwareTextBox;
        private System.Windows.Forms.TextBox DeviceModelTextBox;
        private System.Windows.Forms.Label DeviceIPLabel;
        private System.Windows.Forms.Label DeviceFirmwareLabel;
        private System.Windows.Forms.Label DeviceModelLabel;
        private System.Windows.Forms.Button DeviceLogsButton;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Label UseHDHRConfigLabel;
        private System.Windows.Forms.Button UseHDHRConfigButton;
        private System.Windows.Forms.ToolTip UseHDHRConfigToolTip;
        private System.Windows.Forms.GroupBox RemoteDiscoveryGroupBox;
        private System.Windows.Forms.Label HDHRDiscoverLabel;
        private System.Windows.Forms.Button HDHRDiscoverButton;
        private System.Windows.Forms.ToolTip UseRemoteHDHRDiscovery;
    }
}

