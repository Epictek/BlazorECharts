namespace Tindo.Blazor.ECharts.Options
{
    public class YAxis : AxisBase
    {
        public override AxisPosition Postion { get; set; } = AxisPosition.Left;
        public override AxisType Type { get; set; } = AxisType.Value;
    }
}
