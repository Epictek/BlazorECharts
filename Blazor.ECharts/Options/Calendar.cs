namespace Blazor.ECharts.Options
{
    public class Calendar
    {
        public int? Zlevel { get; set; }

        public int? Z { get; set; }

        public UnionType<Align, double> Left { get; set; }

        public UnionType<VerticalAlign, double> Top { get; set; }

        public UnionType<string, double> Right { get; set; }

        public UnionType<string, double> Bottom { get; set; }

        public UnionType<string, double> Width { get; set; }

        public UnionType<string, double> Height { get; set; }

        public UnionType<double, string, string[]> Range { get; set; }

        public UnionType<double, double[]> CellSize { get; set; }

        public Orient? Orient { get; set; }

        public SplitLine SplitLine { get; set; }

        public ItemStyle ItemStyle { get; set; }

        public DayLabel DayLabel { get; set; }

        public MonthLabel MonthLabel { get; set; }

        public YearLabel YearLabel { get; set; }

        public bool? Slient { get; set; }
    }
}
