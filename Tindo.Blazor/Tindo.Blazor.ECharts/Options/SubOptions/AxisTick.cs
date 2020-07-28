using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class AxisTick
    {
        public bool? Show { get; set; } 

        public bool? AlignWithLabel { get; set; } 

        public UnionType<string, int> Interval { get; set; }

        public bool? Inside { get; set; } 

        public double? Length { get; set; } 

        public LineStyle LineStyle { get; set; }
    }
}
