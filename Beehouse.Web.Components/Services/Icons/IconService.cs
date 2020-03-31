using Beehouse.Web.Components.Services.Icons.Providers;
using Microsoft.Extensions.Options;

namespace Beehouse.Web.Components.Services.Icons
{
    public class IconService
    {
        private readonly WebComponentsOptions _options;
        public IIconProvider Provider { get; set; }
        public IconVariant Variant { get; set; }
        public int Stroke { get; set; }

        public IconService(IOptionsMonitor<WebComponentsOptions> optionsAccessor)
        {
            _options = optionsAccessor.CurrentValue;
            Variant = _options.IconOptions.Variant;
            Stroke = _options.IconOptions.Stroke;

            switch (_options.IconOptions.Provider) 
            {
                case IconProvider.Ionicons:
                    Provider = new IoniconProvider();
                    break;
                default:
                    Provider = new IoniconProvider();
                    break;
            }
            
        }
    }
}
