using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class AngleAxis
    {
        public AxisType Type { get; set; } = AxisType.Category;

        public Array Data { get; set; }
    }
}
