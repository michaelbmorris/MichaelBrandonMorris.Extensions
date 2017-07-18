using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.Inline
{
    public static partial class InputExtensions
    {
        public static MvcHtmlString BootstrapInlineTextBox(
            this System.Web.Mvc.HtmlHelper html,
            string name,
            object value,
            string format,
            IDictionary<string, object> htmlAttributes)
        {
            if (htmlAttributes.ContainsKey(Class))
            {
                htmlAttributes[Class] += " form-control";
            }
            else
            {
                htmlAttributes.Add(Class, "form-control");
            }

            var textBox= html.TextBox(
                name,
                value,
                format,
                htmlAttributes);

            return MvcHtmlString.Create(
                "<div class=\"form-group\">" + textBox + "</div>");
        }
    }
}
