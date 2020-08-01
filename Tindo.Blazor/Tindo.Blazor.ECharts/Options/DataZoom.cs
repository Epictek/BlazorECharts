using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public abstract class DataZoom
    {
        public abstract string Type { get; }


        public UnionType<int, int[]> XAxisIndex { get; set; }

        public UnionType<int, int[]> YAxisIndex { get; set; }

        public UnionType<int, int[]> RadiusAxisIndex { get; set; }

        public UnionType<int, int[]> AngleAxisIndex { get; set; }

        public FilterMode? FilterMode { get; set; }

        public double? Start { get; set; }

        public double? End { get; set; }

        public UnionType<double, string> StartValue { get; set; }

        public UnionType<double, string> EndValue { get; set; }

        public double? MinSpan { get; set; }

        public double? MaxSpan { get; set; }

        public UnionType<double, string> MinvalueSpan { get; set; }

        public UnionType<double, string> MaxValueSpan { get; set; }

        public Orient? Orient { get; set; }

        public bool? ZoomLock { get; set; }

        public double? Throttle { get; set; }


        public RangeMode[] RangeMode { get; set; }
    }

    public class InsideDataZoom : DataZoom
    {
        public override string Type { get; } = "inside";

        public bool? Disabled { get; set; }

        public  bool? Show { get; set; }

        public UnionType<Key, bool> ZoomOnMouseWheel { get; set; }

        public UnionType<Key, bool> MoveOnMouseMove { get; set; }

        public UnionType<Key, bool> MoveOnMouseWheel { get; set; }

        public bool? PreventDefaultMouseMove { get; set; }

    }

    public class SliderDataZoom : DataZoom
    {
        public override string Type { get; } = "slider";

        public bool? Show { get; set; }

        public Color BackgroundColor { get; set; }

        public DataBackground DataBackground { get; set; }

        public Color FillColor { get; set; }

        public Color BorderColor { get; set; }

        public string HandleIcon { get; set; }

        public UnionType<string, double> HandleSize { get; set; }

        public HandleStyle HandleStyle { get; set; }

        public UnionType<double, string> LabelPrecision { get; set; }

        public string LabelFormatter { get; set; }

        public bool? ShowDetail { get; set; }

        public string ShowDataShadow { get; set; }

        public bool? Realtime { get; set; }

        public TextStyle TextStyle { get; set; }

        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public UnionType<double, Align> Left { get; set; }

        public UnionType<double, VerticalAlign> Top { get; set; }

        public UnionType<string, double> Right { get; set; }

        public UnionType<string, double> Bottom { get; set; }

    }
}
