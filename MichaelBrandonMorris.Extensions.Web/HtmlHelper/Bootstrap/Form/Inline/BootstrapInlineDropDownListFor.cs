using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Form.Inline
{
    public static partial class InputExtensions
    {
        private const string Class = "class";

        public static MvcHtmlString BootstrapInlineDropDownListFor
            <TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression,
                IEnumerable<SelectListItem> selectList,
                string optionLabel,
                IDictionary<string, object> htmlAttributes)
        {
            if (htmlAttributes.ContainsKey(Class))
            {
                htmlAttributes[Class] += " form-control";
            }
            else
            {
                htmlAttributes.Add(Class, "form-control");
            }

            var dropDownList = html.DropDownListFor(
                expression,
                selectList,
                optionLabel,
                htmlAttributes);

            return MvcHtmlString.Create(
                "<div class=\"form-group\">" + dropDownList + "</div>");
        }
    }
}