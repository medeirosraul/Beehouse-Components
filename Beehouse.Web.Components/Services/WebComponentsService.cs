using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Services
{
    public class WebComponentsService
    {
        public WebComponentsOptions Options;
        public WebComponentsService(IOptionsMonitor<WebComponentsOptions> optionsAccessor)
        {
            Options = optionsAccessor.CurrentValue;
        }
    }
}
