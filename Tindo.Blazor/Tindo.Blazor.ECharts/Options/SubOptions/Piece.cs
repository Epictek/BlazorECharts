using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class Piece
    {
        public double? Min { get; set; }
        public double? Max { get; set; }

        public double? Value { get; set; }

        public double? Lt { get; set; }

        public double? Gt { get; set; }

        public double? Lte { get; set; }

        public double? Gte { get; set; }

        public string Label { get; set; }

        public VisualMapRangeSymbol Symbol { get; set; }
        public double? SymbolSize { get; set; }

        public Color Color { get; set; }

        public double? ColorAlpha { get; set; }

        public double? Opacity { get; set; }

        public double? ColorLightness { get; set; }

        public double? ColorSaturation { get; set; }

        public double? ColorHue { get; set; }
    }
}
