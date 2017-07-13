using System.Web;
using System.Web.Mvc;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper
{
    public static partial class HtmlHelperExtensions
    {
        /// <summary>
        ///     Attributes the specified name.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <returns>MvcHtmlString.</returns>
        /// TODO Edit XML Comment Template for Attribute
        public static MvcHtmlString Attribute(
            this System.Web.Mvc.HtmlHelper html,
            string name,
            string value,
            bool? condition)
        {
            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(value))
            {
                return MvcHtmlString.Empty;
            }

            var render = condition ?? true;
            value = HttpUtility.HtmlAttributeEncode(value);

            return render
                ? new MvcHtmlString($"{name}=\"{value}\"")
                : MvcHtmlString.Empty;
        }
    }
}