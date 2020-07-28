namespace Tindo.Blazor.ECharts.API
{
    /// <summary>
    /// ECharts init function's opt parameter
    /// <see cref="https://echarts.apache.org/en/api.html#echarts.init"/>
    /// </summary>
    public class Opts
    {
        /// <summary>
        /// Ratio of one physical pixel to the size of one device independent pixels. Browser's <i>window.devicePixelRatio </i> is used by default.
        /// </summary>
        public double? DevicePixelRatio { get; set; }

        /// <summary>
        /// Supports 'Canvas' or 'Svg'
        /// <see cref="https://echarts.apache.org/en/tutorial.html#Render%20by%20Canvas%20or%20SVG"/>
        /// </summary>
        public Renderer? Renderer { get; set; }

        /// <summary>
        /// Specify width explicitly, in pixel. If setting to null/undefined/'auto', width of dom (instance container) will be used.
        /// </summary>
        public UnionType<string, double> Width { get; set; }

        /// <summary>
        /// Specify height explicitly, in pixel. If setting to null/undefined/'auto', height of dom (instance container) will be used.
        /// </summary>
        public UnionType<string, double> Height { get; set; }

    }
}
