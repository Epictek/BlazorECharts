using System;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Line : SeriesBase
    {
        public  override string Type => nameof(Line).ToLower();

        public AreaStyle AreaStyle { get; set; }

        public SeriesSymbol? Symbol { get; set; }

        [JsonIgnore]
        public UnionType<bool, double> Smooth { get; set; }

        [JsonProperty("Smooth")]
        private object SmoothValue => Smooth?.Value;

        public string Stack { get; set; }

        public MarkLine MarkLine { get; set; }

        public LineStyle LineStyle { get; set; }
    }
}
