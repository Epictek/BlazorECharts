using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Scatter : SeriesBase
    {
        public override string Type => nameof(Scatter).ToString().ToLower();


        [JsonIgnore]
        public UnionType<double, Array> SymbolSize { get; set; }

        [JsonProperty("SymbolSize")]
        private object SymbolSizeValue => SymbolSize?.Value;

    }
}
