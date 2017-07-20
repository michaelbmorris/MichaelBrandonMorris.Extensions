using System.Collections.Generic;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form
{
    public static partial class InputExtensions
    {
        internal static IDictionary<ContextualColor, string> ContextualColors =>
            BootstrapExtensions.ContextualColors;
    }
}