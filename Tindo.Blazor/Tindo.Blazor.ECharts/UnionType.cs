using Newtonsoft.Json;

namespace Tindo.Blazor.ECharts
{
    public class UnionType<T1, T2>
    {
        public object Value { get; private set; }

        private UnionType(object value)
        {
            this.Value = value;
        }

        static public implicit operator UnionType<T1, T2>(T1 t1) => new UnionType<T1, T2>(t1);

        static public implicit operator UnionType<T1, T2>(T2 t2) => new UnionType<T1, T2>(t2);
    }

    public class UnionType<T1, T2, T3>
    {
        public object Value { get; private set; }

        private UnionType(object value)
        {
            this.Value = value;
        }

        static public implicit operator UnionType<T1, T2, T3>(T1 t1) => new UnionType<T1, T2, T3>(t1);

        static public implicit operator UnionType<T1, T2, T3>(T2 t2) => new UnionType<T1, T2, T3>(t2);
        
        static public implicit operator UnionType<T1, T2, T3>(T3 t3) => new UnionType<T1, T2, T3>(t3);
    }
}
