﻿namespace Tindo.Blazor.ECharts.Options
{
    public abstract class AxisBase
    {
        public bool Show { get; set; } = true;

        public int GridIndex { get; set; } = 0;

        public abstract AxisPosition Postion { get; set; }

        public int Offset { get; set; } = 0;

        public abstract AxisType Type { get; set; }

        public string Name { get; set; }

        public AxisNameLocation NameLocation { get; set; } = AxisNameLocation.End;

        public NameTextStyle NameTextStyle { get; set; }

        public double NameGap { get; set; } = 15;

        public double? NameRotate { get; set; }

        public bool Inverse { get; set; } = false;

        public UnionType<bool, double[], string[]> BoundaryGap { get; set; }

        public UnionType<string, double> Min { get; set; }

        public UnionType<string, double> Max { get; set; }

        public bool Scale { get; set; } = false;

        public int SplitNumber { get; set; } = 5;

        public int MinInterval { get; set; } = 0;

        public int? MaxInterval { get; set; }

        public int? Interval { get; set; }

        public double? LogBase { get; set; } = 10;

        public bool Silent { get; set; } = false;

        public bool TriggerEvent { get; set; } = false;
    }
}