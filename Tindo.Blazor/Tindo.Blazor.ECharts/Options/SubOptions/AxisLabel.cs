using System;
using System.Collections.Generic;
using System.Text;
using Tindo.Blazor.ECharts.Options.Enum;

namespace Tindo.Blazor.ECharts.Options
{
    public class AxisLabel
    {
        public bool Show { get; set; } = true;

        public UnionType<string, int> Interval { get; set; } = "auto";

        public bool Inside { get; set; } = false;

        public double Rotate { get; set; } = 0.0;

        public double Margin { get; set; } = 8.0;

        public string Formatter { get; set; }

        public bool? ShowMinLabel { get; set; }

        public bool? ShowMaxLabel { get; set; }

        public Color Color { get; set; }

        public FontStyle FontStyle { get; set; } = FontStyle.Normal;

        public FontWeight FontWeight { get; set; } = FontWeight.Normal;

        public string FontFamily { get; set; } = "sans-family";

        public int FontSize { get; set; } = 12;

        public Align Align { get; set; } = Align.Automatic;

        public VerticalAlign VerticalAlign { get; set; } = VerticalAlign.Automatic;

        public double? LineHeight { get; set; }

        public Color BackgroundColor { get; set; } = System.Drawing.Color.Transparent;

        public Color BorderColor { get; set; } = System.Drawing.Color.Transparent;

        public double BorderWidth { get; set; } = 0;

        public double BorderRadius { get; set; } = 0;

        public UnionType<double, double[]> Padding { get; set; }

        public Color ShadowColor { get; set; } = System.Drawing.Color.Transparent;

        public double ShadowBlur { get; set; } = 0.0;

        public double ShadowOffsetX { get; set; } = 0.0;

        public double ShadowOffsetY { get; set; } = 0.0;

        public UnionType<string, double> Width { get; set; }

        public UnionType<string, double> Height { get; set; }


        public Color TextBorderColor { get; set; } = System.Drawing.Color.Transparent;

        public double TextBorderWidth { get; set; } = 0.0;

        public Color TextShadowColor { get; set; } = System.Drawing.Color.Transparent;

        public double? TextShadowBlur { get; set; } = 0.0;

        public double TextShadowOffsetX { get; set; } = 0.0;

        public double TextShadowOffsetY { get; set; } = 0.0;
    }
}
