using System.Text;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.OtherExtensions
{
    /// <summary>
    ///     Class StringBuilderExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for StringBuilderExtensions
    public static class StringBuilderExtensions
    {
        /// <summary>
        ///     The comma
        /// </summary>
        /// TODO Edit XML Comment Template for Comma
        private const char Comma = ',';

        /// <summary>
        ///     The quote
        /// </summary>
        /// TODO Edit XML Comment Template for Quote
        private const char Quote = '"';

        /// <summary>
        ///     Appends the CSV.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="s">The s.</param>
        /// TODO Edit XML Comment Template for AppendCsv
        public static void AppendCsv(this StringBuilder stringBuilder, string s)
        {
            stringBuilder.Append(s.Wrap(Quote) + Comma);
        }

        /// <summary>
        ///     Appends the line CSV.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="s">The s.</param>
        /// TODO Edit XML Comment Template for AppendLineCsv
        public static void AppendLineCsv(
            this StringBuilder stringBuilder,
            string s)
        {
            stringBuilder.AppendLine(s.Wrap(Quote));
        }
    }
}