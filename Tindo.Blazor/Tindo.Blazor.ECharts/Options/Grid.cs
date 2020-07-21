using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class Grid
    {
        public bool Show { get; set; } = true;

        [JsonIgnore]
        public UnionType<string, double> Left { get; set; }

        [JsonProperty("left")]
        private object LeftValue => Left?.Value;

        [JsonIgnore]
        public UnionType<string, double> Top { get; set; }

        [JsonProperty("Top")]
        private object TopValue => Top?.Value;


        [JsonIgnore]
        public UnionType<string, double> Right { get; set; }

        [JsonProperty("Right")]
        private object RightValue => Right?.Value;



        [JsonIgnore]
        public UnionType<string, double> Bottom { get; set; }

        [JsonProperty("Bottom")]
        private object BottomValue => Bottom?.Value;


        public bool? ContainLabel { get; set; }

    }
}
