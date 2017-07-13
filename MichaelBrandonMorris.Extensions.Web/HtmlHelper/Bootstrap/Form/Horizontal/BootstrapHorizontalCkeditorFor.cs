using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.Horizontal
{
    public static partial class InputExtensions
    {
        public static MvcHtmlString BootstrapHorizontalCkeditorFor<TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression)
        {
            var ckeditor = html.CkeditorFor(expression);
            return html.BootstrapHorizontalInputFor(expression, ckeditor);
        }
    }
}