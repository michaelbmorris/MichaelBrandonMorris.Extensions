using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.OtherExtensions
{
    /// <summary>
    /// Provides useful extensions for the <see cref="HtmlHelper{TModel}" /> class.
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Renders a HTML attribute with the specified name and value if the
        /// condition is true.
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static MvcHtmlString Attribute(
            this HtmlHelper helper,
            string name,
            string value,
            bool? condition)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(value))
            {
                return MvcHtmlString.Empty;
            }

            var render = condition ?? true;
            value = HttpUtility.HtmlAttributeEncode(value);

            return render
                ? new MvcHtmlString($"{name}=\"{value}\"")
                : MvcHtmlString.Empty;
        }

        /// <summary>
        /// Allows using <see cref="DisplayFor{TModel,TValue}" /> without an
        /// expression.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="html"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MvcHtmlString DisplayFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            TValue value)
        {
            return html.DisplayFor(x => value);
        }

        /// <summary>
        /// Created by @mattlunn on GitHub at
        /// https://github.com/mattlunn/DynamicListBinding. Creates HTML
        /// editors for a list of properties.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="html"></param>
        /// <param name="propertyExpression"></param>
        /// <param name="indexResolverExpression"></param>
        /// <param name="includeIndexField"></param>
        /// <returns></returns>
        public static MvcHtmlString EditorForMany<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, IEnumerable<TValue>>> propertyExpression,
            Expression<Func<TValue, string>> indexResolverExpression = null,
            bool includeIndexField = true) where TModel : class
        {
            var items = propertyExpression.Compile()(html.ViewData.Model);
            var htmlBuilder = new StringBuilder();

            var htmlFieldName =
                ExpressionHelper.GetExpressionText(propertyExpression);

            var htmlFieldNameWithPrefix =
                html.ViewData.TemplateInfo.GetFullHtmlFieldName(htmlFieldName);

            var indexResolver = indexResolverExpression?.Compile()
                                ?? (x => null);

            foreach (var item in items)
            {
                var dummy = new
                {
                    Item = item
                };

                var member = dummy.GetType().GetProperty("Item");

                if (member == null)
                {
                    throw new Exception();
                }

                var memberExp = Expression.MakeMemberAccess(
                    Expression.Constant(dummy),
                    member);

                var singleItemExp = Expression.Lambda<Func<TModel, TValue>>(
                    memberExp,
                    propertyExpression.Parameters);

                var guid = indexResolver(item);

                guid = string.IsNullOrEmpty(guid)
                    ? Guid.NewGuid().ToString()
                    : html.AttributeEncode(guid);

                if (includeIndexField)
                {
                    htmlBuilder.Append(
                        _EditorForManyIndexField(
                            htmlFieldNameWithPrefix,
                            guid,
                            indexResolverExpression));
                }

                htmlBuilder.Append(
                    html.EditorFor(
                        singleItemExp,
                        null,
                        $"{htmlFieldName}[{guid}]"));
            }

            return new MvcHtmlString(htmlBuilder.ToString());
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="html"></param>
        /// <param name="indexResolverExpression"></param>
        /// <returns></returns>
        public static MvcHtmlString EditorForManyIndexField<TModel>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, string>> indexResolverExpression = null)
        {
            var htmlPrefix = html.ViewData.TemplateInfo.HtmlFieldPrefix;
            var first = htmlPrefix.LastIndexOf('[');
            var last = htmlPrefix.IndexOf(']', first + 1);

            if (first == -1 || last == -1)
            {
                throw new InvalidOperationException(
                    "EditorForManyIndexField called when not in a EditorForMany context");
            }

            var htmlFieldNameWithPrefix = htmlPrefix.Substring(0, first);
            var guid = htmlPrefix.Substring(first + 1, last - first - 1);

            return _EditorForManyIndexField(
                htmlFieldNameWithPrefix,
                guid,
                indexResolverExpression);
        }

        private static MvcHtmlString _EditorForManyIndexField<TModel>(
            string htmlFieldNameWithPrefix,
            string guid,
            Expression<Func<TModel, string>> indexResolverExpression)
        {
            var htmlBuilder = new StringBuilder();
            htmlBuilder.AppendFormat(
                @"<input type=""hidden"" name=""{0}.Index"" value=""{1}"" />",
                htmlFieldNameWithPrefix,
                guid);

            if (indexResolverExpression != null)
            {
                htmlBuilder.AppendFormat(
                    @"<input type=""hidden"" name=""{0}[{1}].{2}"" value=""{1}"" />",
                    htmlFieldNameWithPrefix,
                    guid,
                    ExpressionHelper
                        .GetExpressionText(indexResolverExpression));
            }

            return new MvcHtmlString(htmlBuilder.ToString());
        }
    }
}