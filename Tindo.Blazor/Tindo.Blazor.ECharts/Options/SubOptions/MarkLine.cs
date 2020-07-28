namespace Tindo.Blazor.ECharts.Options
{
    public class MarkLine
    {
        public bool? Silent { get; set; }

        public UnionType<MarkPointSymbol, MarkPointSymbol[]>  Symbol { get; set; }

        public UnionType<double, double[]> SymbolSize { get; set; }

        public int? Precision { get; set; }

        public Label Label { get; set; }

        public MarkLineStyle LineStyle { get; set; }

        public Emphasis Emphasis { get; set; }

        public MarkLineData[] Data { get; set; }

        public bool? Animation { get; set; }

        public double? AnimationThreshold { get; set; }

        public double? AnimationDuration { get; set; }

        public string AnimationEasing { get; set; }

        public double? AnimationDelay { get; set; }

        public double? AnimationDurationUpdate { get; set; }

        public string AnimationEasingUpdate { get; set; }

        public double? AnimationDelayUpdate { get; set; }

    }
}
