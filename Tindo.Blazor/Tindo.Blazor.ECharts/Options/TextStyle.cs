namespace Tindo.Blazor.ECharts.Options
{
    public class TextStyle
    {
        public Color Color { get; set; } 

        public FontStyle? FontStyle { get; set; }

        public UnionType<int, FontWeight> FontWeight { get; set; } 

        public string FontFamily { get; set; }

        public double? FontSize { get; set; } 

        public double? LineHeight { get; set; }

        public UnionType<string, double> Width { get; set; }

        public UnionType<string, double> Height { get; set; }

        public Color TextBorderColor { get; set; }

        public double? TextBorderWidth { get; set; } 

        public Color TextShadowColor { get; set; } 

        public double? TextShadowBlur { get; set; } 

        public double? TextShadowOffsetX { get; set; }

        public double? TextShadowOffsetY { get; set; }

    }
}
