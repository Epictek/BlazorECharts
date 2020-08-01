using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class HandleStyle
    {
        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public BorderType? BorderType { get; set; }


        public double? ShadowBlur { get; set; }

        public Color ShadowColor { get; set; }

        public double? ShadowOffsetX { get; set; }

        public double? ShadowOffsetY { get; set; }

        public double? Opacity { get; set; }
    }
}
