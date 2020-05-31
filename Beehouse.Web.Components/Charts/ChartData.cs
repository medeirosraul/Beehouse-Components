using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Charts
{
    public class ChartData
    {
#pragma warning disable IDE1006 // Naming Styles
        public string[] labels { get; set; }
        public List<ChartDataSet> datasets { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
