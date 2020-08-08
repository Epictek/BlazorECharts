namespace Tindo.Blazor.ECharts.Options.Series
{
    public class PieSeries : SeriesBase
    {
        public override string Type => "pie";

        public double? HoverOffset { get; set; }

        public SelectedMode? SelectMode { get; set; }

        public double? SelectedOffset { get; set; }

        public bool? Clockwise { get; set; }

        public double? StartAngle { get; set; }

        public double? MinAngle { get; set; }

        public double? MinShowLabelAngle { get; set; }

        public RoseType? RoseType { get; set; }

        public bool? AvoidLabelOverlap { get; set; }

        public bool? StillShowZeroSum { get; set; }

        public UnionType<Align, double> Top { get; set; }

        public UnionType<VerticalAlign, double> Right { get; set; }

        public UnionType<string, double> Width { get; set; }

        public UnionType<string, double> Height { get; set; }

        public LabelLine LabelLine { get; set; }

        public PieEmphasis Emphasis { get; set; }

        public UnionType<double[], string[]> Center { get; set; }

        public UnionType<double, string, object[]> Radius { get; set; }


    }
}
