using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Services.Icons
{
    public class IconOptions
    {
        public IconProvider Provider { get; set; }
        public IconVariant Variant { get; set; }
        public int Stroke { get; set; }

        public IconOptions()
        {
            Provider = IconProvider.Ionicons;
            Variant = IconVariant.Default;
            Stroke = 16;
        }
    }
}
