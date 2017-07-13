using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.
    Horizontal
{
    /// <summary>
    ///     Class InputExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for InputExtensions
    public static partial class InputExtensions
    {
        /// <summary>
        ///     Bootstraps the horizontal password for.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="autocomplete">The autocomplete.</param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for BootstrapHorizontalPasswordFor`2
        public static MvcHtmlString BootstrapHorizontalPasswordFor
            <TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression,
                string autocomplete = "")
        {
            var password = html.PasswordFor(
                expression,
                new
                {
                    @class = PasswordClasses,
                    required = Required,
                    autocomplete
                });

            return html.BootstrapHorizontalInputFor(expression, password);
        }
    }
}