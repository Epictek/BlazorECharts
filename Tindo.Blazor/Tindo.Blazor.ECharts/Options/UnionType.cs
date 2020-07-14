namespace Tindo.Blazor.ECharts.Options
{
    public class UnionType<T1, T2>
    {
        private object value;

        public UnionType(object value)
        {
            this.value = value;
        }

        static public implicit operator UnionType<T1, T2>(T1 t1) => new UnionType<T1, T2>(t1);

        static public implicit operator UnionType<T1, T2>(T2 t2) => new UnionType<T1, T2>(t2);
    }

    public class UnionType<T1, T2, T3>
    {
        private object value;

        public UnionType(object value)
        {
            this.value = value;
        }

        static public implicit operator UnionType<T1, T2, T3>(T1 t1) => new UnionType<T1, T2, T3>(t1);

        static public implicit operator UnionType<T1, T2, T3>(T2 t2) => new UnionType<T1, T2, T3>(t2);
    }
}
