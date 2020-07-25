using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Pie : SeriesBase
    {
        public override string Type => nameof(Pie).ToString().ToLower();

        [JsonIgnore]
        public UnionType<string, double, Array> Radius { get; set; }

        [JsonProperty("radius")]
        private object RadiusValue => Radius?.Value;

        public bool AvoidLabelOverlap { get; set; } = true;

        public Label Label { get; set; }

        public LabelLine LabelLine { get; set; }

        public Emphasis Emphasis { get; set; }

        public Array Center { get; set; }

    }
}
