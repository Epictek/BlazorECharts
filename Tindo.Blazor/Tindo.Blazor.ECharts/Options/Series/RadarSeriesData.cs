using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public class RadarSeriesData : SeriesData
    {
        public SeriesSymbol? Symbol { get; set; }

        public double? SymbolSize { get; set; }

        public double? SymbolRotate { get; set; }

        public bool? SymbolKeepAspect { get; set; }

        public object[] SymbolOffset { get; set; }

        public LineStyle LineStyle { get; set; }

        public AreaStyle AreaStyle { get; set; }

        public RadarEmphasis Emphasis { get; set; }



    }
}
