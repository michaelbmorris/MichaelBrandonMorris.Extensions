using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap.Display
{
    public static partial class DisplayExtensions
    {
        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            ContextualColor contextualColor =
                ContextualColor.Default,
            TargetAttribute targetAttribute = TargetAttribute.Self)
        {
            return html.ActionLink(
                linkText,
                actionName,
                null,
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}"
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            int id,
            ContextualColor contextualColor = ContextualColor.Default)
        {
            return html.ActionLink(
                linkText,
                actionName,
                new
                {
                    id
                },
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}"
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName,
            int id,
            ContextualColor contextualColor = ContextualColor.Default)
        {
            return html.ActionLink(
                linkText,
                actionName,
                controllerName,
                new
                {
                    id
                },
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}"
                });
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
                ContextualColor.Default);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            object routeValues,
            ContextualColor contextualColor)
        {
            return html.ActionLink(
                linkText,
                actionName,
                routeValues,
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}"
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
                ContextualColor.Default);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName,
            ContextualColor contextualColor)
        {
            return html.BootstrapActionLinkButton(
                linkText,
                actionName,
                controllerName,
                null,
                contextualColor);
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
                ContextualColor.Default);
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string linkText,
            string actionName,
            string controllerName,
            object routeValues,
            ContextualColor contextualColor)
        {
            return html.ActionLink(
                linkText,
                actionName,
                controllerName,
                routeValues,
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}"
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            object routeValues,
            ContextualColor contextualColor)
        {
            return html.ActionLink(
                actionName,
                actionName,
                routeValues,
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}"
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            object routeValues,
            ContextualColor contextualColor,
            TargetAttribute targetAttribute)
        {
            return html.ActionLink(
                actionName,
                actionName,
                routeValues,
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}",
                    target = Bootstrap.BootstrapExtensions.TargetAttributes[targetAttribute]
                });
        }

        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            string controllerName,
            RouteValueDictionary routeValues,
            ContextualColor contextualColor)
        {
            var htmlAttributes = new Dictionary<string, object>
            {
                {
                    "class", $"btn btn-{ContextualColors[contextualColor]}"
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
        ///     Creates a Bootstrap-styled button for a Html.ActionLink
        ///     with the specified action name and contextual class.
        ///     The action name is used as the link text.
        /// </summary>
        /// <param name="html">The HTML helper.</param>
        /// <param name="actionName">Name of the action.</param>
        /// <param name="contextualColor">
        ///     The Bootstrap contextual
        ///     class.
        /// </param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for BootstrapActionLinkButton
        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            ContextualColor contextualColor =
                ContextualColor.Default,
            TargetAttribute targetAttribute = TargetAttribute.Self)
        {
            return html.ActionLink(
                actionName,
                actionName,
                null,
                new
                {
                    @class = $"btn btn-{ContextualColors[contextualColor]}",
                    target = Bootstrap.BootstrapExtensions.TargetAttributes[targetAttribute]
                });
        }

        /// <summary>
        ///     Creates a Bootstrap-styled button for a Html.ActionLink
        ///     with the specified action name, id parameter, and
        ///     contextual class. The action name is used as the link
        ///     text.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <param name="actionName">Name of the action.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="contextualColor">The contextual class.</param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for BootstrapActionLinkButton
        public static MvcHtmlString BootstrapActionLinkButton(
            this System.Web.Mvc.HtmlHelper html,
            string actionName,
            int id,
            ContextualColor contextualColor =
                ContextualColor.Default,
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
                    @class = $"btn btn-{ContextualColors[contextualColor]}",
                    target = Bootstrap.BootstrapExtensions.TargetAttributes[targetAttribute]
                });
        }
    }
}