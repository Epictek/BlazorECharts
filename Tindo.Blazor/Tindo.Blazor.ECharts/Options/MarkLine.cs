using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class MarkLine
    {

        [JsonIgnore]
        public UnionType<string, Array> Symbol { get; set; }

        [JsonProperty("Symbol")]
        private object SymbolValue => Symbol?.Value;

        public MarkLineLabel Label { get; set; }

        public JsonObject[] Data { get; set; }

    }
}
