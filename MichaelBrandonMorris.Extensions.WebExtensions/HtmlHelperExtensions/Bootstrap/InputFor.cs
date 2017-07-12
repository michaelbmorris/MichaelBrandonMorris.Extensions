using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.WebExtensions.HtmlHelperExtensions.Bootstrap
{
    public static partial class InputExtensions
    {
        private const string DropDownListClasses = "form-control";
        private const string LabelClasses = "control-label";
        private const string PasswordClasses = "form-control";
        private const string Required = "required";
        private const string TextBoxClasses = "form-control";
        private const string ValidationMessageClasses = "text-danger";

        private static MvcHtmlString InputFor
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
                + $"{input}"
                + $"{validationMessage}"
                + "</div>");
        }
    }
}
