using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.Horizontal
{
    public static partial class InputExtensions
    {
        public enum BootstrapContextualClass
        {
            Default,
            Muted,
            Primary,
            Success,
            Info,
            Warning,
            Danger
        }

        internal const string LabelClasses = "control-label col-md-2";
        private const string PasswordClasses = "form-control";
        private const string Required = "required";
        private const string TextBoxClasses = "form-control";
        private const string ValidationMessageClasses = "text-danger";

        internal static MvcHtmlString BootstrapHorizontalInputFor
            <TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression,
                MvcHtmlString input)
        {
            var label = html.LabelFor(
                expression,
                new
                {
                    @class = LabelClasses
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
                + $"{input}"
                + $"{validationMessage}"
                + "</div>"
                + "</div>");
        }
    }
}
