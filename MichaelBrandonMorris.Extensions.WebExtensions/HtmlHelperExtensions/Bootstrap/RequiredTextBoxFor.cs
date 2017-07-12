using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.WebExtensions.HtmlHelperExtensions.
    Bootstrap
{
    public static class BootstrapHtmlHelperExtensions
    {
        private const string LabelClasses = "control-label col-md-2";
        private const string Required = "required";
        private const string TextBoxClasses = "form-control";
        private const string ValidationMessageClasses = "text-danger";

        public static MvcHtmlString RequiredTextBoxFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression)
        {
            var label = html.LabelFor(
                expression,
                new
                {
                    @class = LabelClasses
                });

            var textBox = html.TextBoxFor(
                expression,
                new
                {
                    @class = TextBoxClasses,
                    required = Required
                });

            var validationMessage = html.ValidationMessageFor(
                expression,
                string.Empty,
                new
                {
                    @class = ValidationMessageClasses
                });

            return MvcHtmlString.Create(
                "<div class=\"form-group\">"
                + $"{label}"
                + "<div class=\"col-md-10\">"
                + $"{textBox}"
                + $"{validationMessage}"
                + "</div>"
                + "</div>");
        }
    }
}