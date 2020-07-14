using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{

    public class TextStyle
    {
        public string Color { get; set; }

        public FontStyle FontStyle { get; set; }

        public UnionType<FontWeight,int> FontWeight { get; set; }

        public string FontFamily { get; set; }

        public int FontSize { get; set; }

        public int LightHeight { get; set; }

        public UnionType<int, string> Width { get; set; }

        public UnionType<int, string> Height { get; set; }


    }
}
