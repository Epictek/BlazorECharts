using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public abstract class DateLabel
    {
        public bool? Show { get; set; }

        public double? Margin { get; set; }

        public DateLabelPosition? Position { get; set; }

        public string Formatter { get; set; }

        public Color Color { get; set; }

        public FontStyle? FontStyle { get; set; }

        public UnionType<FontWeight, double> FontWeight { get; set; }

        public string FontFamily { get; set; }

        public double? FontSize { get; set; }

        public Align? Align { get; set; }

        public VerticalAlign? VerticalAlign { get; set; }

        public double? LineHeight { get; set; }

        public Color BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public UnionType<double, double[]> BorderRadius { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public Color ShadowColor { get; set; }

        public double? ShadowBlur { get; set; }

        public double? ShadowOffsetX { get; set; }

        public double? ShadowOffsetY { get; set; }

        public UnionType<string, double> Width { get; set; }

        public UnionType<string, double> Height { get; set; }

        public Color TextBorderColor { get; set; }

        public double? TextBorderWidth { get; set; }

        public Color TextShadowColor { get; set; }

        public double? TextShadowBlur { get; set; }

        public double? TextShadowOffsetX { get; set; }

        public double? TextShadowOffsetY { get; set; }

        public JsonObject Rich { get; set; }

    }

    public class DayLabel : DateLabel
    {
        public int? FirstDay { get; set; }

        public UnionType<string, string[]> NameMap { get; set; }

    }

    public class MonthLabel : DateLabel
    {

    }

    public class YearLabel : DateLabel
    {

    }
}
