using Beehouse.Essentials.Types;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Tables
{
    public partial class Table<TModel>
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public PagedList<TModel> Context { get; set; }
        [Parameter] public RenderFragment Menu { get; set; }
        [Parameter] public RenderFragment Header { get; set; }
        [Parameter] public RenderFragment<TModel> RowTemplate { get; set; }
        [Parameter] public RenderFragment<TModel> ActionsTemplate { get; set; }
        [Parameter] public EventCallback<int> OnPageChanged { get; set; }

        private bool Any()
        {
            return Context?.Count > 0;
        }
    }
}
