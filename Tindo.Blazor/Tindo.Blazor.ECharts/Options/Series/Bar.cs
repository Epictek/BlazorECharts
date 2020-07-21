using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Bar : SeriesBase
    {
        public override string Type => nameof(Bar).ToLower();

        public BackgroundStyle BackgroundStyle { get; set; }

        public bool? ShowBackground { get; set; }

        [JsonIgnore]
        public UnionType<double, string> BarWidth { get; set; }

        [JsonProperty("BarWidth")]
        private object BarWidthValue => BarWidth?.Value;
    }
}
