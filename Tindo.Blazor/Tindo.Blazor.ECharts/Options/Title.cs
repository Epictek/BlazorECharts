namespace Tindo.Blazor.ECharts.Options
{
    public class Title
    {
        public bool? Show { get; set; }

        public string Text { get; set; }

        public string Link { get; set; }

        public TitleTarget? Target { get; set; }

        public TextStyle TextStyle { get; set; }

        public string Subtext { get; set; }

        public string Sublink { get; set; }

        public TitleTarget? Subtarget { get; set; }

        public SubtextStyle SubtextStyle { get; set; }

        public Align? TextAlign { get; set; }

        public VerticalAlign? TextVeritcalAlign { get; set; }

        public bool? TriggerEvent { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public double? ItemGap { get; set; }

        public int? Zlevel { get; set; }

        public UnionType<double, Align> Left { get; set; }

        public UnionType<double, VerticalAlign> Top { get; set; }

        public UnionType<double, string> Right { get; set; }

        public UnionType<double, string> Bottom { get; set; }

        public Color BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public double? BorderRadius { get; set; }

        public double? ShadowBlur { get; set; }

        public Color ShadowColor { get; set; }

        public double? ShadowOffsetX { get; set; }

        public double? ShadowOffsetY { get; set; }

    }
}
