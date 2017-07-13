using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form
{
    public static partial class InputExtensions
    {
        public static MvcHtmlString BootstrapSubmit(
            this System.Web.Mvc.HtmlHelper html,
            string value,
            BootstrapContextualClass contextualClass)
        {
            return MvcHtmlString.Create(
                $"<input class=\"btn btn-{BootstrapExtensions.GetContextualClass(contextualClass)}\" type=\"submit\" value =\"{value}\"/>");
        }
    }
}