using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class AreaStyle
    {
        public Color[] Colr { get; set; } =
            new Color[] { "rgba(250,250,250,0.3)", "rgba(250,250,250,0.3)" };

        public double? ShadowBlur { get; set; }

        public Color ShadowColor { get; set; }

        public double ShadowOffsetX { get; set; } = 0.0;

        public double ShadowOffsetY { get; set; } = 0.0;

        public double Opacity { get; set; } = 1;

    }
}
