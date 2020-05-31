using Beehouse.Web.Components.Common;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Timers;

namespace Beehouse.Web.Components.Forms
{
    public partial class Search<TModel>
    {
        // internal state
        private bool _listVisible;
        private bool _loading;
        private int _time = 200;

        private Timer _timer;
        // Properties
        [Parameter]
        public bool Multiselect { get; set; } = false;

        [Parameter] 
        public string Label { get; set; }

        [Parameter] 
        public ElementSize Size { get; set; }

        [Parameter] 
        public string Term { get; set; }

        [Parameter] 
        public ICollection<TModel> Context { get; set; }

        [Parameter]
        public EventCallback<ICollection<TModel>> ContextChanged{ get; set; }

        [Parameter]
        public ICollection<TModel> Selected { get; set; }
        [Parameter]
        public EventCallback<ICollection<TModel>> SelectedChanged { get; set; }
        [Parameter] 
        public Expression<Func<ICollection<TModel>>> SelectedExpression { get; set; }

        [Parameter] 
        public RenderFragment<TModel> ItemTemplate { get; set; }

        // Events
        [Parameter]
        public EventCallback<string> OnTermChange { get; set; }

        [Parameter]
        public EventCallback<TModel> OnItemSelect { get; set; }

        [Parameter]
        public EventCallback<TModel> OnItemRemove { get; set; }

        public string RemoveButtonLabel => Multiselect ? "Remover" : "Modificar";

        public string LabelSizeClass
        {
            get
            {
                switch (Size)
                {
                    case ElementSize.Small:
                        return "col-sm-8 col-md-6 col-lg-5 col-xl-4";
                    default:
                        return "col-sm-4 col-lg-3 col-xl-2";
                }
            }
        }

        public string InputSizeClass
        {
            get
            {
                switch (Size)
                {
                    case ElementSize.Small:
                        return "col-sm-4 col-md-6 col-lg-7 col-xl-8";
                    default:
                        return "col-sm-8 col-lg-9 col-xl-10";
                }
            }
        }

        protected override void OnInitialized()
        {
            _timer = new Timer(_time)
            {
                AutoReset = false
            };
            _timer.Elapsed += TimeElapsed;
        }

        private void TimeElapsed(Object source, ElapsedEventArgs e)
        {
            InvokeAsync(async () =>
            {
                await OnTermChange.InvokeAsync(Term);
                _loading = false;
                StateHasChanged();
            });
        }

        private async Task OnInput(ChangeEventArgs e)
        {
            // Stop timer
            _timer.Stop();

            // Change term
            Term = e.Value.ToString();

            // Reset context
            Context = null;
            await ContextChanged.InvokeAsync(Context);

            // Change state
            _listVisible = true;
            _loading = true;

            // Start timer
            _timer.Start();
        }

        private async Task OnFocusIn(FocusEventArgs e)
        {
            if(!string.IsNullOrEmpty(Term))
            {
                var changeEventArgs = new ChangeEventArgs
                {
                    Value = Term
                };
                await OnInput(changeEventArgs);
            }
        }

        private void OnFocusOut(FocusEventArgs e)
        {
            if(Context == null || Context.Count == 0)
            {
                _listVisible = false;
                StateHasChanged();
            }
        }

        private async Task OnCancelClick(MouseEventArgs e)
        {
            // Change state
            _listVisible = false;

            // Reset List
            Context = null;
            await ContextChanged.InvokeAsync(Context);
        }

        private async Task ItemSelected(TModel item)
        {
            // Reset term
            Term = string.Empty;

            // Change state
            _listVisible = false;

            // Add to selected items
            Selected ??= new List<TModel>();
            if (!Multiselect) Selected.Clear();
            Selected.Add(item);

            // Invoke events
            await SelectedChanged.InvokeAsync(Selected);
            await OnItemSelect.InvokeAsync(item);
        }

        private async Task RemoveSelectedClicked(TModel item)
        {
            // Remove item from selected
            Selected.Remove(item);

            // Invoke events
            await SelectedChanged.InvokeAsync(Selected);
            await OnItemRemove.InvokeAsync(item);
        }
    }
}
