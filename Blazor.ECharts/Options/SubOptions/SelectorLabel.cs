using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public class SelectorLabel
    {
        public bool? Show { get; set; }

        public double? Distance { get; set; }

        public double? Rotate { get; set; }

        public double[] Offset { get; set; }

        public Color Color { get; set; }

        public FontStyle? FontStyle { get; set; }

        public UnionType<int, FontWeight> FontWeight { get; set; }

        public string FontFamily { get; set; }

        public double? FontSize { get; set; }

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

        public UnionType<double, string> Width { get; set; }

        public UnionType<double, string> Height { get; set; }

        public JsonObject Rich { get; set; }

        public LegendSelectorPosition? SelectorPosition { get; set; }

        public int? SelectorItemGap { get; set; }

        public int? SelectorButtonGap { get; set; }

    }
}
