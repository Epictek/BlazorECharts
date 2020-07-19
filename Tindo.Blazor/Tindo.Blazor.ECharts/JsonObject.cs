using Newtonsoft.Json.Linq;

namespace Tindo.Blazor.ECharts
{
    /// <summary>
    /// For ECharts's any type.
    /// </summary>
    public class JsonObject
    {
        public JToken Value { get; private set; }

        private JsonObject(JToken obj)
        {
            this.Value = obj;
        }

        static public implicit operator JsonObject(JToken obj) => new JsonObject(obj);

        static public implicit operator JsonObject(string json)=> new JsonObject(JToken.Parse(json));
    }
}
