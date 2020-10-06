

namespace Blazor.ECharts.Options
{
    public class Label
    {
        public bool? Show { get; set; }

        public LabelPosition Position { get; set; }

        public double? Distance { get; set; } 

        public double? Rotate { get; set; }

        public double[] Offset { get; set; }

        public string Formatter { get; set; }

        public Color Color { get; set; }

        public FontStyle? FontStyle { get; set; } 

        public FontWeight? FontWeight { get; set; } 

        public string FontFamily { get; set; }

        public int? FontSize { get; set; } 

        public Align? Align { get; set; } 

        public VerticalAlign? VerticalAlign { get; set; } 

        public double? LineHeight { get; set; }

        public Color BackgroundColor { get; set; } 

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public UnionType<double, double[]> BorderRadius { get; set; } 

        public UnionType<double, double[]> Padding { get; set; }

        public Color ShadowColor { get; set; } 

        public double? ShadowBlur { get; set; } 

        public double? ShadowOffsetX { get; set; } 

        public double? ShadowOffsetY { get; set; }

        public JsonObject Rich { get; set; }
    }
}
