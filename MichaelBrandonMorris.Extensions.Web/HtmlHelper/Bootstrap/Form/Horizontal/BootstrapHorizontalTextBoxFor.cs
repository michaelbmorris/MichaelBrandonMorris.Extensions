using System;
using System.Collections.Generic;
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
        ///     The autocomplete
        /// </summary>
        /// TODO Edit XML Comment Template for Autocomplete
        internal const string Autocomplete = "autocomplete";

        /// <summary>
        ///     The class
        /// </summary>
        /// TODO Edit XML Comment Template for Class
        internal const string Class = "class";

        /// <summary>
        ///     Bootstraps the horizontal text box for.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="format">The format.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        /// <param name="autocomplete">The autocomplete.</param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for BootstrapHorizontalTextBoxFor`2
        public static MvcHtmlString BootstrapHorizontalTextBoxFor
            <TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression,
                string format,
                bool required = false,
                string autocomplete = "")
        {
            var htmlAttributes =
                BuildHtmlAttributes(TextBoxClasses, required, autocomplete);

            var textBox = html.TextBoxFor(expression, format, htmlAttributes);
            return html.BootstrapHorizontalInputFor(expression, textBox);
        }

        /// <summary>
        ///     Bootstraps the horizontal text box for.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        /// <param name="autocomplete">The autocomplete.</param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for BootstrapHorizontalTextBoxFor`2
        public static MvcHtmlString BootstrapHorizontalTextBoxFor
            <TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression,
                bool required = false,
                string autocomplete = null)
        {
            var htmlAttributes =
                BuildHtmlAttributes(TextBoxClasses, required, autocomplete);

            var textBox = html.TextBoxFor(expression, htmlAttributes);
            return html.BootstrapHorizontalInputFor(expression, textBox);
        }

        /// <summary>
        ///     Builds the HTML attributes.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        /// <param name="autocomplete">The autocomplete.</param>
        /// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
        /// TODO Edit XML Comment Template for BuildHtmlAttributes
        private static IDictionary<string, object> BuildHtmlAttributes(
            string @class,
            bool required,
            string autocomplete)
        {
            var htmlAttributes = new Dictionary<string, object>
            {
                {
                    Class, @class
                }
            };

            if (required)
            {
                htmlAttributes.Add(Required, Required);
            }

            if (autocomplete != null)
            {
                htmlAttributes.Add(Autocomplete, autocomplete);
            }

            return htmlAttributes;
        }
    }
}