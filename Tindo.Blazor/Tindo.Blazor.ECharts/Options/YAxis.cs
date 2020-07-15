using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class YAxis
    {
        public string Id { get; set; }

        public bool Show { get; set; }

        public double GridIndex { get; set; }

        public Position Position { get; set; }

        public double Offset { get; set; }

        public Categroy Type { get; set; }

        public string Name { get; set; }

        public NameLocation NameLocation { get; set; }

        public double NameGap { get; set; }

        public double NameRotate { get; set; }

        public bool Inverse { get; set; }

        public UnionType<bool, Array> BoundaryGap { get; set; }

        //todo
    }
}
