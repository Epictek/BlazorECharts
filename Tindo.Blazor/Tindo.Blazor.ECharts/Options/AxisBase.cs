using Tindo.Blazor.ECharts.Options.SubOptions;

namespace Tindo.Blazor.ECharts.Options
{
    public abstract class AxisBase
    {
        public bool? Show { get; set; } 

        public int? GridIndex { get; set; } 

        public abstract AxisPosition? Postion { get; set; }

        public int? Offset { get; set; } 

        public abstract AxisType? Type { get; set; }

        public string Name { get; set; }

        public AxisNameLocation? NameLocation { get; set; }

        public NameTextStyle NameTextStyle { get; set; }

        public double? NameGap { get; set; }

        public double? NameRotate { get; set; }

        public bool? Inverse { get; set; } = false;

        public UnionType<bool, double[], string[], object[]> BoundaryGap { get; set; }

        public UnionType<string, double> Min { get; set; }

        public UnionType<string, double> Max { get; set; }

        public bool? Scale { get; set; } = false;

        public int? SplitNumber { get; set; } 

        public int? MinInterval { get; set; } 

        public int? MaxInterval { get; set; }

        public int? Interval { get; set; }

        public double? LogBase { get; set; } = 10;

        public bool? Silent { get; set; } = false;

        public bool? TriggerEvent { get; set; } = false;

        public AxisLine AxisLine { get; set; }

        public AxisTick AxisTick { get; set; }

        public MinorTick MinorTick { get; set; }

        public AxisLabel AxisLabel { get; set; }

        public SplitLine SplitLine { get; set; }

        public MinorSplitLine MinorSplitLine { get; set; }

        public SplitArea SplitArea { get; set; }

        public AxisPointer AxisPointer { get; set; }

        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public AxisData[] Data { get; set; }
    }
}
