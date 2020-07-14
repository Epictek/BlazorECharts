using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tindo.Blazor.ECharts.Options
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FontWeight
    {
        Normal,
        Bold,
        Bolder,
        Lighter
    }
}
