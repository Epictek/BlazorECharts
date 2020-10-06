using Microsoft.JSInterop;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.ECharts.API;
using Blazor.ECharts.Options;
using Action = Blazor.ECharts.API.Action;

namespace Blazor.ECharts
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
            Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) }
        };

        public static async Task InitChart(this IJSRuntime runtime, string id, string theme = "light", Opts opts = null)
        {
            ValidateId(id);
            var serializedOpt = JsonConvert.SerializeObject(opts, Formatting.None, Settings);
            await runtime.InvokeVoidAsync("invokeECharts.init", id, theme, serializedOpt);
        }

        public static async Task Resize(this IJSRuntime runtime, string id, int? width, int? height, bool? silent)
        {
            ValidateId(id);
            await runtime.InvokeVoidAsync("invokeECharts.resize", id, width, height, silent);
        }

        public static async Task DispatchAction(this IJSRuntime runtime, string id, Action action)
        {
            ValidateId(id);

            Console.WriteLine(action);
            Console.WriteLine(JsonConvert.SerializeObject(action));

            var serializedAction = JsonConvert.SerializeObject(action, Formatting.None, Settings);

            await runtime.InvokeVoidAsync("invokeECharts.dispatchAction", id, serializedAction);
        }

        public static async Task ShowLoading(this IJSRuntime runtime, string id, string type = "default", LoadingOpts opts = null)
        {
            ValidateId(id);
            if (opts == null)
            {
                await runtime.InvokeVoidAsync("invokeECharts.showLoading", id, type);
            }
            else
            {
                var serializedOpts = JsonConvert.SerializeObject(opts, Formatting.None, Settings);
                await runtime.InvokeVoidAsync("invokeECharts.showLoading", id, type, serializedOpts);
            }
        }

        public static async Task HideLoading(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            await runtime.InvokeVoidAsync("invokeECharts.hideLoading", id);
        }


        public static async Task SetOpton(this IJSRuntime runtime, string id, Option option, bool notMerge = false, bool lazyUpdate = false)
        {
            ValidateId(id);
            var serializedOption = JsonConvert.SerializeObject(option, Formatting.None, Settings);
            await runtime.InvokeVoidAsync("invokeECharts.setOption", id, serializedOption, notMerge, lazyUpdate);
        }

        public static async ValueTask<Option> GetOption(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            var option = await runtime.InvokeAsync<string>("invokeECharts.getOption", id);
            var serializedOption = JsonConvert.DeserializeObject<Option>(option, Settings);
            return serializedOption;
        }

        public static async Task InitCallback(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            await runtime.InvokeVoidAsync("invokeECharts.initCallback", id);
        }


        public static async ValueTask<double> GetInsideDataZoomStart(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            var option = await runtime.InvokeAsync<double>("invokeECharts.getInsideDataZoomStart", id);
            return option;
        }
        public static async ValueTask<double> GetInsideDataZoomEnd(this IJSRuntime runtime, string id)
        {
            ValidateId(id);
            var option = await runtime.InvokeAsync<double>("invokeECharts.getInsideDataZoomEnd", id);
            return option;
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
