using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class SplitLine
    {
        public bool Show { get; set; } = true;

        public UnionType<string, int> Interval { get; set; } = "auto";

        public LineStyle LineStyle { get; set; }

    }
}
