using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class AxisLine
    {
        public bool Show { get; set; }

        public bool OnZero { get; set; }

        public int OnZeroAxisIndex { get; set; }

        public UnionType<string, Array> Symbol { get; set; }

        public Array SymbolSize { get; set; }

        public UnionType<Array, double> SymbolOffset { get; set; }

        public LineStyle LineStyle { get; set; }


    }
}
