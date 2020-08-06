namespace Tindo.Blazor.ECharts.Options.Series
{
    public class ScatterSeriesData : SeriesData
    {
        public SeriesSymbol? Symbol { get; set; }

        public UnionType<double, double[]> SymbolSize { get; set; }

        public double? SymbolRotate { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public object[] SymbolOffset { get; set; }

        public Emphasis Emphasis { get; set; }

    }
}
