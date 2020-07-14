using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tindo.Blazor.ECharts.Options
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextAlign
    {
        Auto,
        Left,
        Right,
        Center
    }
}
