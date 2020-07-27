

namespace Tindo.Blazor.ECharts.Options
{
    public class Label
    {
        public bool? Show { get; set; }

        public LabelPosition Position { get; set; }

        public double? Distance { get; set; } = 5.0;

        public double? Rotate { get; set; }

        public double[] Offset { get; set; }

        public string Formatter { get; set; }

        public Color Color { get; set; } = "#fff";

        public FontStyle FontStyle { get; set; } = FontStyle.Normal;

        public FontWeight FontWeight { get; set; } = FontWeight.Normal;

        public string FontFamily { get; set; } = "sans-serif";

        public int FontSize { get; set; } = 12;

        public Align Align { get; set; } = Align.Automatic;

        public VerticalAlign VerticalAlign { get; set; } = VerticalAlign.Automatic;

        public double? LineHeight { get; set; }

        public Color BackgroundColor { get; set; } = System.Drawing.Color.Transparent;

        public Color BorderColor { get; set; } = System.Drawing.Color.Transparent;

        public double? BorderWidth { get; set; }

        public UnionType<double, double[]> BorderRadius { get; set; } = 0;

        public UnionType<double, double[]> Padding { get; set; } = 0;

        public Color ShadowColor { get; set; } = System.Drawing.Color.Transparent;

        public double ShadowBlur { get; set; } = 0;

        public double ShadowOffsetX { get; set; } = 0;

        public double ShadowOffsetY { get; set; } = 0;

        public JsonObject Rich { get; set; }
    }
}
