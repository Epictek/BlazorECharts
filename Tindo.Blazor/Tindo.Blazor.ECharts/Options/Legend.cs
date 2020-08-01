using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class Legend
    {
        public LegendType? Type { get; set; }

        public bool? Show { get; set; }

        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public UnionType<double, Align> Left { get; set; }

        public UnionType<double, VerticalAlign> Top { get; set; }

        public UnionType<double, string> Right { get; set; }

        public UnionType<double, string> Bottom { get; set; }

        public UnionType<double, string> Width { get; set; }

        public UnionType<double, string> Height { get; set; }

        public Orient? Orient { get; set; }

        public Align? Align { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public double? ItemGap { get; set; }

        public double? ItemWidth { get; set; }

        public double? ItemHeight { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public string Formatter { get; set; }

        public SelectedMode? SelectedMode { get; set; }

        public Color InactiveColor { get; set; }

        public JsonObject Selected { get; set; }

        public TextStyle TextStyle { get; set; }

        public Tooltip Tooltip { get; set; }

        public string Icon { get; set; }

        public LegendData[] Data { get; set; }

        public Color BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public double? BorderRadius { get; set; }

        public double? ShadowBlur { get; set; }

        public Color ShadowColor { get; set; }

        public double? ShadowOffsetX { get; set; }

        public double? ShadowOffsetY { get; set; }

        public int? ScrollDataIndex { get; set; }

        public int? PageButtonItemGap { get; set; }

        public PageButtonPosition? PageButtonPosition { get; set; }

        public string PageFormatter { get; set; }

        public PageIcons PageIcons { get; set; }

        public Color PageIconColor { get; set; }

        public Color PageIconInactiveColor { get; set; }

        public double? PageIconSize { get; set; }

        public PageTextStyle PageTextStyle { get; set; }

        public bool Animation { get; set; }

        public double? AnimationDurationUpdate { get; set; }

        public UnionType<bool, JsonObject[]> Selector { get; set; }

        public SelectorLabel SelectorLabel { get; set; }

        public LegendEmphasis Emphasis { get; set; }

        public LegendSelectorPosition? SelectorPosition { get; set; }

        public double? SelectorItemGap { get; set; }

        public double? SelectorButtonGap { get; set; }
    }
}
