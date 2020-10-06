using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public class MarkPointData
    {
        public string Name { get; set; }

        public MarkPointDataType Type { get; set; }

        public int? ValueIndex { get; set; }

        public string ValueDim { get; set; }

        public object[] Coord { get; set; }

        public int? X { get; set; }

        public int? Y { get; set; }

        public double Value { get; set; }

        public MarkPointSymbol Symbol { get; set; }

        public UnionType<double, double[]> SymbolSize { get; set; }

        public double? SymbolRotate { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public object[] SymbolOffset { get; set; }


    }
}
