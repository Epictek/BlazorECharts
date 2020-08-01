using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class MarkAreaData
    {

    }

    public class MarkAreaDataDetail
    {
        public MarkAreaDataType Type { get; set; }

        public int? ValueIndex { get; set; }

        public string ValueDim { get; set; }

        public UnionType<double[], double[]> Coord { get; set; }

        public string  Name { get; set; }

        public double? X { get; set; }

        public double? Y { get; set; }

        public double? Value { get; set; }

        public ItemStyle ItemStyle { get; set; }

        public Label Label { get; set; }

        public Emphasis Emphasis { get; set; }
    }
}
