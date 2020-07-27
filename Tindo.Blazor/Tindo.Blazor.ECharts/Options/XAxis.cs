﻿namespace Tindo.Blazor.ECharts.Options
{
    public class XAxis : AxisBase
    {
        public override AxisPosition Postion { get; set; } = AxisPosition.Bottom;
        public override AxisType Type { get; set; } = AxisType.Category;
    }
}
