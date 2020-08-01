namespace Tindo.Blazor.ECharts.Options.Series
{
    public class SeriesData
    {
        public string Name { get; set; }

        public UnionType<double, double[]> Value { get; set; }

        public SeriesSymbol? Symbol { get; set; }

        public UnionType<double, double[]> SymbolSize { get; set; }

        public double? SymbolRotate { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public object[] SymbolOffset { get; set; }

        public Label Label { get; set; }

        public ItemStyle ItemStyle { get; set; }

        public Emphasis Emphasis { get; set; }

        public Tooltip Tooltip { get; set; }

    }
}
