using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PrimitiveExtensions
{
    public static class CharExtensions
    {
        public static double GetNumericValue(this char c)
        {
            return char.GetNumericValue(c);
        }

        public static UnicodeCategory GetUnicodeCategory(this char c)
        {
            return char.GetUnicodeCategory(c);
        }

        public static bool EqualsAny(this char c, IEnumerable<char> characters)
        {
            return characters.Any(c.Equals);
        }

        public static bool IsControl(this char c)
        {
            return char.IsControl(c);
        }

        public static bool IsDigit(this char c)
        {
            return char.IsDigit(c);
        }

        public static bool IsHighSurrogate(this char c)
        {
            return char.IsHighSurrogate(c);
        }

        public static bool IsLetter(this char c)
        {
            return char.IsLetter(c);
        }

        public static bool IsLetterOrDigit(this char c)
        {
            return char.IsLetterOrDigit(c);
        }

        public static bool IsLower(this char c)
        {
            return char.IsLower(c);
        }

        public static bool IsLowSurrogate(this char c)
        {
            return char.IsLowSurrogate(c);
        }

        public static bool IsNumber(this char c)
        {
            return char.IsNumber(c);
        }

        public static bool IsPunctuation(this char c)
        {
            return char.IsPunctuation(c);
        }

        public static bool IsSeparator(this char c)
        {
            return char.IsSeparator(c);
        }

        public static bool IsSurrogate(this char c)
        {
            return char.IsSurrogate(c);
        }

        public static bool IsSymbol(this char c)
        {
            return char.IsSymbol(c);
        }

        public static bool IsUpper(this char c)
        {
            return char.IsUpper(c);
        }

        public static bool IsWhiteSpace(this char c)
        {
            return char.IsWhiteSpace(c);
        }

        public static char ToLower(this char c)
        {
            return char.ToLower(c);
        }

        public static char ToLower(this char c, CultureInfo culture)
        {
            return char.ToLower(c, culture);
        }

        public static char ToLowerInvariant(this char c)
        {
            return char.ToLowerInvariant(c);
        }

        public static char ToUpper(this char c)
        {
            return char.ToUpper(c);
        }

        public static char ToUpper(this char c, CultureInfo culture)
        {
            return char.ToUpper(c, culture);
        }

        public static char ToUpperInvariant(this char c)
        {
            return char.ToUpper(c);
        }
    }
}