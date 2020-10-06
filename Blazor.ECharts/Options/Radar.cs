

namespace Blazor.ECharts.Options
{
    public class Radar
    {
        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public UnionType<string[], double[]> Center { get; set; }

        public UnionType<double, string, object[]> Radius { get; set; }

        public double? StartAngle { get; set; }

        public RadarName Name { get; set; }

        public TextStyle TextStyle { get; set; }

        public double? NameGap { get; set; }

        public double? SplitNumber { get; set; }

        public RadarShape? Shape { get; set; }

        public bool? Scale { get; set; }

        public bool? Silent { get; set; }

        public bool? TriggerEvent { get; set; }

        public AxisLine AxisLine { get; set; }

        public AxisTick AxisTick { get; set; }

        public AxisLabel AxisLabel { get; set; }

        public SplitLine SplitLine { get; set; }

        public SplitArea SplitArea { get; set; }

        public Indicator[] Indicator { get; set; }

    }
}
