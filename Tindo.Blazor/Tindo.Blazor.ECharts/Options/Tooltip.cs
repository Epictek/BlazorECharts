namespace Tindo.Blazor.ECharts.Options
{
    public class Tooltip
    {
        public bool Show { get; set; } = true;

        public Trigger Trigger { get; set; } = Trigger.Item;

        public AxisPointer AxisPointer { get; set; }
    }
}
