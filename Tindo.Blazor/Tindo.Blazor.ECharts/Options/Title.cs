using System;

namespace Tindo.Blazor.ECharts.Options
{
    public class Title
    {
        public string Id { get; set; }

        public bool Show { get; set; }

        public string Text { get; set; }

        public string Link { get; set; }

        public Target Target { get; set; }

        public TextStyle TextStyle { get; set; }

        public string Subtext { get; set; }

        public string Sublink { get; set; }

        public Subtarget Subtarget { get; set; }

        public TextStyle SubtextStyle { get; set; }

        public TextAlign TextAlign { get; set; }

        public bool TriggerEvent { get; set; }

        public UnionType<int, Array> Padding { get; set; }

        public int ItemGap { get; set; }

        public int Zlevel { get; set; }

        public int Z { get; set; }

        public UnionType<string, TextAlign> Left { get; set; }

        public UnionType<string, TextVerticalAlign> Top { get; set; }

        public UnionType<string, int> Right { get; set; }

        public UnionType<string, int> Bottom { get; set; }

        public string BackgroundColor { get; set; }

        public int BorderWidth { get; set; }

        public UnionType<int, Array> BorderRadius { get; set; }

        public int ShadowBlur { get; set; }

        public string ShadowColor { get; set; }

        public int ShadowOffsetX { get; set; }

        public int ShadowOffsetY { get; set; }

    }
}
