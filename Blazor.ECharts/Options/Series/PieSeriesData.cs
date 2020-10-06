using System;
using System.Collections.Generic;
using System.Text;
using Blazor.ECharts.Options.SubOptions;

namespace Blazor.ECharts.Options.Series
{
    public class PieSeriesData : SeriesData
    {
        public bool? Selected { get; set; }

        public LabelLine LabelLine { get; set; }

        public PieEmphasis Emphasis { get; set; }

    }
}
