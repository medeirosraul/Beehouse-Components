using Beehouse.Web.Components.Charts;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Beehouse.Web.Components.Js
{
    public class ChartJsInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public ChartJsInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task CreateChart(ChartObject chart)
        {
           await _jsRuntime.InvokeVoidAsync("OwlCreateChart", chart);
        }
    }
}
