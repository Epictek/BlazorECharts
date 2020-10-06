using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public class MarkPoint
    {
        public MarkPointSymbol? Symbol { get; set; }

        public UnionType<double, double[]> SymbolSize { get; set; }

        public double? SymbolRotate { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public object[] SymbolOffset { get; set; }

        public bool? Silent { get; set; }

        public Label Label { get; set; }

        public ItemStyle ItemStyle { get; set; }

        public Emphasis Emphasis { get; set; }

        public MarkPointData[] Data { get; set; }


        public bool? Animation { get; set; }

        public double? AnimationThreshold { get; set; }

        public double? AnimationDuration { get; set; }

        public string AnimationEasing { get; set; }

        public double? AnimationDelay { get; set; }

        public double? AnimationDurationUpdate { get; set; }

        public string AnimationEasingUpdate { get; set; }

        public double? AnimationDelayUpdate { get; set; }
    }
}
