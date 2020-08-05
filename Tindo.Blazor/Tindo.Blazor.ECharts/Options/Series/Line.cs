namespace Tindo.Blazor.ECharts.Options.Series
{
    public class Line : SeriesBase
    {
        public override string Type => nameof(Line).ToLower();

        public Emphasis Emphasis { get; set; }
    }
}
