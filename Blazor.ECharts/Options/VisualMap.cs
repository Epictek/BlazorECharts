using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Blazor.ECharts.Options.SubOptions;

namespace Blazor.ECharts.Options
{
    public abstract class VisualMap
    {
        public abstract string Type { get; set; }

    }

    public class ContinuousVisualMap : VisualMap
    {
        public override string Type { get; set; } = "continuous";

        public double? Min { get; set; }

        public double? Max { get; set; }

        public double[] Range { get; set; }

        public bool? Calculable { get; set; }

        public bool? Realtime { get; set; }

        public bool? Inverse { get; set; }


        public int? Precision { get; set; }

        public double? ItemWidth { get; set; }

        public double? ItemHeight { get; set; }

        public VisualMapAlign? Align { get; set; }

        public string[] Text { get; set; }

        public double? TextGap { get; set; }

        public bool? Show { get; set; }


        public int[][] Dimension { get; set; }

        public UnionType<int, int[]> SeriesIndex { get; set; }

        public bool? HoverLink { get; set; }

        public VisualMapRange InRange { get; set; }

        public VisualMapRange OutOfRange { get; set; }

        public VisualMapController Controller { get; set; }

        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public UnionType<Align, double> Left { get; set; }


        public UnionType<VerticalAlign, double> Top { get; set; }

        public UnionType<string, double> Right { get; set; }

        public UnionType<string, double> Bottom { get; set; }

        public Orient Orient { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public Color BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public Color[] Color { get; set; }

        public TextStyle TextStyle { get; set; }

        public string Formatter { get; set; }
    }


    public class PiecewiseVisualMap : VisualMap
    {
        public override string Type { get; set; } = "piecewise";

        public int? SplitNumber { get; set; }

        public Piece[] Pieces { get; set; }

        public string[] Categories { get; set; }

        public double? Min { get; set; }

        public double? Max { get; set; }

        public bool? MinOpen { get; set; }

        public bool? MaxOpen { get; set; }

        public SelectedMode? SelectedMode { get; set; }

        public bool? Inverse { get; set; }

        public double? Precision { get; set; }

        public double? ItemWidth { get; set; }

        public double? ItemHeight { get; set; }

        public Align Align { get; set; }

        public string[] Text { get; set; }

        public double? TextGap { get; set; }

        public bool? ShowLabel { get; set; }

        public double? ItemGap { get; set; }

        public VisualMapRangeSymbol? ItemSymbol { get; set; }

        public bool? Show { get; set; }

        public int[][] Dimension { get; set; }

        public UnionType<int, int[]> SeriesIndex { get; set; }

        public bool? HoverLink { get; set; }

        public VisualMapRange InRange { get; set; }

        public VisualMapRange OutOfRange { get; set; }

        public VisualMapController Controller { get; set; }

        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public UnionType<Align, double> Left { get; set; }


        public UnionType<VerticalAlign, double> Top { get; set; }

        public UnionType<string, double> Right { get; set; }

        public UnionType<string, double> Bottom { get; set; }

        public Orient Orient { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public Color BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public Color[] Color { get; set; }

        public TextStyle TextStyle { get; set; }

        public string Formatter { get; set; }

    }
}
