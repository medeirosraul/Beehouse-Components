using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Services.Icons
{
    public interface IIconProvider
    {
        string Tag { get; set; }
        string IdentifierAttribute { get; set; }

        string TranslateName(IconName name);
        string TranslateName(IconName name, IconVariant variant);
    }
}
