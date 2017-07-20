using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Display
{
    public static partial class DisplayExtensions
    {
        internal const string DdClose = "</dd>";
        internal const string DdOpen = "<dd>";
        internal const string DtClose = "</dt>";
        internal const string DtOpen = "<dt>";

        public static MvcHtmlString BootstrapDefinitionFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression)
        {
            var definitionTerm = html.DisplayNameFor(expression);
            var definitionDescription = html.DisplayFor(expression);

            return MvcHtmlString.Create(
                DtOpen
                + definitionTerm
                + DtClose
                + DdOpen
                + definitionDescription
                + DdClose);
        }
    }
}