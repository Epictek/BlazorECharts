using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.ECharts.Options
{
    public class Tooltip
    {
        public bool? Show { get; set; }

        public TooltipTrigger? Trigger { get; set; }

        public AxisPointer AxisPointer { get; set; }

        public bool? ShowContent { get; set; }

        public bool? AlwaysShowContent { get; set; }

        public string TriggerOn { get; set; }

        public double? ShowDelay { get; set; }

        public double? HideDelay { get; set; }

        public bool? Enterable { get; set; }

        public TooltipRenderMode? RenderMode { get; set; }

        public bool? Confine { get; set; }
        public bool? AppendToBody { get; set; }

        public double? TransitionDuration { get; set; }

        public UnionType<TooltipPosition, double[], string[]> Position { get; set; }

        public object Formatter { get; set; }

        public  Color  BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public TextStyle TextStyle { get; set; }

        public string ExtraCssText { get; set; }
    }
}
