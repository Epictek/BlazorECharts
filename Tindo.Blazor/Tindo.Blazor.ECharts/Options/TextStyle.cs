namespace Tindo.Blazor.ECharts.Options
{
    public class TextStyle
    {
        public Color Color { get; set; } = "#fff";

        public FontStyle FontStyle { get; set; } = FontStyle.Normal;

        public UnionType<int, FontWeight> FontWeight { get; set; } = Options.FontWeight.Normal;

        public string FontFamily { get; set; }

        public double FontSize { get; set; } = 12;

        public double? LineHeight { get; set; }

        public UnionType<string, double> Width { get; set; }

        public UnionType<string, double> Height { get; set; }

        public Color TextBorderColor { get; set; } = System.Drawing.Color.Transparent;

        public double TextBorderWidth { get; set; } = 0.0;

        public Color TextShadowColor { get; set; } = System.Drawing.Color.Transparent;

        public double? TextShadowBlur { get; set; } = 0.0;

        public double? TextShadowOffsetX { get; set; }

        public double? TextShadowOffsetY { get; set; }

    }
}
