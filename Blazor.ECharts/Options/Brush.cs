using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public class Brush
    {
        public string Id { get; set; }
        public string[] Toolbox { get; set; }
        public UnionType<int[], string> BrushLink { get; set; }

        public UnionType<int[], int, string> SeriesIndex { get; set; }

        public UnionType<int[], int, string> GeoIndex { get; set; }

        public UnionType<int[], int, string> XAxisIndex { get; set; }
        public UnionType<int[], int, string> YAxisIndex { get; set; }
        public string BrushMode { get; set; }
        public string BrushType { get; set; }

        public bool Transformable { get; set; }

        public object BrushStyle { get; set; }

        public string ThrottleType { get; set; }

        public int ThrottleDelay { get; set; }

        public object OutOfBrush { get; set; }

        public object InBrush { get; set; }

        public int Z { get; set; }
    }
}