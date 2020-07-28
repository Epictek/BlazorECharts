namespace Tindo.Blazor.ECharts.Options
{
    public class AxisLine
    {
        public bool? Show { get; set; } 

        public bool? OnZero { get; set; } 

        public double? OnZeroAxisIndex { get; set; }

        public UnionType<AxisLineSymbol, AxisLineSymbol[]> Symbol { get; set; }

        public double[] SymbolSize { get; set; }

        public UnionType<double, double[]> SymbolOffset { get; set; }

        public LineStyle LineStyle { get; set; }

    }
}
