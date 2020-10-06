namespace Blazor.ECharts.Options.Series
{
    public class LineSeries : SeriesBase
    {
        public override string Type => "line";

        public Emphasis Emphasis { get; set; }
    }
}
