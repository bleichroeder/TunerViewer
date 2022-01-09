
namespace TunerViewer2
{
    partial class AdvancedGraphing
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
            this.AdvancedGraphingControlPanel = new System.Windows.Forms.Panel();
            this.AdvGraphingSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StreamingRGroupBox = new System.Windows.Forms.GroupBox();
            this.StreamingRateAve = new System.Windows.Forms.TextBox();
            this.StreamingRateMax = new System.Windows.Forms.TextBox();
            this.StreamingRateMin = new System.Windows.Forms.TextBox();
            this.StreamingRateAveLabel = new System.Windows.Forms.Label();
            this.StreamingRateMaxLabel = new System.Windows.Forms.Label();
            this.StreamingRateMinLabel = new System.Windows.Forms.Label();
            this.StreamingRateGauge = new LiveCharts.WinForms.SolidGauge();
            this.SymbolQGroupBox = new System.Windows.Forms.GroupBox();
            this.SymbolQualityAve = new System.Windows.Forms.TextBox();
            this.SymbolQualityMax = new System.Windows.Forms.TextBox();
            this.SymbolQualityMin = new System.Windows.Forms.TextBox();
            this.SymbolQualityAveLabel = new System.Windows.Forms.Label();
            this.SymbolQualityMaxLabel = new System.Windows.Forms.Label();
            this.SymbolQualityMinLabel = new System.Windows.Forms.Label();
            this.SymbolQualityGauge = new LiveCharts.WinForms.SolidGauge();
            this.SignalQGroupBox = new System.Windows.Forms.GroupBox();
            this.SignalQualityAve = new System.Windows.Forms.TextBox();
            this.SignalQualityMax = new System.Windows.Forms.TextBox();
            this.SignalQualityMin = new System.Windows.Forms.TextBox();
            this.SignalQualityAveLabel = new System.Windows.Forms.Label();
            this.SignalQualityMaxLabel = new System.Windows.Forms.Label();
            this.SignalQualityMinLabel = new System.Windows.Forms.Label();
            this.SignalQualityGauge = new LiveCharts.WinForms.SolidGauge();
            this.SignalSGroupBox = new System.Windows.Forms.GroupBox();
            this.SignalStrengthAve = new System.Windows.Forms.TextBox();
            this.SignalStrengthMax = new System.Windows.Forms.TextBox();
            this.SignalStrengthMin = new System.Windows.Forms.TextBox();
            this.SignalStrengthAveLabel = new System.Windows.Forms.Label();
            this.SignalStrengthMaxLabel = new System.Windows.Forms.Label();
            this.SignalStrengthMinLabel = new System.Windows.Forms.Label();
            this.SignalStrengthGauge = new LiveCharts.WinForms.SolidGauge();
            this.ClearDataButton = new System.Windows.Forms.Button();
            this.PauseGraphingButton = new System.Windows.Forms.Button();
            this.ExportDataButton = new System.Windows.Forms.Button();
            this.GraphingPanel = new System.Windows.Forms.Panel();
            this.StreamingRateGraph = new LiveCharts.WinForms.CartesianChart();
            this.SignalGraph = new LiveCharts.WinForms.CartesianChart();
            this.MaxValuesPicker = new System.Windows.Forms.NumericUpDown();
            this.MaxValuesLabel = new System.Windows.Forms.Label();
            this.CurrentTunerLabel = new System.Windows.Forms.Label();
            this.CurrentTuner = new System.Windows.Forms.Label();
            this.AdvancedGraphingControlPanel.SuspendLayout();
            this.AdvGraphingSettingsGroupBox.SuspendLayout();
            this.StreamingRGroupBox.SuspendLayout();
            this.SymbolQGroupBox.SuspendLayout();
            this.SignalQGroupBox.SuspendLayout();
            this.SignalSGroupBox.SuspendLayout();
            this.GraphingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxValuesPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvancedGraphingControlPanel
            // 
            this.AdvancedGraphingControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.AdvancedGraphingControlPanel.Controls.Add(this.CurrentTuner);
            this.AdvancedGraphingControlPanel.Controls.Add(this.CurrentTunerLabel);
            this.AdvancedGraphingControlPanel.Controls.Add(this.AdvGraphingSettingsGroupBox);
            this.AdvancedGraphingControlPanel.Controls.Add(this.StreamingRGroupBox);
            this.AdvancedGraphingControlPanel.Controls.Add(this.SymbolQGroupBox);
            this.AdvancedGraphingControlPanel.Controls.Add(this.SignalQGroupBox);
            this.AdvancedGraphingControlPanel.Controls.Add(this.SignalSGroupBox);
            this.AdvancedGraphingControlPanel.Controls.Add(this.ClearDataButton);
            this.AdvancedGraphingControlPanel.Controls.Add(this.PauseGraphingButton);
            this.AdvancedGraphingControlPanel.Controls.Add(this.ExportDataButton);
            this.AdvancedGraphingControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdvancedGraphingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.AdvancedGraphingControlPanel.Name = "AdvancedGraphingControlPanel";
            this.AdvancedGraphingControlPanel.Size = new System.Drawing.Size(1327, 115);
            this.AdvancedGraphingControlPanel.TabIndex = 2;
            // 
            // AdvGraphingSettingsGroupBox
            // 
            this.AdvGraphingSettingsGroupBox.Controls.Add(this.MaxValuesLabel);
            this.AdvGraphingSettingsGroupBox.Controls.Add(this.MaxValuesPicker);
            this.AdvGraphingSettingsGroupBox.Location = new System.Drawing.Point(991, 52);
            this.AdvGraphingSettingsGroupBox.Name = "AdvGraphingSettingsGroupBox";
            this.AdvGraphingSettingsGroupBox.Size = new System.Drawing.Size(204, 57);
            this.AdvGraphingSettingsGroupBox.TabIndex = 11;
            this.AdvGraphingSettingsGroupBox.TabStop = false;
            this.AdvGraphingSettingsGroupBox.Text = "Settings";
            // 
            // StreamingRGroupBox
            // 
            this.StreamingRGroupBox.Controls.Add(this.StreamingRateAve);
            this.StreamingRGroupBox.Controls.Add(this.StreamingRateMax);
            this.StreamingRGroupBox.Controls.Add(this.StreamingRateMin);
            this.StreamingRGroupBox.Controls.Add(this.StreamingRateAveLabel);
            this.StreamingRGroupBox.Controls.Add(this.StreamingRateMaxLabel);
            this.StreamingRGroupBox.Controls.Add(this.StreamingRateMinLabel);
            this.StreamingRGroupBox.Controls.Add(this.StreamingRateGauge);
            this.StreamingRGroupBox.Location = new System.Drawing.Point(744, 3);
            this.StreamingRGroupBox.Name = "StreamingRGroupBox";
            this.StreamingRGroupBox.Size = new System.Drawing.Size(241, 106);
            this.StreamingRGroupBox.TabIndex = 10;
            this.StreamingRGroupBox.TabStop = false;
            this.StreamingRGroupBox.Text = "Streaming Rate";
            // 
            // StreamingRateAve
            // 
            this.StreamingRateAve.Enabled = false;
            this.StreamingRateAve.Location = new System.Drawing.Point(171, 69);
            this.StreamingRateAve.Name = "StreamingRateAve";
            this.StreamingRateAve.ReadOnly = true;
            this.StreamingRateAve.Size = new System.Drawing.Size(62, 20);
            this.StreamingRateAve.TabIndex = 9;
            // 
            // StreamingRateMax
            // 
            this.StreamingRateMax.Enabled = false;
            this.StreamingRateMax.Location = new System.Drawing.Point(171, 46);
            this.StreamingRateMax.Name = "StreamingRateMax";
            this.StreamingRateMax.ReadOnly = true;
            this.StreamingRateMax.Size = new System.Drawing.Size(62, 20);
            this.StreamingRateMax.TabIndex = 8;
            // 
            // StreamingRateMin
            // 
            this.StreamingRateMin.Enabled = false;
            this.StreamingRateMin.Location = new System.Drawing.Point(171, 23);
            this.StreamingRateMin.Name = "StreamingRateMin";
            this.StreamingRateMin.ReadOnly = true;
            this.StreamingRateMin.Size = new System.Drawing.Size(62, 20);
            this.StreamingRateMin.TabIndex = 7;
            // 
            // StreamingRateAveLabel
            // 
            this.StreamingRateAveLabel.AutoSize = true;
            this.StreamingRateAveLabel.Location = new System.Drawing.Point(137, 72);
            this.StreamingRateAveLabel.Name = "StreamingRateAveLabel";
            this.StreamingRateAveLabel.Size = new System.Drawing.Size(29, 13);
            this.StreamingRateAveLabel.TabIndex = 6;
            this.StreamingRateAveLabel.Text = "Ave:";
            // 
            // StreamingRateMaxLabel
            // 
            this.StreamingRateMaxLabel.AutoSize = true;
            this.StreamingRateMaxLabel.Location = new System.Drawing.Point(137, 49);
            this.StreamingRateMaxLabel.Name = "StreamingRateMaxLabel";
            this.StreamingRateMaxLabel.Size = new System.Drawing.Size(30, 13);
            this.StreamingRateMaxLabel.TabIndex = 5;
            this.StreamingRateMaxLabel.Text = "Max:";
            // 
            // StreamingRateMinLabel
            // 
            this.StreamingRateMinLabel.AutoSize = true;
            this.StreamingRateMinLabel.Location = new System.Drawing.Point(137, 26);
            this.StreamingRateMinLabel.Name = "StreamingRateMinLabel";
            this.StreamingRateMinLabel.Size = new System.Drawing.Size(27, 13);
            this.StreamingRateMinLabel.TabIndex = 4;
            this.StreamingRateMinLabel.Text = "Min:";
            // 
            // StreamingRateGauge
            // 
            this.StreamingRateGauge.Location = new System.Drawing.Point(9, 13);
            this.StreamingRateGauge.Name = "StreamingRateGauge";
            this.StreamingRateGauge.Size = new System.Drawing.Size(116, 87);
            this.StreamingRateGauge.TabIndex = 3;
            this.StreamingRateGauge.Text = "solidGauge4";
            // 
            // SymbolQGroupBox
            // 
            this.SymbolQGroupBox.Controls.Add(this.SymbolQualityAve);
            this.SymbolQGroupBox.Controls.Add(this.SymbolQualityMax);
            this.SymbolQGroupBox.Controls.Add(this.SymbolQualityMin);
            this.SymbolQGroupBox.Controls.Add(this.SymbolQualityAveLabel);
            this.SymbolQGroupBox.Controls.Add(this.SymbolQualityMaxLabel);
            this.SymbolQGroupBox.Controls.Add(this.SymbolQualityMinLabel);
            this.SymbolQGroupBox.Controls.Add(this.SymbolQualityGauge);
            this.SymbolQGroupBox.Location = new System.Drawing.Point(497, 3);
            this.SymbolQGroupBox.Name = "SymbolQGroupBox";
            this.SymbolQGroupBox.Size = new System.Drawing.Size(241, 106);
            this.SymbolQGroupBox.TabIndex = 10;
            this.SymbolQGroupBox.TabStop = false;
            this.SymbolQGroupBox.Text = "Symbol Quality";
            // 
            // SymbolQualityAve
            // 
            this.SymbolQualityAve.Enabled = false;
            this.SymbolQualityAve.Location = new System.Drawing.Point(171, 69);
            this.SymbolQualityAve.Name = "SymbolQualityAve";
            this.SymbolQualityAve.ReadOnly = true;
            this.SymbolQualityAve.Size = new System.Drawing.Size(62, 20);
            this.SymbolQualityAve.TabIndex = 9;
            // 
            // SymbolQualityMax
            // 
            this.SymbolQualityMax.Enabled = false;
            this.SymbolQualityMax.Location = new System.Drawing.Point(171, 46);
            this.SymbolQualityMax.Name = "SymbolQualityMax";
            this.SymbolQualityMax.ReadOnly = true;
            this.SymbolQualityMax.Size = new System.Drawing.Size(62, 20);
            this.SymbolQualityMax.TabIndex = 8;
            // 
            // SymbolQualityMin
            // 
            this.SymbolQualityMin.Enabled = false;
            this.SymbolQualityMin.Location = new System.Drawing.Point(171, 23);
            this.SymbolQualityMin.Name = "SymbolQualityMin";
            this.SymbolQualityMin.ReadOnly = true;
            this.SymbolQualityMin.Size = new System.Drawing.Size(62, 20);
            this.SymbolQualityMin.TabIndex = 7;
            // 
            // SymbolQualityAveLabel
            // 
            this.SymbolQualityAveLabel.AutoSize = true;
            this.SymbolQualityAveLabel.Location = new System.Drawing.Point(137, 72);
            this.SymbolQualityAveLabel.Name = "SymbolQualityAveLabel";
            this.SymbolQualityAveLabel.Size = new System.Drawing.Size(29, 13);
            this.SymbolQualityAveLabel.TabIndex = 6;
            this.SymbolQualityAveLabel.Text = "Ave:";
            // 
            // SymbolQualityMaxLabel
            // 
            this.SymbolQualityMaxLabel.AutoSize = true;
            this.SymbolQualityMaxLabel.Location = new System.Drawing.Point(137, 49);
            this.SymbolQualityMaxLabel.Name = "SymbolQualityMaxLabel";
            this.SymbolQualityMaxLabel.Size = new System.Drawing.Size(30, 13);
            this.SymbolQualityMaxLabel.TabIndex = 5;
            this.SymbolQualityMaxLabel.Text = "Max:";
            // 
            // SymbolQualityMinLabel
            // 
            this.SymbolQualityMinLabel.AutoSize = true;
            this.SymbolQualityMinLabel.Location = new System.Drawing.Point(137, 26);
            this.SymbolQualityMinLabel.Name = "SymbolQualityMinLabel";
            this.SymbolQualityMinLabel.Size = new System.Drawing.Size(27, 13);
            this.SymbolQualityMinLabel.TabIndex = 4;
            this.SymbolQualityMinLabel.Text = "Min:";
            // 
            // SymbolQualityGauge
            // 
            this.SymbolQualityGauge.Location = new System.Drawing.Point(9, 13);
            this.SymbolQualityGauge.Name = "SymbolQualityGauge";
            this.SymbolQualityGauge.Size = new System.Drawing.Size(116, 87);
            this.SymbolQualityGauge.TabIndex = 3;
            this.SymbolQualityGauge.Text = "solidGauge3";
            // 
            // SignalQGroupBox
            // 
            this.SignalQGroupBox.Controls.Add(this.SignalQualityAve);
            this.SignalQGroupBox.Controls.Add(this.SignalQualityMax);
            this.SignalQGroupBox.Controls.Add(this.SignalQualityMin);
            this.SignalQGroupBox.Controls.Add(this.SignalQualityAveLabel);
            this.SignalQGroupBox.Controls.Add(this.SignalQualityMaxLabel);
            this.SignalQGroupBox.Controls.Add(this.SignalQualityMinLabel);
            this.SignalQGroupBox.Controls.Add(this.SignalQualityGauge);
            this.SignalQGroupBox.Location = new System.Drawing.Point(250, 3);
            this.SignalQGroupBox.Name = "SignalQGroupBox";
            this.SignalQGroupBox.Size = new System.Drawing.Size(241, 106);
            this.SignalQGroupBox.TabIndex = 10;
            this.SignalQGroupBox.TabStop = false;
            this.SignalQGroupBox.Text = "Signal Quality";
            // 
            // SignalQualityAve
            // 
            this.SignalQualityAve.Enabled = false;
            this.SignalQualityAve.Location = new System.Drawing.Point(171, 69);
            this.SignalQualityAve.Name = "SignalQualityAve";
            this.SignalQualityAve.ReadOnly = true;
            this.SignalQualityAve.Size = new System.Drawing.Size(62, 20);
            this.SignalQualityAve.TabIndex = 9;
            // 
            // SignalQualityMax
            // 
            this.SignalQualityMax.Enabled = false;
            this.SignalQualityMax.Location = new System.Drawing.Point(171, 46);
            this.SignalQualityMax.Name = "SignalQualityMax";
            this.SignalQualityMax.ReadOnly = true;
            this.SignalQualityMax.Size = new System.Drawing.Size(62, 20);
            this.SignalQualityMax.TabIndex = 8;
            // 
            // SignalQualityMin
            // 
            this.SignalQualityMin.Enabled = false;
            this.SignalQualityMin.Location = new System.Drawing.Point(171, 23);
            this.SignalQualityMin.Name = "SignalQualityMin";
            this.SignalQualityMin.ReadOnly = true;
            this.SignalQualityMin.Size = new System.Drawing.Size(62, 20);
            this.SignalQualityMin.TabIndex = 7;
            // 
            // SignalQualityAveLabel
            // 
            this.SignalQualityAveLabel.AutoSize = true;
            this.SignalQualityAveLabel.Location = new System.Drawing.Point(137, 72);
            this.SignalQualityAveLabel.Name = "SignalQualityAveLabel";
            this.SignalQualityAveLabel.Size = new System.Drawing.Size(29, 13);
            this.SignalQualityAveLabel.TabIndex = 6;
            this.SignalQualityAveLabel.Text = "Ave:";
            // 
            // SignalQualityMaxLabel
            // 
            this.SignalQualityMaxLabel.AutoSize = true;
            this.SignalQualityMaxLabel.Location = new System.Drawing.Point(137, 49);
            this.SignalQualityMaxLabel.Name = "SignalQualityMaxLabel";
            this.SignalQualityMaxLabel.Size = new System.Drawing.Size(30, 13);
            this.SignalQualityMaxLabel.TabIndex = 5;
            this.SignalQualityMaxLabel.Text = "Max:";
            // 
            // SignalQualityMinLabel
            // 
            this.SignalQualityMinLabel.AutoSize = true;
            this.SignalQualityMinLabel.Location = new System.Drawing.Point(137, 26);
            this.SignalQualityMinLabel.Name = "SignalQualityMinLabel";
            this.SignalQualityMinLabel.Size = new System.Drawing.Size(27, 13);
            this.SignalQualityMinLabel.TabIndex = 4;
            this.SignalQualityMinLabel.Text = "Min:";
            // 
            // SignalQualityGauge
            // 
            this.SignalQualityGauge.Location = new System.Drawing.Point(9, 13);
            this.SignalQualityGauge.Name = "SignalQualityGauge";
            this.SignalQualityGauge.Size = new System.Drawing.Size(116, 87);
            this.SignalQualityGauge.TabIndex = 3;
            this.SignalQualityGauge.Text = "solidGauge2";
            // 
            // SignalSGroupBox
            // 
            this.SignalSGroupBox.Controls.Add(this.SignalStrengthAve);
            this.SignalSGroupBox.Controls.Add(this.SignalStrengthMax);
            this.SignalSGroupBox.Controls.Add(this.SignalStrengthMin);
            this.SignalSGroupBox.Controls.Add(this.SignalStrengthAveLabel);
            this.SignalSGroupBox.Controls.Add(this.SignalStrengthMaxLabel);
            this.SignalSGroupBox.Controls.Add(this.SignalStrengthMinLabel);
            this.SignalSGroupBox.Controls.Add(this.SignalStrengthGauge);
            this.SignalSGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SignalSGroupBox.Name = "SignalSGroupBox";
            this.SignalSGroupBox.Size = new System.Drawing.Size(241, 106);
            this.SignalSGroupBox.TabIndex = 4;
            this.SignalSGroupBox.TabStop = false;
            this.SignalSGroupBox.Text = "Signal Strength";
            // 
            // SignalStrengthAve
            // 
            this.SignalStrengthAve.Enabled = false;
            this.SignalStrengthAve.Location = new System.Drawing.Point(171, 69);
            this.SignalStrengthAve.Name = "SignalStrengthAve";
            this.SignalStrengthAve.ReadOnly = true;
            this.SignalStrengthAve.Size = new System.Drawing.Size(62, 20);
            this.SignalStrengthAve.TabIndex = 9;
            // 
            // SignalStrengthMax
            // 
            this.SignalStrengthMax.Enabled = false;
            this.SignalStrengthMax.Location = new System.Drawing.Point(171, 46);
            this.SignalStrengthMax.Name = "SignalStrengthMax";
            this.SignalStrengthMax.ReadOnly = true;
            this.SignalStrengthMax.Size = new System.Drawing.Size(62, 20);
            this.SignalStrengthMax.TabIndex = 8;
            // 
            // SignalStrengthMin
            // 
            this.SignalStrengthMin.Enabled = false;
            this.SignalStrengthMin.Location = new System.Drawing.Point(171, 23);
            this.SignalStrengthMin.Name = "SignalStrengthMin";
            this.SignalStrengthMin.ReadOnly = true;
            this.SignalStrengthMin.Size = new System.Drawing.Size(62, 20);
            this.SignalStrengthMin.TabIndex = 7;
            // 
            // SignalStrengthAveLabel
            // 
            this.SignalStrengthAveLabel.AutoSize = true;
            this.SignalStrengthAveLabel.Location = new System.Drawing.Point(137, 72);
            this.SignalStrengthAveLabel.Name = "SignalStrengthAveLabel";
            this.SignalStrengthAveLabel.Size = new System.Drawing.Size(29, 13);
            this.SignalStrengthAveLabel.TabIndex = 6;
            this.SignalStrengthAveLabel.Text = "Ave:";
            // 
            // SignalStrengthMaxLabel
            // 
            this.SignalStrengthMaxLabel.AutoSize = true;
            this.SignalStrengthMaxLabel.Location = new System.Drawing.Point(137, 49);
            this.SignalStrengthMaxLabel.Name = "SignalStrengthMaxLabel";
            this.SignalStrengthMaxLabel.Size = new System.Drawing.Size(30, 13);
            this.SignalStrengthMaxLabel.TabIndex = 5;
            this.SignalStrengthMaxLabel.Text = "Max:";
            // 
            // SignalStrengthMinLabel
            // 
            this.SignalStrengthMinLabel.AutoSize = true;
            this.SignalStrengthMinLabel.Location = new System.Drawing.Point(137, 26);
            this.SignalStrengthMinLabel.Name = "SignalStrengthMinLabel";
            this.SignalStrengthMinLabel.Size = new System.Drawing.Size(27, 13);
            this.SignalStrengthMinLabel.TabIndex = 4;
            this.SignalStrengthMinLabel.Text = "Min:";
            // 
            // SignalStrengthGauge
            // 
            this.SignalStrengthGauge.Location = new System.Drawing.Point(9, 13);
            this.SignalStrengthGauge.Name = "SignalStrengthGauge";
            this.SignalStrengthGauge.Size = new System.Drawing.Size(116, 87);
            this.SignalStrengthGauge.TabIndex = 3;
            // 
            // ClearDataButton
            // 
            this.ClearDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearDataButton.Location = new System.Drawing.Point(1204, 47);
            this.ClearDataButton.Name = "ClearDataButton";
            this.ClearDataButton.Size = new System.Drawing.Size(114, 23);
            this.ClearDataButton.TabIndex = 2;
            this.ClearDataButton.Text = "Clear Data";
            this.ClearDataButton.UseVisualStyleBackColor = false;
            this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // PauseGraphingButton
            // 
            this.PauseGraphingButton.BackColor = System.Drawing.Color.LightGreen;
            this.PauseGraphingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseGraphingButton.Location = new System.Drawing.Point(1204, 10);
            this.PauseGraphingButton.Name = "PauseGraphingButton";
            this.PauseGraphingButton.Size = new System.Drawing.Size(114, 23);
            this.PauseGraphingButton.TabIndex = 1;
            this.PauseGraphingButton.Text = "Pause Graphing";
            this.PauseGraphingButton.UseVisualStyleBackColor = false;
            this.PauseGraphingButton.Click += new System.EventHandler(this.PauseGraphingButton_Click);
            // 
            // ExportDataButton
            // 
            this.ExportDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExportDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportDataButton.Location = new System.Drawing.Point(1204, 84);
            this.ExportDataButton.Name = "ExportDataButton";
            this.ExportDataButton.Size = new System.Drawing.Size(114, 23);
            this.ExportDataButton.TabIndex = 0;
            this.ExportDataButton.Text = "Export Current Data";
            this.ExportDataButton.UseVisualStyleBackColor = false;
            this.ExportDataButton.Click += new System.EventHandler(this.ExportDataButton_Click);
            // 
            // GraphingPanel
            // 
            this.GraphingPanel.BackColor = System.Drawing.Color.White;
            this.GraphingPanel.Controls.Add(this.StreamingRateGraph);
            this.GraphingPanel.Controls.Add(this.SignalGraph);
            this.GraphingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphingPanel.Location = new System.Drawing.Point(0, 115);
            this.GraphingPanel.Name = "GraphingPanel";
            this.GraphingPanel.Size = new System.Drawing.Size(1327, 610);
            this.GraphingPanel.TabIndex = 3;
            // 
            // StreamingRateGraph
            // 
            this.StreamingRateGraph.Location = new System.Drawing.Point(12, 426);
            this.StreamingRateGraph.Name = "StreamingRateGraph";
            this.StreamingRateGraph.Size = new System.Drawing.Size(1303, 172);
            this.StreamingRateGraph.TabIndex = 1;
            this.StreamingRateGraph.Text = "cartesianChart1";
            // 
            // SignalGraph
            // 
            this.SignalGraph.Location = new System.Drawing.Point(12, 6);
            this.SignalGraph.Name = "SignalGraph";
            this.SignalGraph.Size = new System.Drawing.Size(1303, 414);
            this.SignalGraph.TabIndex = 0;
            this.SignalGraph.Text = "cartesianChart1";
            // 
            // MaxValuesPicker
            // 
            this.MaxValuesPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxValuesPicker.Location = new System.Drawing.Point(129, 23);
            this.MaxValuesPicker.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.MaxValuesPicker.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxValuesPicker.Name = "MaxValuesPicker";
            this.MaxValuesPicker.Size = new System.Drawing.Size(65, 20);
            this.MaxValuesPicker.TabIndex = 0;
            this.MaxValuesPicker.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxValuesPicker.ValueChanged += new System.EventHandler(this.MaxValuesPicker_ValueChanged);
            // 
            // MaxValuesLabel
            // 
            this.MaxValuesLabel.AutoSize = true;
            this.MaxValuesLabel.Location = new System.Drawing.Point(16, 26);
            this.MaxValuesLabel.Name = "MaxValuesLabel";
            this.MaxValuesLabel.Size = new System.Drawing.Size(110, 13);
            this.MaxValuesLabel.TabIndex = 10;
            this.MaxValuesLabel.Text = "MaxValues(Seconds):";
            // 
            // CurrentTunerLabel
            // 
            this.CurrentTunerLabel.AutoSize = true;
            this.CurrentTunerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTunerLabel.Location = new System.Drawing.Point(1012, 20);
            this.CurrentTunerLabel.Name = "CurrentTunerLabel";
            this.CurrentTunerLabel.Size = new System.Drawing.Size(85, 15);
            this.CurrentTunerLabel.TabIndex = 12;
            this.CurrentTunerLabel.Text = "Current Tuner:";
            // 
            // CurrentTuner
            // 
            this.CurrentTuner.AutoSize = true;
            this.CurrentTuner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTuner.Location = new System.Drawing.Point(1092, 20);
            this.CurrentTuner.Name = "CurrentTuner";
            this.CurrentTuner.Size = new System.Drawing.Size(84, 15);
            this.CurrentTuner.TabIndex = 13;
            this.CurrentTuner.Text = "12345678-0";
            // 
            // AdvancedGraphing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 725);
            this.Controls.Add(this.GraphingPanel);
            this.Controls.Add(this.AdvancedGraphingControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AdvancedGraphing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdvancedGraphing";
            this.Load += new System.EventHandler(this.AdvancedGraphing_Load);
            this.AdvancedGraphingControlPanel.ResumeLayout(false);
            this.AdvancedGraphingControlPanel.PerformLayout();
            this.AdvGraphingSettingsGroupBox.ResumeLayout(false);
            this.AdvGraphingSettingsGroupBox.PerformLayout();
            this.StreamingRGroupBox.ResumeLayout(false);
            this.StreamingRGroupBox.PerformLayout();
            this.SymbolQGroupBox.ResumeLayout(false);
            this.SymbolQGroupBox.PerformLayout();
            this.SignalQGroupBox.ResumeLayout(false);
            this.SignalQGroupBox.PerformLayout();
            this.SignalSGroupBox.ResumeLayout(false);
            this.SignalSGroupBox.PerformLayout();
            this.GraphingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaxValuesPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AdvancedGraphingControlPanel;
        private System.Windows.Forms.Panel GraphingPanel;
        private LiveCharts.WinForms.CartesianChart SignalGraph;
        private LiveCharts.WinForms.CartesianChart StreamingRateGraph;
        private System.Windows.Forms.Button ClearDataButton;
        private System.Windows.Forms.Button PauseGraphingButton;
        private System.Windows.Forms.Button ExportDataButton;
        private System.Windows.Forms.GroupBox AdvGraphingSettingsGroupBox;
        private System.Windows.Forms.GroupBox StreamingRGroupBox;
        private System.Windows.Forms.TextBox StreamingRateAve;
        private System.Windows.Forms.TextBox StreamingRateMax;
        private System.Windows.Forms.TextBox StreamingRateMin;
        private System.Windows.Forms.Label StreamingRateAveLabel;
        private System.Windows.Forms.Label StreamingRateMaxLabel;
        private System.Windows.Forms.Label StreamingRateMinLabel;
        private LiveCharts.WinForms.SolidGauge StreamingRateGauge;
        private System.Windows.Forms.GroupBox SymbolQGroupBox;
        private System.Windows.Forms.TextBox SymbolQualityAve;
        private System.Windows.Forms.TextBox SymbolQualityMax;
        private System.Windows.Forms.TextBox SymbolQualityMin;
        private System.Windows.Forms.Label SymbolQualityAveLabel;
        private System.Windows.Forms.Label SymbolQualityMaxLabel;
        private System.Windows.Forms.Label SymbolQualityMinLabel;
        private LiveCharts.WinForms.SolidGauge SymbolQualityGauge;
        private System.Windows.Forms.GroupBox SignalQGroupBox;
        private System.Windows.Forms.TextBox SignalQualityAve;
        private System.Windows.Forms.TextBox SignalQualityMax;
        private System.Windows.Forms.TextBox SignalQualityMin;
        private System.Windows.Forms.Label SignalQualityAveLabel;
        private System.Windows.Forms.Label SignalQualityMaxLabel;
        private System.Windows.Forms.Label SignalQualityMinLabel;
        private LiveCharts.WinForms.SolidGauge SignalQualityGauge;
        private System.Windows.Forms.GroupBox SignalSGroupBox;
        private System.Windows.Forms.TextBox SignalStrengthAve;
        private System.Windows.Forms.TextBox SignalStrengthMax;
        private System.Windows.Forms.TextBox SignalStrengthMin;
        private System.Windows.Forms.Label SignalStrengthAveLabel;
        private System.Windows.Forms.Label SignalStrengthMaxLabel;
        private System.Windows.Forms.Label SignalStrengthMinLabel;
        private LiveCharts.WinForms.SolidGauge SignalStrengthGauge;
        private System.Windows.Forms.Label MaxValuesLabel;
        private System.Windows.Forms.NumericUpDown MaxValuesPicker;
        private System.Windows.Forms.Label CurrentTuner;
        private System.Windows.Forms.Label CurrentTunerLabel;
    }
}