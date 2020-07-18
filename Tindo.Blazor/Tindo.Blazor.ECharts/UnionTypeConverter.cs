using System;
using System.Linq;
using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts
{
    public class UnionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType,  object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var valueProperty = value.GetType().GetProperties().Where(p => p.Name == "Value").FirstOrDefault();
            var val = valueProperty.GetValue(value) as Array;
            writer.WriteValue(val);
        }
    }
}
