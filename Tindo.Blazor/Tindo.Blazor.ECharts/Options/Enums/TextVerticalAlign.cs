using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tindo.Blazor.ECharts.Options
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextVerticalAlign
    {
        Auto,
        Top,
        Buttom,
        Middle
    }
}
