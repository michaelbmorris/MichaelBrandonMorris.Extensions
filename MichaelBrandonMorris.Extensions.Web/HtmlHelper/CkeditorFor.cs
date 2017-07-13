using System;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper
{
    public static partial class HtmlHelperExtensions
    {
        /// <summary>
        ///     Ckeditors for.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="expression">The expression.</param>
        /// <returns>MvcHtmlString.</returns>
        /// <exception cref="ArgumentException"></exception>
        /// TODO Edit XML Comment Template for CkeditorFor`2
        public static MvcHtmlString CkeditorFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression)
        {
            var modelMetadata =
                ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            var name = ExpressionHelper.GetExpressionText(expression);
            var fullName = html.ViewContext.ViewData.TemplateInfo
                .GetFullHtmlFieldName(name);

            if (fullName.IsNullOrWhiteSpace())
            {
                throw new ArgumentException();
            }

            var tagBuilder = new TagBuilder("textarea");
            tagBuilder.GenerateId(fullName);
            tagBuilder.MergeAttribute("name", fullName, true);

            if (html.ViewData.ModelState.TryGetValue(
                    fullName,
                    out ModelState modelState)
                && modelState.Errors.Count > 0)
            {
                tagBuilder.AddCssClass(
                    System.Web.Mvc.HtmlHelper.ValidationInputCssClassName);
            }

            tagBuilder.MergeAttributes(
                html.GetUnobtrusiveValidationAttributes(name, modelMetadata));

            string value;

            if (modelState?.Value != null)
            {
                value = modelState.Value.AttemptedValue;
            }
            else if (modelMetadata.Model != null)
            {
                value = modelMetadata.Model.ToString();
            }
            else
            {
                value = string.Empty;
            }

            tagBuilder.InnerHtml = Environment.NewLine
                                   + HttpUtility.HtmlEncode(value);

            var script = new TagBuilder("script")
            {
                InnerHtml =
                    $"CKEDITOR.replace(\"{tagBuilder.Attributes["id"]}\")"
            };

            return MvcHtmlString.Create(tagBuilder.ToString() + script);
        }
    }
}