namespace Tindo.Blazor.ECharts.Options.Series
{
    public abstract class SeriesBase
    {
        public abstract string Type { get; }

        public string Name { get; set; }

        public CoordinateSystem? CoordinateSystem { get; set; }

        public int? XAxisIndex { get; set; }

        public int? YAxisIndex { get; set; }

        public int? PolarIndex { get; set; }

        public SeriesSymbol? Symbol { get; set; }

        public UnionType<double, double[]> SymbolSize { get; set; }

        public double? SymbolRotate { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public object[] SymbolOffset { get; set; }

        public bool? ShowSymbol { get; set; }

        public UnionType<string, bool> ShowAllSymbol { get; set; }

        public bool? HoverAnimation { get; set; }

        public bool? LegendHoverLink { get; set; }

        public string Stack { get; set; }

        public string Cursor { get; set; }

        public bool? ConnectNulls { get; set; }

        public bool? Clip { get; set; }

        public SeriesStep? Step { get; set; }

        public Label Label { get; set; }
        
        public ItemStyle ItemStyle { get; set; }
        
        public LineStyle LineStyle { get; set; }

        public AreaStyle AreaStyle { get; set; }

        public Emphasis Emphasis { get; set; }

        public UnionType<bool, double> Smooth { get; set; }

        public string SmoothMonotone { get; set; }

        public SeriesSampling? Sampling { get; set; }

        public Dimension[] Dimensions { get; set; }

        public JsonObject Encode { get; set; }

        public SeriesLayoutBy SeriesLayoutBy { get; set; }

        public int? DatasetIndex { get; set; }

        public SeriesData[] Data { get; set; }

        public MarkPoint MarkPoint { get; set; }

        public MarkLine MarkLine { get; set; }

        public MarkArea MarkArea { get; set; }

        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public bool? Silent { get; set; }

        public bool? Animation { get; set; }

        public double? AnimationThreshold { get; set; }

        public double? AnimationDuration { get; set; }

        public string AnimationEasing { get; set; }

        public double? AnimationDelay { get; set; }

        public double? AnimationDurationUpdate { get; set; }

        public string AnimationEasingUpdate { get; set; }

        public double? AnimationDelayUpdate { get; set; }

        public Tooltip Tooltip { get; set; }

    }
}
