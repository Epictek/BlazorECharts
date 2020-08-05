using System;
using System.Collections.Generic;
using System.Text;
using Tindo.Blazor.ECharts.Options.SubOptions;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class PieSeriesData : SeriesData
    {
        public bool? Selected { get; set; }

        public LabelLine LabelLine { get; set; }

        public PieEmphasis Emphasis { get; set; }

    }
}
