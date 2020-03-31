using Beehouse.Web.Components.Modals;
using Beehouse.Web.Components.Services.Icons;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Beehouse.Web.Components
{
    public static class WebComponentsExtensions
    {
        public static IServiceCollection AddBeehouseWebComponents(this IServiceCollection services)
        {
            // Defaults
            return services.AddBeehouseWebComponents(options => {});
        }

        public static IServiceCollection AddBeehouseWebComponents(this IServiceCollection services, Action<WebComponentsOptions> options)
        {
            services.Configure(options);
            services.AddSingleton<IconService>();
            services.AddScoped<MessageBoxAccessor>();
            return services;
        }
    }
}
