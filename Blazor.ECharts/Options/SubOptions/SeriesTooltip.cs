namespace Blazor.ECharts.Options
{
    public class SeriesTooltip
    {
        public UnionType<string, string[], double[]> Position { get; set; }

        public string Formatter { get; set; }

        public Color BackgroundColor { get; set; }

        public Color BorderColor { get; set; }

        public double? BorderWidth { get; set; }

        public UnionType<double, double[]> Padding { get; set; }

        public TextStyle TextType { get; set; }

        public string ExtraCssText { get; set; }


    }
}
