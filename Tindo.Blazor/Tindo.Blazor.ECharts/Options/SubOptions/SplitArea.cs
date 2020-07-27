namespace Tindo.Blazor.ECharts.Options
{
    public class SplitArea
    {
        public UnionType<int, string> Interval { get; set; } = "auto";

        public bool? Show { get; set; }

        public AxisSplitAreaStyle AreaStyle { get; set; }

    }
}
