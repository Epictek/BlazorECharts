using System;

namespace Tindo.Blazor.ECharts.Options
{
    public class XAxis
    {
        public string Id { get; set; }

        public bool Show { get; set; }

        public int GridIndex { get; set; }

        public Position Position { get; set; }

        public int Offset { get; set; }

        public Categroy Type { get; set; }

        public string Name { get; set; }

        public NameLocation NameLocation { get; set; }

        public TextStyle NameTextStyle { get; set; }

        public int NameGap { get; set; }

        public double NameRotate { get; set; }

        public bool Inverse { get; set; }

        public UnionType<bool, Array> BoundaryGap { get; set; }

        public UnionType<double, string> Min { get; set; }

        public UnionType<double, string> Max { get; set; }

        public bool Scale { get; set; }

        public int SplitNumber { get; set; }

        public double MinInterval { get; set; }

        public double MaxInterval { get; set; }

        public double Interval { get; set; }

        public double LogBase { get; set; }

        public bool Silent { get; set; }

        public bool TriggerEvent { get; set; }

        public AxisLine AxisLine { get; set; }

        public AxisTick AxisTick { get; set; }

        public AxisLabel AxisLabel { get; set; }

        public Array Data { get; set; }   
    }
}
