using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Threading.Tasks;
namespace Beehouse.Web.Components.Modals
{
    public partial class Modal
    {
        private string _messageInitialTemplate;

        // Parameters
        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string Title { get; set; } = "Untitled";

        [Parameter]
        public string Message { get; set; } = "No message.";

        [Parameter]
        public ModalTypes Type { get; set; } = ModalTypes.Ok;

        [Parameter]
        public RenderFragment ChildContent { get; set; }


        // Events
        [Parameter]
        public EventCallback OnClickExit { get; set; }

        [Parameter]
        public EventCallback OnClickOk { get; set; }

        [Parameter]
        public EventCallback OnClickCancel { get; set; }

        [Parameter]
        public EventCallback OnClickYes { get; set; }

        [Parameter]
        public EventCallback OnClickNo { get; set; }

        /// <summary>
        /// Show modal
        /// </summary>
        /// <param name="args">Arguments to string message</param>
        public async Task Show(params string[] args)
        {
            // Manage message template
            if (string.IsNullOrWhiteSpace(_messageInitialTemplate)) _messageInitialTemplate = Message;
            else Message = _messageInitialTemplate;

            for (var i = 0; i < args.Length; i++ )
            {
                Message = Message.Replace("{" + i + "}", args[i]);
            }

            // Notifiy that content has changed
            StateHasChanged();

            // Call JS Open function
            await JSRuntime.InvokeVoidAsync("BeehouseModalShow", Id);

        }

        /// <summary>
        /// Close modal
        /// </summary>
        public async Task Close()
        {
            // Call JS Close function
            await JSRuntime.InvokeVoidAsync("BeehouseModalClose", Id);
        }

        private async Task ButtonExitClicked(MouseEventArgs e)
        {
            await OnClickExit.InvokeAsync(e);
            await Close();
        }

        private async Task ButtonOkClicked(MouseEventArgs e)
        {
            await OnClickOk.InvokeAsync(e);
            await Close();
        }

        private async Task ButtonCancelClicked(MouseEventArgs e)
        {
            await OnClickCancel.InvokeAsync(e);
            await Close();
        }

        private async Task ButtonYesClicked(MouseEventArgs e)
        {
            await OnClickYes.InvokeAsync(e);
            await Close();
        }

        private async Task ButtonNoClicked(MouseEventArgs e)
        {
            await OnClickNo.InvokeAsync(e);
            await Close();
        }
        
    }
}
