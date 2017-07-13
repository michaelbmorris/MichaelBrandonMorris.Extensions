using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper
{
    public static partial class HtmlHelperExtensions
    {
        /// <summary>
        ///     Editors for many.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="indexResolverExpression">
        ///     The index resolver
        ///     expression.
        /// </param>
        /// <param name="includeIndexField">
        ///     if set to <c>true</c>
        ///     [include index field].
        /// </param>
        /// <returns>MvcHtmlString.</returns>
        /// <exception cref="Exception"></exception>
        /// TODO Edit XML Comment Template for EditorForMany`2
        public static MvcHtmlString EditorForMany<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, IEnumerable<TValue>>> propertyExpression,
            Expression<Func<TValue, string>> indexResolverExpression = null,
            bool includeIndexField = true)
            where TModel : class
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
        ///     Editors for many index field.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="indexResolverExpression">
        ///     The index resolver
        ///     expression.
        /// </param>
        /// <returns>MvcHtmlString.</returns>
        /// <exception cref="InvalidOperationException">
        ///     EditorForManyIndexField
        ///     called when not in a EditorForMany context
        /// </exception>
        /// TODO Edit XML Comment Template for EditorForManyIndexField`1
        public static MvcHtmlString EditorForManyIndexField<TModel>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, string>> indexResolverExpression = null)
        {
            var htmlPrefix = html.ViewData.TemplateInfo.HtmlFieldPrefix;
            var first = htmlPrefix.LastIndexOf('[');
            var last = htmlPrefix.IndexOf(']', first + 1);

            if (first == -1
                || last == -1)
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

        /// <summary>
        ///     Editors for many index field.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <param name="htmlFieldNameWithPrefix">
        ///     The HTML field name
        ///     with prefix.
        /// </param>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="indexResolverExpression">
        ///     The index resolver
        ///     expression.
        /// </param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for _EditorForManyIndexField`1
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