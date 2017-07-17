using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap
{
    public static partial class DisplayExtensions
    {
        public static MvcHtmlString BootstrapHorizontalDefinitionListFor
            <TModel, TValue>(
                this HtmlHelper<TModel> html,
                params Expression<Func<TModel, TValue>>[] expressions)
        {
            var definitions = expressions.Select(html.BootstrapDefinitionFor);

            return html
                .BootstrapHorizontalDefinitionList(definitions.ToArray());
        }
    }
}