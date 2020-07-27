namespace Tindo.Blazor.ECharts.Options
{
    public class ItemStyle
    {
        public Color Color { get; set; }

        public Color BorderColor { get; set; } = "#000";

        public double BorderWidth { get; set; } = 0;

        public BorderType BorderType { get; set; } = BorderType.Solid;

        public double? ShadowBlur { get; set; }

        public Color ShadowColor { get; set; }

        public double ShadowOffsetX { get; set; } = 0;

        public double ShadowOffsetY { get; set; } = 0;

        public double Opacity { get; set; } = 1.0;
    }
}
