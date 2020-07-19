using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public abstract class VisualMap
    {
        public abstract string Type { get; }
    }

    public class ContinuousVisualMap : VisualMap
    {
        public override string Type => "continuous";
    }

    public class PiecewiseVisualMap : VisualMap
    {
        public override string Type => "piecewise";

        public bool Show { get; set; }

        public int Dimension { get; set; }


        [JsonIgnore]
        public UnionType<int, Array> SeriesIndex { get; set; }

        [JsonProperty("SeriesIndex")]
        private object SeriesIndexValue => SeriesIndex?.Value;

        public JsonObject[] Pieces { get; set; }




    }



}
