using System.Reflection;
using Tindo.Blazor.ECharts.Options.Series;

namespace Tindo.Blazor.ECharts.Options
{
    public class Option
    {
        public Title Title { get; set; }

        public Tooltip Tooltip { get; set; }

        public Legend Legend { get; set; }

        public Grid Grid { get; set; }

        public XAxis[] XAxis { get; set; }

        public YAxis[] YAxis { get; set; }

        public SeriesBase[] Series { get; set; }
    }
}
