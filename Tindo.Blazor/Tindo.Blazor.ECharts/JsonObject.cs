using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tindo.Blazor.ECharts
{
    /// <summary>
    /// For ECharts's any type.
    /// </summary>
    [JsonConverter(typeof(JsonObjectConverter))]
    public class JsonObject
    {
        public JToken Value { get; private set; }

        private JsonObject(JToken obj)
        {
            this.Value = obj;
        }

        static public implicit operator JsonObject(JToken obj) => new JsonObject(obj);

        static public implicit operator JsonObject(string json) => new JsonObject(JToken.Parse(json));
    }

    internal class JsonObjectConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(JsonObject);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JsonObject obj = value as JsonObject;
            writer.WriteToken(obj.Value.CreateReader());
        }
    }
}
