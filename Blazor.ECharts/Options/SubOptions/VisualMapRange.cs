using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public class VisualMapRange
    {
        public VisualMapRangeSymbol[] Symbol { get; set; }

        public double[] SymbolSize { get; set; }

        public UnionType<Color, Color[]> Color { get; set; }

        public double[] ColorAlpha { get; set; }

        public double[] Opacity { get; set; }

        public double[] ColorLightness { get; set; }

        public double[] ColorSaturation { get; set; }

        public double[] ColorHue { get; set; }

    }
}
