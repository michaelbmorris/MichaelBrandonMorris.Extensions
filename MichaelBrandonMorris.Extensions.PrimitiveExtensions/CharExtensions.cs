using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MichaelBrandonMorris.Extensions.PrimitiveExtensions
{
    /// <summary>
    ///     Class CharExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for CharExtensions
    public static class CharExtensions
    {
        /// <summary>
        ///     The alphanumeric characters
        /// </summary>
        /// TODO Edit XML Comment Template for AlphanumericCharacters
        public static readonly char[] AlphanumericCharacters =
        {
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z',
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            '0'
        };

        /// <summary>
        ///     Equalses any.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="characters">The characters.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for EqualsAny
        public static bool EqualsAny(this char c, IEnumerable<char> characters)
        {
            return characters.Any(c.Equals);
        }

        /// <summary>
        ///     Gets the numeric value.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for GetNumericValue
        public static double GetNumericValue(this char c)
        {
            return char.GetNumericValue(c);
        }

        /// <summary>
        ///     Gets the unicode category.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>UnicodeCategory.</returns>
        /// TODO Edit XML Comment Template for GetUnicodeCategory
        public static UnicodeCategory GetUnicodeCategory(this char c)
        {
            return char.GetUnicodeCategory(c);
        }

        /// <summary>
        ///     Determines whether the specified c is control.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is control;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsControl
        public static bool IsControl(this char c)
        {
            return char.IsControl(c);
        }

        /// <summary>
        ///     Determines whether the specified c is digit.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is digit;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsDigit
        public static bool IsDigit(this char c)
        {
            return char.IsDigit(c);
        }

        /// <summary>
        ///     Determines whether [is high surrogate] [the specified
        ///     c].
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if [is high surrogate] [the specified
        ///     c]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsHighSurrogate
        public static bool IsHighSurrogate(this char c)
        {
            return char.IsHighSurrogate(c);
        }

        /// <summary>
        ///     Determines whether the specified c is letter.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is letter;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLetter
        public static bool IsLetter(this char c)
        {
            return char.IsLetter(c);
        }

        /// <summary>
        ///     Determines whether [is letter or digit] [the specified
        ///     c].
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if [is letter or digit] [the specified
        ///     c]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLetterOrDigit
        public static bool IsLetterOrDigit(this char c)
        {
            return char.IsLetterOrDigit(c);
        }

        /// <summary>
        ///     Determines whether the specified c is lower.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is lower;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLower
        public static bool IsLower(this char c)
        {
            return char.IsLower(c);
        }

        /// <summary>
        ///     Determines whether [is low surrogate] [the specified
        ///     c].
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if [is low surrogate] [the specified
        ///     c]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLowSurrogate
        public static bool IsLowSurrogate(this char c)
        {
            return char.IsLowSurrogate(c);
        }

        /// <summary>
        ///     Determines whether the specified c is number.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is number;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNumber
        public static bool IsNumber(this char c)
        {
            return char.IsNumber(c);
        }

        /// <summary>
        ///     Determines whether the specified c is punctuation.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is punctuation;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsPunctuation
        public static bool IsPunctuation(this char c)
        {
            return char.IsPunctuation(c);
        }

        /// <summary>
        ///     Determines whether the specified c is separator.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is separator;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsSeparator
        public static bool IsSeparator(this char c)
        {
            return char.IsSeparator(c);
        }

        /// <summary>
        ///     Determines whether the specified c is surrogate.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is surrogate;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsSurrogate
        public static bool IsSurrogate(this char c)
        {
            return char.IsSurrogate(c);
        }

        /// <summary>
        ///     Determines whether the specified c is symbol.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is symbol;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsSymbol
        public static bool IsSymbol(this char c)
        {
            return char.IsSymbol(c);
        }

        /// <summary>
        ///     Determines whether the specified c is upper.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if the specified c is upper;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsUpper
        public static bool IsUpper(this char c)
        {
            return char.IsUpper(c);
        }

        /// <summary>
        ///     Determines whether [is white space] [the specified c].
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///     <c>true</c> if [is white space] [the specified c];
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsWhiteSpace
        public static bool IsWhiteSpace(this char c)
        {
            return char.IsWhiteSpace(c);
        }

        /// <summary>
        ///     To the lower.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ToLower
        public static char ToLower(this char c)
        {
            return char.ToLower(c);
        }

        /// <summary>
        ///     To the lower.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ToLower
        public static char ToLower(this char c, CultureInfo culture)
        {
            return char.ToLower(c, culture);
        }

        /// <summary>
        ///     To the lower invariant.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ToLowerInvariant
        public static char ToLowerInvariant(this char c)
        {
            return char.ToLowerInvariant(c);
        }

        /// <summary>
        ///     To the upper.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ToUpper
        public static char ToUpper(this char c)
        {
            return char.ToUpper(c);
        }

        /// <summary>
        ///     To the upper.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ToUpper
        public static char ToUpper(this char c, CultureInfo culture)
        {
            return char.ToUpper(c, culture);
        }

        /// <summary>
        ///     To the upper invariant.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ToUpperInvariant
        public static char ToUpperInvariant(this char c)
        {
            return char.ToUpper(c);
        }
    }
}