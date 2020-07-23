using Newtonsoft.Json;
using System;

namespace Tindo.Blazor.ECharts.Options
{
    public class Legend
    {
        public LegendType  Type { get; set; }

        public Array Data { get; set; }

        public bool? Show { get; set; }

        public Orient Orient { get; set; }

        [JsonIgnore]
        public UnionType<TextAlign, double> Left { get; set; }

        [JsonProperty("left")]
        public object LeftValue => Left?.Value;
    }
}
