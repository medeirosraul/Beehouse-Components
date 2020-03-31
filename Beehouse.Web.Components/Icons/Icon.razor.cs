using Beehouse.Web.Components.Services.Icons;
using Microsoft.AspNetCore.Components;

namespace Beehouse.Web.Components.Icons
{
    public partial class Icon
    {
        [Parameter]
        public IconName Name { get; set; }

        private RenderFragment IconFragment;
        protected override void OnInitialized()
        {
            IconFragment = builder =>
            {
                builder.OpenElement(0, Service.Provider.Tag);
                builder.AddAttribute(1, Service.Provider.IdentifierAttribute, Service.Provider.TranslateName(Name, Service.Variant));
                builder.CloseElement();
            };
            base.OnInitialized();
        }
    }
}
