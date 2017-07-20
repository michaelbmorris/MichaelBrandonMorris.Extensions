using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.
    Horizontal
{
    public static partial class InputExtensions
    {
        public static MvcHtmlString BootstrapHorizontalSubmit(
            this System.Web.Mvc.HtmlHelper html,
            string value,
            ContextualColor contextualColor =
                ContextualColor.Default)
        {
            return MvcHtmlString.Create(
                "<div class=\"form-group\">"
                + "<div class=\"col-md-10 col-md-offset-2\">"
                + $"<input class=\"btn btn-{ContextualColors[contextualColor]}\" type=\"submit\" value=\"{value}\"/>"
                + "</div>"
                + "</div>");
        }
    }
}