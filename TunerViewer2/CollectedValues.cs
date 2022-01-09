using LiveCharts;

namespace TunerViewer2
{
    public class CollectedValues
    {
        public ChartValues<MeasureModel> StreamingRateValues { get; set; }
        public ChartValues<MeasureModel> SignalStrengthValues { get; set; }
        public ChartValues<MeasureModel> SignalQualityValues { get; set; }
        public ChartValues<MeasureModel> SymbolQualityValues { get; set; }
    }
}
