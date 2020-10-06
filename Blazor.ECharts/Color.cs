using Newtonsoft.Json;
using System;

namespace Blazor.ECharts
{
    [JsonConverter(typeof(ColorConvert))]
    public class Color
    {
        public object Value { get; private set; }

        private Color(object value)
        {
            this.Value = value;
        }

        static public implicit operator Color(string color) => new Color(color);

        static public implicit operator Color(System.Drawing.Color color)
        {
            var rgba = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
            return new Color(rgba);
        }
    }

    internal class ColorConvert : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if(value is Color color)
            {
                writer.WriteValue(color.Value);
            }
        }
    }
}
