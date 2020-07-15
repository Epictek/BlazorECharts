using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class AxisLabel
    {
        public bool Show { get; set; }

        public int Interval { get; set; }

        public double Rotate { get; set; }

        public double Margin { get; set; }

        public bool? ShowMinLabel { get; set; }

        public bool? ShowMaxLabel { get; set; }

        public string Color { get; set; }

        public FontStyle FontStyle { get; set; }

        public UnionType<FontWeight, int> FontWeight { get; set; }

        public string FontFamily { get; set; }

        public TextAlign Align { get; set; }

        public TextVerticalAlign VertialAlign { get; set; }

        public int LineHeight { get; set; }

        public string BackgroundColor { get; set; }

        public string BorderColor { get; set; }

        public double BorderWidth { get; set; }

        public UnionType<double, Array> BorderRadius { get; set; }

        public UnionType<double, Array> Padding { get; set; }

        public string ShadowColor { get; set; }

        public double ShadowBlur { get; set; }

        public double ShadowOffsetX { get; set; }

        public double ShadowOffsetY { get; set; }

        public UnionType<double, string> Width { get; set; }

        public UnionType<double, string> Height { get; set; }

        public string TextBorderColor { get; set; }

        public double TextBorderWidth { get; set; }

        public string TextShadowColor { get; set; }

        public double TextShadowBlur { get; set; }

        public double TextShadowOffsetX { get; set; }

        public double TextShadowOffsetY { get; set; }


    }
}
