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
                    @class = $"btn {ContextualClasses[contextualClass]}"
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
                new
                {
                    @class = $"btn {ContextualClasses[contextualClass]}"
                });
        }
    }
}