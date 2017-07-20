using System.Linq;
using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Display.Horizontal
{
    public static partial class DisplayExtensions
    {
        public static MvcHtmlString BootstrapHorizontalDefinitionList(
            this System.Web.Mvc.HtmlHelper html,
            params MvcHtmlString[] definitions)
        {
            return MvcHtmlString.Create(
                "<dl class=\"dl-horizontal\">"
                + definitions.Aggregate(
                    string.Empty,
                    (current, definition) => current + definition)
                + "</dl>");
        }
    }
}