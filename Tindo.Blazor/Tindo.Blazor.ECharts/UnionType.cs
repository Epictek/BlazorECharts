using Newtonsoft.Json;
using System;

namespace Tindo.Blazor.ECharts
{
    public abstract class UnionType
    {
        public object Value { get; private set; }

        protected UnionType(object value)
        {
            this.Value = value;
        }
    }

    [JsonConverter(typeof(UnionTypeConveter))]
    public class UnionType<T1, T2> : UnionType
    {
        private UnionType(object value): base(value)
        {
        }
        static public implicit operator UnionType<T1, T2>(T1 t1) => new UnionType<T1, T2>(t1);

        static public implicit operator UnionType<T1, T2>(T2 t2) => new UnionType<T1, T2>(t2);
    }

    [JsonConverter(typeof(UnionTypeConveter))]
    public class UnionType<T1, T2, T3> : UnionType
    {
        private UnionType(object value) : base(value)
        {
        }
        static public implicit operator UnionType<T1, T2, T3>(T1 t1) => new UnionType<T1, T2, T3>(t1);

        static public implicit operator UnionType<T1, T2, T3>(T2 t2) => new UnionType<T1, T2, T3>(t2);
        
        static public implicit operator UnionType<T1, T2, T3>(T3 t3) => new UnionType<T1, T2, T3>(t3);
    }

    internal class UnionTypeConveter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }
        public override object ReadJson(JsonReader reader, Type objectType,  object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer,  object value, JsonSerializer serializer)
        {
            if(value is UnionType obj)
            {
                serializer.Serialize(writer, obj.Value);
            }
        }
    }
}
