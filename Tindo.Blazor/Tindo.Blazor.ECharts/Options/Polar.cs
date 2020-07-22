using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tindo.Blazor.ECharts.Options
{
    public class Polar
    {
        public static Polar Empty => new EmptyPolar();
    }

    [JsonConverter(typeof(EmptyConverter))]
    internal class EmptyPolar : Polar
    {

    }
}
