using Blazor.ECharts.Options.Series;

namespace Blazor.ECharts.Options
{
    public class Option
    {
        public UnionType<Title, Title[]> Title { get; set; }

        public Legend Legend { get; set; }

        public UnionType<Grid, Grid[]> Grid { get; set; }

        public UnionType<XAxis, XAxis[]> XAxis { get; set; }

        public UnionType<YAxis, YAxis[]> YAxis { get; set; }

        public Polar Polar { get; set; }

        public RadiusAxis RadiusAxis { get; set; }

        public AngleAxis AngleAxis { get; set; }

        public Radar Radar { get; set; }

        public DataZoom[] DataZoom { get; set; }

        public VisualMap[] VisualMap { get; set; }

        public Tooltip Tooltip { get; set; }

        public AxisPointer AxisPointer { get; set; }

        public Toolbox Toolbox { get; set; }

        public Brush Brush { get; set; }

        public Geo Geo { get; set; }

        public Parallel Parallel { get; set; }

        public ParallelAxis ParallelAxis { get; set; }

        public UnionType<SingleAxis, SingleAxis[]> SingleAxis { get; set; }

        public Timeline Timeline { get; set; }

        public UnionType<Graphic, Graphic[]> Graphic { get; set; }

        public UnionType<Calendar, Calendar[]> Calendar { get; set; }

        public Dataset Dataset { get; set; }

        public Aria Aria { get; set; }

        public SeriesBase[] Series { get; set; }

        public string[] Color { get; set; }

        public Color BackgroundColor { get; set; }

        public TextStyle TextStyle { get; set; }

        public bool? Animation { get; set; }

        public double? AnimationThreshold { get; set; }

        public double? AnimationDuration { get; set; }

        public string AnimationEasing { get; set; }

        public double? AnimationDelay { get; set; }

        public double? AnimationDurationUpdate { get; set; }

        public string AnimationEasingUpdate { get; set; }

        public double? AnimationDelayUpdate { get; set; }

        public BlendMode? BlendMode { get; set; }

        public double? HoverLayerThreshold { get; set; }

        public bool? UseUTC { get; set; }
    }
}
