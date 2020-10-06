namespace Blazor.ECharts.API
{
    
    public abstract class Action
    {
        public abstract string Type { get; }
    }


    public class BrushAction : Action
    {
        public override string Type { get; } = "brush";
        public string BrushId { get; set; }
        public Area[] Areas { get; set; }
    }
    
    public class Area
    {
        public string BrushType { get; set; }
        public int geoIndex { get; set; }
        public double[] CoordRange { get; set; }
        public object[] Range { get; set; }
        public int XAxisIndex { get; set; }
    }

    public class TakeGlobalCursorAction : Action
    {
        public override string Type { get; } = "takeGlobalCursor";
        public string Key { get; set; } = "brush";
        public object BrushOption { get; set; }
    }

    public class BrushOption
    {
        public string BrushType { get; set; }
        public string BrushMode { get; set; }

    }
    
}