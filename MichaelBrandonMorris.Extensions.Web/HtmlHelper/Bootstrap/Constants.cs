using System.Collections.Generic;

namespace MichaelBrandonMorris.Extensions.Web.HtmlHelper.Bootstrap
{
    public enum ContextualColor
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
        internal static Dictionary<ContextualColor, string>
            ContextualColors => new Dictionary<ContextualColor, string
        >
        {
            {
                ContextualColor.Default, "default"
            },
            {
                ContextualColor.Muted, "muted"
            },
            {
                ContextualColor.Primary, "primary"
            },
            {
                ContextualColor.Info, "info"
            },
            {
                ContextualColor.Warning, "warning"
            },
            {
                ContextualColor.Danger, "danger"
            }
        };

        internal static Dictionary<TargetAttribute, string> TargetAttributes => new Dictionary<TargetAttribute, string>
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
    }
}