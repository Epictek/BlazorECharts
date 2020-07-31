using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class Grid
    {
        public bool? Show { get; set; }

        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public UnionType<double, string, GridPosition> Left { get; set; }

        public UnionType<double, string, GridPosition> Top { get; set; }

        public UnionType<double, string> Bottom { get; set; }

        public UnionType<double, string> Right { get; set; }

        public UnionType<double, string> Width { get; set; }

        public UnionType<double, string> Height { get; set; }

        public bool? ContainLabel { get; set; }

        public Color BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public double? ShadowBlur { get; set; }

        public Color ShadowColor { get; set; }

        public double? ShadowOffsetY { get; set; }

        public double? ShadowOffsetX { get; set; }

        public Tooltip Tooltip { get; set; }
    }
}
