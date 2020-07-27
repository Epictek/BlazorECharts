using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class MarkLineData
    {
        [JsonProperty("0")]
        public MarkLineDataDetial Zero { get; set; }

        [JsonProperty("1")]
        public MarkLineDataDetial One { get; set; }
    }

    public class MarkLineDataDetial
    {
        public MarkLineDataType Type { get; set; }

        public  int? ValueIndex { get; set; }

        public string ValueDim { get; set; }

        public UnionType<double[], string[]> Coord { get; set; }

        public string Name { get; set; }

        public double? X { get; set; }

        public double? Y { get; set; }

        public double? Value { get; set; }

        public MarkLineDataSymbol Symbol { get; set; }

        public UnionType<double, double[]> SymbolSize { get; set; }

        public double? SymbolRotate { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public object[] SymbolOffset { get; set; }

        public LineStyle LineStyle { get; set; }

        public Label Label { get; set; }

        public Emphasis Emphasis { get; set; }
    }
}
