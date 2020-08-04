using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Bar : SeriesBase
    {
        public override string Type => nameof(Bar).ToLower();

        public bool? RoundCap { get; set; }

        public bool? ShowBackground { get; set; }

        public BackgroundStyle BackgroundStyle { get; set; }


        public UnionType<string, double> BarWidth { get; set; }

        public UnionType<string, double> BarMaxWidth { get; set; }

        public UnionType<string, double> BarMinWidth { get; set; }

        public double? BarMinHeight { get; set; }

        public string BarGap { get; set; }

        public string BarCategoryGap { get; set; }


        public bool? Large { get; set; }

        public double? LargeThreshold { get; set; }

        public double? Progressive { get; set; }

        public double? ProgressiveThreshold { get; set; }

        public ProgressiveChunkMode? ProgressiveChunkMode { get; set; }

   



    }
}
