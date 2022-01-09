using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace TunerViewer2
{
    public partial class AdvancedGraphing : Form
    {
        public ChartValues<MeasureModel> StreamingRateValues { get; set; }
        public ChartValues<MeasureModel> SignalStrengthValues { get; set; }
        public ChartValues<MeasureModel> SignalQualityValues { get; set; }
        public ChartValues<MeasureModel> SymbolQualityValues { get; set; }

        public int GraphingDurationSeconds { get; set; }
        public string DeviceID { get; set; }
        public int TunerNumber { get; set; }
        public int RefreshRate { get; set; }

        public bool Graphing = true;


        public int ReturnGraphingStep()
        {
            return GraphingDurationSeconds / 10;
        }

        public async void ClearAllValues()
        {
            try
            {
                CurrentTuner.Text = string.Format("{0}-{1}", DeviceID, TunerNumber);

                StreamingRateValues.Clear();
                SignalStrengthValues.Clear();
                SignalQualityValues.Clear();
                SymbolQualityValues.Clear();

                // signal strength stats
                SignalStrengthGauge.Invoke(new MethodInvoker(() =>
                {
                    SignalStrengthGauge.Value = 0;
                }));
                SignalStrengthMax.Invoke(new MethodInvoker(() =>
                {
                    SignalStrengthMax.Clear();
                }));
                SignalStrengthMin.Invoke(new MethodInvoker(() =>
                {
                    SignalStrengthMin.Clear();
                }));
                SignalStrengthAve.Invoke(new MethodInvoker(() =>
                {
                    SignalStrengthAve.Clear();
                }));

                // signal quality stats
                SignalQualityGauge.Invoke(new MethodInvoker(() =>
                {
                    SignalQualityGauge.Value = 0;
                }));
                SignalQualityMax.Invoke(new MethodInvoker(() =>
                {
                    SignalQualityMax.Clear();
                }));
                SignalQualityMin.Invoke(new MethodInvoker(() =>
                {
                    SignalQualityMin.Clear();
                }));
                SignalQualityAve.Invoke(new MethodInvoker(() =>
                {
                    SignalQualityAve.Clear();
                }));

                // symbol quality stats
                SymbolQualityGauge.Invoke(new MethodInvoker(() =>
                {
                    SymbolQualityGauge.Value = 0;
                }));
                SymbolQualityMax.Invoke(new MethodInvoker(() =>
                {
                    SymbolQualityMax.Clear();
                }));
                SymbolQualityMin.Invoke(new MethodInvoker(() =>
                {
                    SymbolQualityMin.Clear();
                }));
                SymbolQualityAve.Invoke(new MethodInvoker(() =>
                {
                    SymbolQualityAve.Clear();
                }));

                // streaming rate stats
                StreamingRateGauge.Invoke(new MethodInvoker(() =>
                {
                    StreamingRateGauge.Value = 0;
                }));
                StreamingRateMax.Invoke(new MethodInvoker(() =>
                {
                    StreamingRateMax.Clear();
                }));
                StreamingRateMin.Invoke(new MethodInvoker(() =>
                {
                    StreamingRateMin.Clear();
                }));
                StreamingRateAve.Invoke(new MethodInvoker(() =>
                {
                    StreamingRateAve.Clear();
                }));

                SetAxisLimits(DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            await Task.Delay(100);
        }



        public AdvancedGraphing()
        {
            InitializeComponent();
        }

        private async void InitializeGauges()
        {
            foreach (Control control in AdvancedGraphingControlPanel.Controls)
            {
                foreach(var icontrol in control.Controls)
                {
                    if (icontrol is SolidGauge gauge)
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
            }

            await Task.Delay(100);
        }


        public void SetAxisLimits(DateTime now)
        {
            try
            {
                SignalGraph.Invoke(new Action(delegate ()
                {
                    SignalGraph.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks;
                    SignalGraph.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(GraphingDurationSeconds).Ticks;
                    SignalGraph.AxisX[0].Separator.Step = TimeSpan.FromSeconds(ReturnGraphingStep()).Ticks;
                }));

                StreamingRateGraph.Invoke(new Action(delegate ()
                {
                    StreamingRateGraph.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks;
                    StreamingRateGraph.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(GraphingDurationSeconds).Ticks;
                    StreamingRateGraph.AxisX[0].Separator.Step = TimeSpan.FromSeconds(ReturnGraphingStep()).Ticks;
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private async void InitializeGraphs()
        {
            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            Charting.For<MeasureModel>(mapper);

            //StreamingRateValues.Clear();
            //SignalStrengthValues.Clear();
            //SignalQualityValues.Clear();
            //SymbolQualityValues.Clear();

            SignalGraph.AxisX.Clear();
            SignalGraph.AxisY.Clear();
            SignalGraph.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelsRotation = 20,
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(ReturnGraphingStep()).Ticks
                }
            });
            SignalGraph.AxisY.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 100
            });

            SignalGraph.Series = new SeriesCollection()
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
                new LiveCharts.Wpf.LineSeries("SignalQuality")
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
                new LiveCharts.Wpf.LineSeries("SymbolQuality")
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

            StreamingRateGraph.AxisX.Clear();
            StreamingRateGraph.AxisY.Clear();
            StreamingRateGraph.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelsRotation = 20,
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(ReturnGraphingStep()).Ticks
                }
            });
            StreamingRateGraph.AxisY.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 20
            });

            StreamingRateGraph.Series = new SeriesCollection()
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

        private void AdvancedGraphing_Load(object sender, EventArgs e)
        {
            InitializeGraphs();
            InitializeGauges();
            GaugeUpdater();
        }

        private async void GaugeUpdater()
        {
            while(true)
            {
                try
                {
                    CurrentTuner.Invoke(new MethodInvoker(() =>
                    {
                        CurrentTuner.Text = string.Format("{0}-{1}", DeviceID, TunerNumber);
                    }));
                    
                    double lastSignalStrengthValue = SignalStrengthValues[SignalStrengthValues.Count - 1].Value;
                    double lastSignalQualityValue = SignalQualityValues[SignalQualityValues.Count - 1].Value;
                    double lastSymbolQualityValue = SymbolQualityValues[SymbolQualityValues.Count - 1].Value;
                    double lastStreamingRateValue = StreamingRateValues[StreamingRateValues.Count - 1].Value;

                    // signal strength stats
                    SignalStrengthGauge.Invoke(new MethodInvoker(() =>
                    {
                        SignalStrengthGauge.Value = lastSignalStrengthValue;
                    }));
                    SignalStrengthMax.Invoke(new MethodInvoker(() =>
                    {
                        SignalStrengthMax.Text = SignalStrengthValues.Select(x => x.Value).Max().ToString();
                    }));
                    SignalStrengthMin.Invoke(new MethodInvoker(() =>
                    {
                        SignalStrengthMin.Text = SignalStrengthValues.Select(x => x.Value).Min().ToString();
                    }));
                    SignalStrengthAve.Invoke(new MethodInvoker(() =>
                    {
                        SignalStrengthAve.Text = SignalStrengthValues.Select(x => x.Value).Average().ToString();
                    }));

                    // signal quality stats
                    SignalQualityGauge.Invoke(new MethodInvoker(() =>
                    {
                        SignalQualityGauge.Value = lastSignalQualityValue;
                    }));
                    SignalQualityMax.Invoke(new MethodInvoker(() =>
                    {
                        SignalQualityMax.Text = SignalQualityValues.Select(x => x.Value).Max().ToString();
                    }));
                    SignalQualityMin.Invoke(new MethodInvoker(() =>
                    {
                        SignalQualityMin.Text = SignalQualityValues.Select(x => x.Value).Min().ToString();
                    }));
                    SignalQualityAve.Invoke(new MethodInvoker(() =>
                    {
                        SignalQualityAve.Text = SignalQualityValues.Select(x => x.Value).Average().ToString();
                    }));

                    // symbol quality stats
                    SymbolQualityGauge.Invoke(new MethodInvoker(() =>
                    {
                        SymbolQualityGauge.Value = lastSymbolQualityValue;
                    }));
                    SymbolQualityMax.Invoke(new MethodInvoker(() =>
                    {
                        SymbolQualityMax.Text = SymbolQualityValues.Select(x => x.Value).Max().ToString();
                    }));
                    SymbolQualityMin.Invoke(new MethodInvoker(() =>
                    {
                        SymbolQualityMin.Text = SymbolQualityValues.Select(x => x.Value).Min().ToString();
                    }));
                    SymbolQualityAve.Invoke(new MethodInvoker(() =>
                    {
                        SymbolQualityAve.Text = SymbolQualityValues.Select(x => x.Value).Average().ToString();
                    }));

                    // streaming rate stats
                    StreamingRateGauge.Invoke(new MethodInvoker(() =>
                    {
                        if(lastStreamingRateValue > StreamingRateGauge.To)
                        {
                            StreamingRateGauge.To = double.Parse(lastStreamingRateValue.ToString("0.0"));
                        }
                        StreamingRateGauge.Value = lastStreamingRateValue;
                    }));
                    StreamingRateMax.Invoke(new MethodInvoker(() =>
                    {
                        StreamingRateMax.Text = StreamingRateValues.Select(x => x.Value).Max().ToString();
                    }));
                    StreamingRateMin.Invoke(new MethodInvoker(() =>
                    {
                        StreamingRateMin.Text = StreamingRateValues.Select(x => x.Value).Min().ToString();
                    }));
                    StreamingRateAve.Invoke(new MethodInvoker(() =>
                    {
                        StreamingRateAve.Text = StreamingRateValues.Select(x => x.Value).Average().ToString();
                    }));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                await Task.Delay(100);
            }
        }

        private void PauseGraphingButton_Click(object sender, EventArgs e)
        {
            if(Graphing)
            {
                Graphing = false;
                SignalGraph.Invoke(new Action(delegate ()
                {
                    SignalGraph.UpdaterState = UpdaterState.Paused;
                }));
                StreamingRateGraph.Invoke(new Action(delegate ()
                {
                    StreamingRateGraph.UpdaterState = UpdaterState.Paused;
                }));
                PauseGraphingButton.Invoke(new Action(delegate ()
                {
                    PauseGraphingButton.Text = "Start Graphing";
                    PauseGraphingButton.BackColor = System.Drawing.Color.DarkGray;
                }));
            }
            else
            {
                Graphing = true;
                SignalGraph.Invoke(new Action(delegate ()
                {
                    SignalGraph.UpdaterState = UpdaterState.Running;
                }));
                StreamingRateGraph.Invoke(new Action(delegate ()
                {
                    StreamingRateGraph.UpdaterState = UpdaterState.Running;
                }));
                PauseGraphingButton.Invoke(new Action(delegate ()
                {
                    PauseGraphingButton.Text = "Pause Graphing";
                    PauseGraphingButton.BackColor = System.Drawing.Color.LightGreen;
                }));
            }
            
        }

        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            ClearAllValues();
        }

        private void MaxValuesPicker_ValueChanged(object sender, EventArgs e)
        {
            GraphingDurationSeconds = (int)MaxValuesPicker.Value;
        }

        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog()
                {
                    AddExtension = true,
                    Filter = "JSON(*.json) | *.json",
                    FileName = string.Format("{0}{1}{2}-{3}.json",
                    SignalStrengthValues.First().DateTime.ToString("MMddyyHHmmss"),
                    SignalStrengthValues.Last().DateTime.ToString("MMddyyHHmmss"),
                    DeviceID,
                    TunerNumber
                    )
                };

                DialogResult result = saveDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string fileName = saveDialog.FileName;

                    CollectedValues vals = new CollectedValues()
                    {
                        SignalQualityValues = SignalQualityValues,
                        SignalStrengthValues = SignalStrengthValues,
                        SymbolQualityValues = SymbolQualityValues,
                        StreamingRateValues = StreamingRateValues
                    };

                    File.WriteAllText(fileName, JsonConvert.SerializeObject(vals, Formatting.Indented));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
