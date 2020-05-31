using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Charts
{
    public class ChartObject
    {
#pragma warning disable IDE1006 // Naming Styles
        public string id { get; set; }
        public string type { get; set; }
        public ChartData data { get; set; }
#pragma warning restore IDE1006 // Naming Styles

    }
}
