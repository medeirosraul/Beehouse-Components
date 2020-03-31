using Beehouse.Web.Components.Common;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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
    }
}
