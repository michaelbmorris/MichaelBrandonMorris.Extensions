using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Display
{
    public static partial class DisplayExtensions
    {
        internal static IDictionary<ContextualColor, string> ContextualColors =>
            BootstrapExtensions.ContextualColors;
    }
}
