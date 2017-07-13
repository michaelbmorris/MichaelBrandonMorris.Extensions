using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Horizontal
{
    public static partial class InputExtensions
    {
        private const string DropDownListClasses = "form-control";

        public static MvcHtmlString DropDownListFor<TModel, TValue>(
                this HtmlHelper<TModel> html,
                Expression<Func<TModel, TValue>> expression,
                IEnumerable<SelectListItem> selectList)
        {
            var dropDownList = html.DropDownListFor(
                expression,
                selectList,
                new
                {
                    @class = DropDownListClasses
                });

            return html.InputFor(expression, dropDownList);
        }

        public static MvcHtmlString DropDownListFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression,
            IEnumerable<SelectListItem> selectList,
            string optionLabel)
        {
            var dropDownList = html.DropDownListFor(
                expression,
                selectList,
                optionLabel,
                new
                {
                    @class = DropDownListClasses
                });

            return html.InputFor(expression, dropDownList);
        }
    }
}