using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.Horizontal
{
    public static partial class InputExtensions
    {
        public static MvcHtmlString BootstrapHorizontalCheckBoxFor<TModel>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, bool>> expression)
        {
            var checkBox = html.CheckBoxFor(expression);
            var label = html.LabelFor(expression);

            return MvcHtmlString.Create(
                "<div class=\"form-group\">"
                + "<div class=\"col-md-offset-2 col-md-10\">"
                + "<div class=\"checkbox\">"
                + checkBox
                + label
                + "</div>"
                + "</div>"
                + "/div");
        }
    }
}