using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.API
{
    public class LoadingOpts
    {
        public string? Text { get; set; }
        public Color? Color { get; set; }
        public Color? TextColor { get; set; }
        public Color? MaskColor { get; set; }
        public int? Zlevel { get; set; }
        public double? FontSize { get; set; }
        public bool? ShowSpinner { get; set; }
        public int? SpinnerRadius { get; set; } 
        public double? LineWidth { get; set; }
    }
}
