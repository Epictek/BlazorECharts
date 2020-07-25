using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class Title
    {
        public bool Show { get; set; } = true;

        public string Text { get; set; }

        public string Subtext { get; set; }

        public TextStyle TextStyle { get; set; }


        [JsonIgnore]
        public UnionType<TextAlign, double> Left { get; set; }

        [JsonProperty("Left")]
        private object LeftValue => Left?.Value;


        [JsonIgnore]
        public UnionType<TextVerticalAlign, double> Top { get; set; }

        [JsonProperty("Top")]
        private object TopValue => Top?.Value;

    }
}
