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

    public enum TargetAttribute
    {
        Self,
        Blank,
        Parent,
        Top
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

        private static Dictionary<TargetAttribute, string> TargetAttributes => new Dictionary<TargetAttribute, string>
        {
            {
                TargetAttribute.Self, "_self"
            },
            {
                TargetAttribute.Blank, "_blank"
            },
            {
                TargetAttribute.Parent, "_parent"
            },
            {
                TargetAttribute.Top, "_top"
            }
        };

        internal static string GetTargetAttribute(
            TargetAttribute targetAttribute)
        {
            return TargetAttributes[targetAttribute];
        }

        internal static string GetContextualClass(
            BootstrapContextualClass contextualClass)
        {
            return ContextualClasses[contextualClass];
        }
    }
}