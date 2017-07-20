using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form
{
    public static partial class InputExtensions
    {
        public static MvcHtmlString BootstrapSubmit(
            this System.Web.Mvc.HtmlHelper html,
            string value,
            ContextualColor contextualColor)
        {
            return MvcHtmlString.Create(
                $"<input class=\"btn btn-{ContextualColors[contextualColor]}\" type=\"submit\" value =\"{value}\"/>");
        }
    }
}