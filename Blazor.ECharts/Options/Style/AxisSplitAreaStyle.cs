using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public class AxisSplitAreaStyle : AreaStyle
    {
        public Color[] Color { get; set; } =
           new Color[] { "rgba(250,250,250,0.3)", "rgba(250,250,250,0.3)" };
    }
}
