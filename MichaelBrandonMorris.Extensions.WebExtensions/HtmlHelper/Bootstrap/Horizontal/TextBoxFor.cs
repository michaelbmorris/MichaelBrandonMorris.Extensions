using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Horizontal
{
    public static partial class InputExtensions
    {
        internal const string Autocomplete = "autocomplete";
        internal const string Class = "class";

        public static MvcHtmlString TextBoxFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression,
            string format,
            bool required = false,
            string autocomplete = "")
        {
            var htmlAttributes =
                BuildHtmlAttributes(TextBoxClasses, required, autocomplete);

            var textBox = html.TextBoxFor(expression, format, htmlAttributes);

            return html.InputFor(expression, textBox);
        }

        public static MvcHtmlString TextBoxFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression,
            bool required = false,
            string autocomplete = null)
        {
            var htmlAttributes =
                BuildHtmlAttributes(TextBoxClasses, required, autocomplete);

            var textBox = html.TextBoxFor(expression, htmlAttributes);

            return html.InputFor(expression, textBox);
        }

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