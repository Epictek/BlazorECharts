using System;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Line : SeriesBase
    {
        public string Type => nameof(Line).ToLower();

        public string Name { get; set; }

        public Array Data { get; set; }

        public AreaStyle AreaStyle { get; set; }

        [JsonIgnore]
        public UnionType<bool, double> Smooth { get; set; }

        [JsonProperty("Smooth")]
        private object SmoothValue => Smooth?.Value;


        public string Stack { get; set; }

    }
}
