using System;

namespace Tindo.Blazor.ECharts.Options.Series
{
    public abstract class SeriesBase
    {
        public abstract string Type { get; }

        public string Name { get; set; }

        public Array Data { get; set; }
    }
}
