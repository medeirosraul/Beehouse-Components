using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Charts
{
    public class ChartDataSet
    {
#pragma warning disable IDE1006 // Naming Styles
        public string label { get; set; }
        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public float[] data { get; set; }

#pragma warning restore IDE1006 // Naming Styles
    }
}
