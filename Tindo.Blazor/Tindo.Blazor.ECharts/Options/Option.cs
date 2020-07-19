using System.Reflection;
using Newtonsoft.Json;
using Tindo.Blazor.ECharts.Options.Series;

namespace Tindo.Blazor.ECharts.Options
{
    public class Option
    {
        public Title Title { get; set; }

        public Tooltip Tooltip { get; set; }

        public Legend Legend { get; set; }

        public Grid Grid { get; set; }

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
