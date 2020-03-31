using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Services.Icons.Providers
{
    public class IoniconProvider : IIconProvider
    {
        public string Tag { get; set; }
        public string IdentifierAttribute { get; set; }

        public IoniconProvider()
        {
            Tag = "ion-icon";
            IdentifierAttribute = "name";
        }

        public string TranslateName(IconName name)
        {
            return TranslateName(name, IconVariant.Default);
        }

        public string TranslateName(IconName name, IconVariant variant)
        {
            string n;
            string v = "";

            switch (variant)
            {
                case IconVariant.Outline:
                    v = "-outline";
                        break;
                case IconVariant.Default:
                default:
                    break;

            }

            switch (name)
            {
                case IconName.Home:
                    n = "home";
                    break;
                default:
                    n = "help";
                    break;
            }

            return $"{n}{v}";
        }

        
    }
}
