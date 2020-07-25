namespace Tindo.Blazor.ECharts.Options
{
    public class Tooltip
    {
        public bool? Show { get; set; } = true;

        public Trigger? Trigger { get; set; }

        public AxisPointer AxisPointer { get; set; }

        public string Formatter { get; set; }
    }

}
