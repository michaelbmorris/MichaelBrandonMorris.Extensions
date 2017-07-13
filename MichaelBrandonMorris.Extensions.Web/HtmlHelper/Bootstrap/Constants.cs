using System.Collections.Generic;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap
{
    public enum BootstrapContextualClass
    {
        Default,
        Muted,
        Primary,
        Success,
        Info,
        Warning,
        Danger
    }

    public static partial class BootstrapExtensions
    {
        private static Dictionary<BootstrapContextualClass, string>
            ContextualClasses => new Dictionary<BootstrapContextualClass, string
        >
        {
            {
                BootstrapContextualClass.Default, "default"
            },
            {
                BootstrapContextualClass.Muted, "muted"
            },
            {
                BootstrapContextualClass.Primary, "primary"
            },
            {
                BootstrapContextualClass.Info, "info"
            },
            {
                BootstrapContextualClass.Warning, "warning"
            },
            {
                BootstrapContextualClass.Danger, "danger"
            }
        };

        internal static string GetContextualClass(
            BootstrapContextualClass contextualClass)
        {
            return ContextualClasses[contextualClass];
        }
    }
}