using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class RadiusAxis
    {
        public int? PolarIndex { get; set; }

        public AxisType Type { get; set; }

        public string Name { get; set; }

        public AxisNameLocation NameLocation { get; set; }

        public NameTextStyle NameTextStyle { get; set; }

        public double? NameGap { get; set; }

        public double? NameRotate { get; set; }

        public bool? Inverse { get; set; }
        public UnionType<bool, string[]> BoundaryGap { get; set; }

        public UnionType<double, string> Min { get; set; }

        public UnionType<double, string> Max { get; set; }

        public bool? Scale { get; set; }

        public int? SplitNumber { get; set; }

        public double? MinInterval { get; set; }

        public double? MaxInterval { get; set; }

        public double? Interval { get; set; }

        public double? LogBase { get; set; }

        public bool? Silent { get; set; }

        public bool? TriggerEvent { get; set; }

        public AxisLine AxisLine { get; set; }

        public MinorTick MinorTick { get; set; }

        public AxisLabel AxisLabel { get; set; }


        public SplitLine SplitLine { get; set; }

        public MinorSplitLine MinorSplitLine { get; set; }

        public SplitArea SplitArea { get; set; }

        public AxisData[] Data { get; set; }

        public AxisPointer AxisPointer { get; set; }

        public int? ZLevel { get; set; }

        public int? Z { get; set; }
    }
}
