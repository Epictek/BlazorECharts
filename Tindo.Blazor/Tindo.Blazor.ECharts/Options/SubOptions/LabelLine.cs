using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class LabelLine
    {
        public bool? Show { get; set; }

        public double? Length { get; set; }

        public double? Length2 { get; set; }

        public UnionType<double, bool> Smooth { get; set; }

        public LineStyle LineStyle { get; set; }

    }
}
