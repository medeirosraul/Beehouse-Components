using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Beehouse.Web.Components.Modals
{
    public partial class MessageBox
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Message { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnButtonOkClick { get; set; }

        protected override void OnInitialized()
        {
            MessageBoxAccessor.MessageBox = this;
        }

        /// <summary>
        /// Show Modal
        /// </summary>
        public async Task Show()
        {
            // Call JS Close function
            await JSRuntime.InvokeVoidAsync("BeehouseMessageBoxShow", "modal-message-box", DotNetObjectReference.Create(this));
        }

        /// <summary>
        /// Show MessageBox
        /// </summary>
        /// <param name="title">Set title</param>
        /// <param name="message">Set message</param>
        public async Task Show(string title, string message)
        {
            Title = title;
            Message = message;
            StateHasChanged();

            await Show();
        }

        [JSInvokable]
        public async Task Showed()
        {
            Debug.WriteLine("Showed triggered.");
        }

        /// <summary>
        /// Close modal
        /// </summary>
        public async Task Close()
        {
            // Call JS Close function
            await JSRuntime.InvokeVoidAsync("BeehouseMessageBoxClose", "modal-message-box", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public async Task Closed()
        {

            Debug.WriteLine("Closed triggered.");
        }

        private async Task ButtonOkClicked(MouseEventArgs e)
        {
            await Close();
            await OnButtonOkClick.InvokeAsync(e);
        }
    }
}