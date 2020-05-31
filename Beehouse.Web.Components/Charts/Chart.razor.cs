using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Beehouse.Web.Components.Charts
{
    public partial class Chart
    {
        private string _id;

        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                    _id = Guid.NewGuid().ToString();

                return _id;
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var chart = new ChartObject
                {
                    id = Id,
                    type = "line",
                    data = new ChartData
                    {
                        labels = new string[] { "teste", "teste", "teste", "teste" },
                        datasets = new List<ChartDataSet>()
                    {
                        new ChartDataSet
                        {
                            label = "Dataset teste",
                            backgroundColor = "rgb(255, 99, 132)",
                            borderColor = "rgb(255, 99, 132)",
                            data = new float[] {1f, 2f, 4f, 3f}
                        }
                    }
                    }
                };

                await ChartJsInterop.CreateChart(chart);
            }
        }
    }

    
}
