using Newtonsoft.Json;
using System;

namespace Tindo.Blazor.ECharts.Options
{
    public class Label
    {
        public bool? Show { get; set; }

        public string BackgroundColor { get; set; }

        [JsonIgnore]
        public UnionType<LabelPosition, Array> Position { get; set; }

        [JsonProperty("position")]
        private object PositionValue => Position?.Value;

        public string FontFamily { get; set; } = "sans-serif";

        public int FontSize { get; set; } = 12;

        public FontWeight FontWeight { get; set; } = FontWeight.Normal;
    }
}
