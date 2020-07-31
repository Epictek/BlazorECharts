using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class PageTextStyle
    {
        public Color Color { get; set; }

        public FontStyle? FontStyle { get; set; }

        public FontWeight? FontWeight { get; set; }

        public string FontFamily { get; set; }

        public int? FontSize { get; set; }

        public double? LineHeight { get; set; }

        public UnionType<double, string> Width { get; set; }

        public UnionType<double, string> Height { get; set; }

        public Color TextBorderColor { get; set; }

        public double? TextBorderWidth { get; set; }

        public Color TextShadowColor { get; set; }

        public double? TextShadowBlur { get; set; }

        public double? TextShadowOffsetX { get; set; }

        public double? TextShadowOffsetY { get; set; }

    }
}
