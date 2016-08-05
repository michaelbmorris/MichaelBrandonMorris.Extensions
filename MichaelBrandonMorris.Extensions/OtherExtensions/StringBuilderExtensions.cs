using System.Text;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.OtherExtensions
{
    /// <summary>
    ///     Provides useful extensions for the <see cref="StringBuilder" /> 
    ///     class.
    /// </summary>
    public static class StringBuilderExtensions
    {
        private const char Comma = ',';
        private const char Quote = '"';

        /// <summary>
        ///     Appends a string to the <see cref="StringBuilder" />, wrapping 
        ///     it in quotes and adding a comma to the end for use in a .csv 
        ///     file.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="s">The string to append.</param>
        public static void AppendCsv(
            this StringBuilder stringBuilder, string s)
        {
            stringBuilder.Append(s.Wrap(Quote) + Comma);
        }

        /// <summary>
        ///     Appends a string to the <see cref="StringBuilder" />, wrapping 
        ///     it in quotes and adding a newline to the end for use in a .csv 
        ///     file.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="s">The string to append.</param>
        public static void AppendLineCsv(
            this StringBuilder stringBuilder, string s)
        {
            stringBuilder.AppendLine(s.Wrap(Quote));
        }
    }
}