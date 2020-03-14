using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Beehouse.Web.Components.Js
{
    public class MaskJsInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public bool UsingMask { get; set; } = false;

        public MaskJsInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task RunMaskJs()
        {
            if(UsingMask)
                await _jsRuntime.InvokeVoidAsync("BeehouseApplyMask");
        }
    }
}
