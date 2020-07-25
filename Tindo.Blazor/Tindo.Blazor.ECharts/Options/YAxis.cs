﻿using System;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class YAxis
    {
        public bool? Show { get; set; } = true;

        public AxisType Type { get; set; } = AxisType.Value;

        [JsonIgnore]
        public UnionType<Boolean, Array> BoundaryGap { get; set; }

        [JsonProperty("BoundaryGap")]
        private object BoundaryGapValue => BoundaryGap?.Value;

        public AxisTick AxisTick { get; set; }

        public Array Data { get; set; }

        public static YAxis Empty => new EmptyYAxis();
    }

    [JsonConverter(typeof(EmptyConverter))]
    internal class EmptyYAxis : YAxis
    {

    }
}
