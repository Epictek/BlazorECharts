using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Tindo.Blazor.ECharts
{
    internal static class JSRuntimeExtension
    {
        public static JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public static async Task InitChart(this IJSRuntime runtime, string id, string theme="light", bool showLoading=true, object opts=null)
        {
            ValidateId(id);
            await runtime.InvokeVoidAsync("invokeECharts.init", id, theme, showLoading, JsonConvert.SerializeObject(opts, Formatting.None, Settings));
        }

        public static async Task ShowLoadingChart(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            await runtime.InvokeVoidAsync("invokeECharts.showLoading", id);
        }

        public static async Task SetupChart(this IJSRuntime runtime, string id, object opts, bool? notMerge, bool? lazyUpdate)
        {
            ValidateId(id);
            await runtime.InvokeVoidAsync("invokeECharts.setup", id, JsonConvert.SerializeObject(opts, Formatting.None, Settings), notMerge, lazyUpdate);
        }

        private static void ValidateId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentNullException($"{nameof(id)} shouldn't be empty or null");
        }
    }
}
