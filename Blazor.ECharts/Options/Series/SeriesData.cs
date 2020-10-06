namespace Blazor.ECharts.Options.Series
{
    public class SeriesData
    {
        public string Name { get; set; }

        public UnionType<double, double[], object[]> Value { get; set; }

        public Label Label { get; set; }

        public ItemStyle ItemStyle { get; set; }

        public Tooltip Tooltip { get; set; }

    }
}
