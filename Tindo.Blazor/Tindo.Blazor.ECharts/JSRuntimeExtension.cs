using Microsoft.JSInterop;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Threading.Tasks;
using Tindo.Blazor.ECharts.API;
using Tindo.Blazor.ECharts.Options;

namespace Tindo.Blazor.ECharts
{
    /// <summary>
    /// JSRuntime extension for ECharts.
    /// </summary>
    public static class JSRuntimeExtension
    {
        private static JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = { new StringEnumConverter(new CamelCaseNamingStrategy())}
        };

        public static async Task InitChart(this IJSRuntime runtime, string id, string theme="light", Opts opts=null)
        {
            ValidateId(id);
            var serializedOpt = JsonConvert.SerializeObject(opts, Formatting.None, Settings);
            await runtime.InvokeVoidAsync("invokeECharts.init", id, theme, serializedOpt);
        }

        public static async Task SetOpton(this IJSRuntime runtime, string id, Option option, bool notMerge=false, bool lazyUpdate=false)
        {
            ValidateId(id);
            var serializedOption = JsonConvert.SerializeObject(option, Formatting.None, Settings);
            await runtime.InvokeVoidAsync("invokeECharts.setOption", id, serializedOption, notMerge, lazyUpdate);
        }

        public static async Task RemoveChart(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            await runtime.InvokeVoidAsync("invokeECharts.remove", id);
        }

        public static async ValueTask<bool> Exist(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            var exist = await runtime.InvokeAsync<bool>("invokeECharts.exist", id);
            return exist;
        }

        private static void ValidateId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentNullException($"{nameof(id)} shouldn't be empty or null");
        }
    }
}
