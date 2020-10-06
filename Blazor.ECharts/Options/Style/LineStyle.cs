namespace Blazor.ECharts.Options
{
    public class LineStyle
    {
        public Color Color { get; set; } 

        public double? Width { get; set; }

        public LineStyleType? Type { get; set; }

        public double? ShadowBlur { get; set; }

        public Color ShadowColor { get; set; }

        public double? ShadowOffsetX { get; set; }

        public double? ShadowOffsetY { get; set; }

        public double? Opacity { get; set; }
        
        public bool? Smooth { get; set; }
    }
}
