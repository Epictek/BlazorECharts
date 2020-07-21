using Newtonsoft.Json;
using System;
using Tindo.Blazor.ECharts.Options.Series;

namespace Tindo.Blazor.ECharts.Options
{
    public class Option
    {
        public Title Title { get; set; }

        public Tooltip Tooltip { get; set; }

        public Legend Legend { get; set; }

        public Grid Grid { get; set; }

        public Array Color { get; set; } = new string[] { "#c23531", "#2f4554", "#61a0a8", "#d48265", "#91c7ae", "#749f83", "#ca8622", "#bda29a", "#6e7074", "#546570", "#c4ccd3" };

        [JsonIgnore]
        public UnionType<XAxis, XAxis[]>  XAxis { get; set; }

        [JsonProperty("XAxis")]
        public object XAxisValue => XAxis?.Value;

        [JsonIgnore]
        public UnionType<YAxis, YAxis[]> YAxis { get; set; }

        [JsonProperty("YAxis")]
        public object YAxisValue => YAxis?.Value;

        public SeriesBase[] Series { get; set; }

        public VisualMap VisualMap { get; set; }
    }
}
