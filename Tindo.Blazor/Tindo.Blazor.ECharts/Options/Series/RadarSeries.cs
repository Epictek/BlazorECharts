using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class RadarSeries : SeriesBase
    {
        public override string Type => "radar";

        public int? RadarIndex { get; set; }

        public RadarEmphasis Emphasis { get; set; }

    }
}
