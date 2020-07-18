using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Tindo.Blazor.ECharts.Options.Enums;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class AreaStyle
    {
        public string Color { get; set; }

        public Origin Origin { get; set; } = Origin.Auto;

        public double ShadowBlur { get; set; }

        public string ShadowColor { get; set; }

        public double ShadowOffsetX { get; set; }

        public double ShadowOffsetY { get; set; }

        [Range(0, 1.0, ErrorMessage ="Opacity should be between 0 to 1")]
        public double Opacity { get; set; }

        private static AreaStyle empty = new AreaStyle();

        public static AreaStyle Empty => AreaStyle.empty;
    }
}
