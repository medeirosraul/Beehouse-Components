using Beehouse.Web.Components.Common;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Beehouse.Web.Components.Forms
{
    public partial class Input
    {
        [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> InputAttributes { get; set; }
        [Parameter] public string Label { get; set; }
        [Parameter] public string Value { get; set; }
        [Parameter] public ElementValueType Type { get; set; }
        [Parameter] public ElementSize Size { get; set; }
        [Parameter] public bool Hidden { get; set; } = false;
        [Parameter] public EventCallback<string> ValueChanged { get; set; }
        [Parameter] public Expression<Func<string>> ValueExpression { get; set; }
        [Parameter] public EventCallback<string> OnChange { get; set; }

        private async Task Changed(string value)
        {
            await OnChange.InvokeAsync(value);
        }
    }
}
