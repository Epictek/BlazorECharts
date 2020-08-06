using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Scatter : SeriesBase
    {
        public override string Type => nameof(Scatter).ToLower();

        public int? GeoIndex { get; set; }

        public int? CalendarIndex { get; set; }

        public bool? Large { get; set; }

        public int? LargeThreshold { get; set; }

        public Emphasis Emphasis { get; set; }

        public double? Progressive { get; set; }

        public int? ProgressiveThreshold { get; set; }

    }
}
