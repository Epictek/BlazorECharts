﻿namespace Blazor.ECharts.Options
{
    public class AxisDataTextStyle : TextStyle
    {
        public Color BackgroundColor { get; set; } 

        public Color BorderColor { get; set; } 

        public double? BorderWidth { get; set; }

        public double? BorderRadius { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public Color ShadowColor { get; set; }

        public double? ShadowBlur { get; set; }

        public double? ShadowOffsetX { get; set; }

        public double? ShadowOffsetY { get; set; }

        public JsonObject Rich { get; set; }
    }
}
