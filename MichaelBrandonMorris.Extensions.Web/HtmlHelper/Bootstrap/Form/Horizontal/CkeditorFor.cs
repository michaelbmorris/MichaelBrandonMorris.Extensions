using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.Horizontal
{
    public static partial class InputExtensions
    {
        public static MvcHtmlString CkeditorFor<TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression)
        {
            var ckeditor = HtmlHelperExtensions.CkeditorFor(html, expression);
            return html.InputFor(expression, ckeditor);
        }
    }
}