using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts.Options
{
    public class RadiusAxis
    {

        public static RadiusAxis Empty => new EmptyRadiusAxis();
    }

    [JsonConverter(typeof(EmptyConverter))]
    internal class EmptyRadiusAxis : RadiusAxis
    {

    }
}
