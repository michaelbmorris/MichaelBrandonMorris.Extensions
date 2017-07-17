using System.Web.Mvc;
using System.Web.Mvc.Html;

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
    }
}