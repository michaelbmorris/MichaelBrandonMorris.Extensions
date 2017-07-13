
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.OtherExtensions.StringBuilder
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        ///     Appends the CSV.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="s">The s.</param>
        /// TODO Edit XML Comment Template for AppendCsv
        public static void AppendCsv(
            this System.Text.StringBuilder stringBuilder,
            string s)
        {
            stringBuilder.Append(s.Wrap(DoubleQuote) + Comma);
        }
    }
}