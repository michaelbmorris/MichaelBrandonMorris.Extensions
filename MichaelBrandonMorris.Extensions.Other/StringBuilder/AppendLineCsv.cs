using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.OtherExtensions.StringBuilder
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        ///     Appends the line CSV.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="s">The s.</param>
        /// TODO Edit XML Comment Template for AppendLineCsv
        public static void AppendLineCsv(
            this System.Text.StringBuilder stringBuilder,
            string s)
        {
            stringBuilder.AppendLine(s.Wrap(DoubleQuote));
        }
    }
}