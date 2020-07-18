using System;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class XAxis
    {
        public bool Show { get; set; } = true;

        public AxisType Type { get; set; } = AxisType.Category;

        [JsonIgnore]
        public UnionType<bool, Array> BoundaryGap { get; set; }

        [JsonProperty("boundaryGap")]
        private object BoundaryGapValue => this.BoundaryGap?.Value;

        public Array Data { get; set; }
    }
}
