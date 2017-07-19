using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap
{
    public static partial class BootstrapExtensions
    {
        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName)
        {
            return html.BootstrapActionLinkButton(linkText, actionName, null);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            BootstrapContextualClass contextualClass)
        {
            return html.BootstrapActionLinkButton(
                linkText,
                actionName,
                null,
                contextualClass);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            object routeValues)
        {
            return html.BootstrapActionLinkButton(
                linkText,
                actionName,
                routeValues,
                BootstrapContextualClass.Default);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            object routeValues,
            BootstrapContextualClass contextualClass)
        {
            return html.ActionLink(
                linkText,
                actionName,
                routeValues,
                new
                {
                    @class = $"btn btn-{ContextualClasses[contextualClass]}"
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName)
        {
            return html.BootstrapActionLinkButton(
                linkText,
                actionName,
                controllerName,
                BootstrapContextualClass.Default);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName,
            BootstrapContextualClass contextualClass)
        {
            return html.BootstrapActionLinkButton(
                linkText,
                actionName,
                controllerName,
                null,
                contextualClass);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName,
            object routeValues)
        {
            return html.BootstrapActionLinkButton(
                linkText,
                actionName,
                controllerName,
                routeValues,
                BootstrapContextualClass.Default);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName,
            object routeValues,
            BootstrapContextualClass contextualClass)
        {
            return html.ActionLink(
                linkText,
                actionName,
                controllerName,
                routeValues,
                new
                {
                    @class = $"btn btn-{ContextualClasses[contextualClass]}"
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            object routeValues,
            BootstrapContextualClass contextualClass)
        {
            return html.ActionLink(
                actionName,
                actionName,
                routeValues,
                new
                {
                    @class = $"btn btn-{GetContextualClass(contextualClass)}"
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            object routeValues,
            BootstrapContextualClass contextualClass,
            TargetAttribute targetAttribute)
        {
            return html.ActionLink(
                actionName,
                actionName,
                routeValues,
                new
                {
                    @class = $"btn btn-{GetContextualClass(contextualClass)}",
                    target = GetTargetAttribute(targetAttribute)
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            string controllerName,
            RouteValueDictionary routeValues,
            BootstrapContextualClass contextualClass)
        {
            var htmlAttributes = new Dictionary<string, object>
            {
                {
                    "class", $"btn btn-{GetContextualClass(contextualClass)}"
                }
            };

            return html.ActionLink(
                actionName,
                actionName,
                controllerName,
                routeValues,
                htmlAttributes);
        }

        /// <summary>
        ///     Creates a Bootstrap-styled button for a Html.ActionLink with the specified action name and contextual class. The action name is used as the link text.
        /// </summary>
        /// <param name="html">The HTML helper.</param>
        /// <param name="actionName">Name of the action.</param>
        /// <param name="contextualClass">The Bootstrap contextual class.</param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for BootstrapActionLinkButton
        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            BootstrapContextualClass contextualClass = BootstrapContextualClass.Default,
            TargetAttribute targetAttribute = TargetAttribute.Self)
        {
            return html.ActionLink(
                actionName,
                actionName,
                null,
                new
                {
                    @class = $"btn btn-{GetContextualClass(contextualClass)}",
                    target = GetTargetAttribute(targetAttribute)
                });
        }

        /// <summary>
        /// Creates a Bootstrap-styled button for a Html.ActionLink with the specified action name, id parameter, and contextual class. The action name is used as the link text.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <param name="actionName">Name of the action.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="contextualClass">The contextual class.</param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for BootstrapActionLinkButton
        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            int id,
            BootstrapContextualClass contextualClass = BootstrapContextualClass.Default,
            TargetAttribute targetAttribute = TargetAttribute.Self)
        {
            return html.ActionLink(
                actionName,
                actionName,
                new
                {
                    id
                },
                new
                {
                    @class = $"btn btn-{GetContextualClass(contextualClass)}",
                    target = GetTargetAttribute(targetAttribute)
                });
        }
    }
}