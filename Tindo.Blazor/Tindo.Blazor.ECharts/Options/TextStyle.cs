using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{

    public class TextStyle
    {
        public string Color { get; set; }

        public FontStyle? FontStyle { get; set; }

        public UnionType<FontWeight,int> FontWeight { get; set; }

        public string FontFamily { get; set; }

        public int? FontSize { get; set; }

        public int? LightHeight { get; set; }

        public UnionType<int, string> Width { get; set; }

        public UnionType<int, string> Height { get; set; }

        public string BackgroundColor { get; set; }

        public double? BorderWidth { get; set; }


        [JsonIgnore]
        public UnionType<double, Array> BorderRadius { get; set; }

        [JsonProperty("BorderRadius")]
        private object BorderRadiusValue => BorderRadius?.Value;


        [JsonIgnore]
        public UnionType<double, Array> Padding { get; set; }

        [JsonProperty("Padding")]
        private object PaddingValue => Padding?.Value;

    }
}
