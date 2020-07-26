using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class AxisTick
    {
        public bool Show { get; set; } = true;

        public bool AlignWithLabel { get; set; } = false;

        public UnionType<string, int> Interval = "auto";

        public bool Inside { get; set; } = false;

        public double Length { get; set; } = 5;

        public LineStyle LineStyle { get; set; }
    }
}
