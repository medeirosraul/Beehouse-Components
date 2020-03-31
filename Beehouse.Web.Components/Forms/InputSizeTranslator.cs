using Beehouse.Web.Components.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beehouse.Web.Components.Forms
{
    public static class InputSizeTranslator
    {
        private const int LabelBaseSize = 4;
        private const int InputBaseSize = 8;
        public static string TranslateLabel(ElementSize size, float proportion)
        {
            float proportionInverse = 1 / proportion;

            int sm = Convert.ToInt32(4 * proportionInverse);
            int md = 6;
            int lg = Convert.ToInt32(3 * proportion);
            int xl = Convert.ToInt32(2 * proportion);

            switch (size)
            {
                case ElementSize.ExtraLarge:
                    return "col-sm-4 col-lg-3 col-xl-2";
                default:
                    return "col-sm-4 col-lg-3 col-xl-2";
            }
       
        }

        public static string ToLabelClass()
        {
            return "";
        }
    }
}
