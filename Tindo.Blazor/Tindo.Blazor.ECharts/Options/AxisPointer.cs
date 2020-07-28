using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class AxisPointer
    {
        public bool? Show { get; set; }

        public AxisPointerType Type { get; set; }

        public bool? Snap { get; set; }

        public int? Z { get; set; }

        public Label Label { get; set; }


        public LineStyle LineStyle { get; set; }

        public ShadowStyle ShadowStyle { get; set; }

        public bool?  TriggerTooltip { get; set; }

        public double? Value { get; set; }

        public bool? Status { get; set; }

        public Handle Handle { get; set; }
        public JsonObject Link { get; set; }

        public string TriggerOn { get; set; }
    }
}
