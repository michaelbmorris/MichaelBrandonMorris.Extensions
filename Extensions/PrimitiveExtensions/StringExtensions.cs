using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Extensions.PrimitiveExtensions
{
    /// <summary>
    /// Provides useful extension methods for the <see cref="string"/> class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Compares this <see cref="string"/> with another 
        /// <see cref="string"/> and returns an <see cref="int"/> that 
        /// indicates their relative position in the sort order.
        /// </summary>
        public static int Compare(this string s1, string s2)
        {
            // ReSharper disable once StringCompareIsCultureSpecific.1
            return string.Compare(s1, s2);
        }

        /// <summary>
        /// Compares this <see cref="string"/> with another 
        /// <see cref="string"/>, ignoring or honoring their case, and returns 
        /// an integer that indicates their relative position in the sort 
        /// order.
        /// </summary>
        public static int Compare(this string s1, string s2, bool ignoreCase)
        {
            return string.Compare(s1, s2, ignoreCase);
        }

        /// <summary>
        /// Compares this <see cref="string"/> with another 
        /// <see cref="string"/>, ignoring or honoring their case, and using 
        /// culture-specific information to influence the comparison, and 
        /// returns an integer that indicates their relative position in the 
        /// sort order.
        /// </summary>
        public static int Compare(
            this string s1, string s2, bool ignoreCase, CultureInfo culture)
        {
            return string.Compare(s1, s2, ignoreCase, culture);
        }

        /// <summary>
        /// Compares this <see cref="string"/> with another 
        /// <see cref="string"/> using the specified comparison options and 
        /// culture-specific information to influence the comparison, and 
        /// returns an <see cref="int"/> that indicates the relationship of the
        ///  two <see cref="string"/>s to each other in the sort order.
        /// </summary>
        public static int Compare(
            this string s1,
            string s2,
            CultureInfo culture,
            CompareOptions options)
        {
            return string.Compare(s1, s2, culture, options);
        }

        /// <summary>
        /// Compares this <see cref="string"/> with another 
        /// <see cref="string"/> using the specified rules, and returns an 
        /// <see cref="int"/> that indicates their relative position in the 
        /// sort order.
        /// </summary>
        public static int Compare(
            this string s1, string s2, StringComparison comparisonType)
        {
            return string.Compare(s1, s2, comparisonType);
        }

        /// <summary>
        /// Compares this <see cref="string"/> with another 
        /// <see cref="string"/> using <see cref="StringComparison.Ordinal"/> 
        /// and returns an <see cref="int"/> that indicates their relative 
        /// position in the sort order.
        /// </summary>
        public static int CompareOrdinal(this string s1, string s2)
        {
            return string.CompareOrdinal(s1, s2);
        }

        public static bool ContainsIgnoreCase(this string s1, string s2)
        {
            return s1.IndexOfOrdinalIgnoreCase(s2) >= 0;
        }

        public static int ConvertToUtf32(this string s, int index)
        {
            return char.ConvertToUtf32(s, index);
        }

        public static string Copy(this string s)
        {
            return string.Copy(s);
        }

        public static bool EqualsCurrentCulture(this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.CurrentCulture);
        }

        public static bool EqualsCurrentCultureIgnoreCase(
            this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool EqualsInvariantCulture(this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.InvariantCulture);
        }

        public static bool EqualsInvariantCultureIgnoreCase(
            this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool EqualsOrdinal(this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.Ordinal);
        }

        public static bool EqualsOrdinalIgnoreCase(this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
        }

        public static double GetNumericValue(this string s, int index)
        {
            return char.GetNumericValue(s, index);
        }

        public static UnicodeCategory GetUnicodeCategory(
            this string s, int index)
        {
            return char.GetUnicodeCategory(s, index);
        }

        public static int IndexOfOrdinal(this string s1, string s2)
        {
            return s1.IndexOf(s2, StringComparison.Ordinal);
        }

        public static int IndexOfOrdinalIgnoreCase(this string s1, string s2)
        {
            return s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsControl(this string s, int index)
        {
            return char.IsControl(s, index);
        }

        public static bool IsDigit(this string s, int index)
        {
            return char.IsDigit(s, index);
        }

        public static bool IsHighSurrogate(this string s, int index)
        {
            return char.IsHighSurrogate(s, index);
        }

        public static bool IsLetter(this string s, int index)
        {
            return char.IsLetter(s, index);
        }

        public static bool IsLetterOrDigit(this string s, int index)
        {
            return char.IsLetterOrDigit(s, index);
        }

        public static bool IsLower(this string s, int index)
        {
            return char.IsLower(s, index);
        }

        public static bool IsLowSurrogate(this string s, int index)
        {
            return char.IsLowSurrogate(s, index);
        }

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool IsNumber(this string s, int index)
        {
            return char.IsNumber(s, index);
        }

        public static bool IsPunctuation(this string s, int index)
        {
            return char.IsPunctuation(s, index);
        }

        public static bool IsSeparator(this string s, int index)
        {
            return char.IsSeparator(s, index);
        }

        public static bool IsSurrogate(this string s, int index)
        {
            return char.IsSurrogate(s, index);
        }

        public static bool IsSurrogatePair(this string s, int index)
        {
            return char.IsSurrogatePair(s, index);
        }

        public static bool IsSymbol(this string s, int index)
        {
            return char.IsSymbol(s, index);
        }

        public static bool IsUpper(this string s, int index)
        {
            return char.IsUpper(s, index);
        }

        public static bool IsWhiteSpace(this string s, int index)
        {
            return char.IsWhiteSpace(s, index);
        }

        public static bool IsWhiteSpace(this string s)
        {
            return s.All(c => c.IsWhiteSpace());
        }

        public static string Remove(this string s, char c)
        {
            return s.Replace(c.ToString(), string.Empty);
        }

        public static string Remove(this string s1, string s2)
        {
            if (s1.IsNullOrWhiteSpace())
                return string.Empty;
            return s1.Replace(s2, string.Empty);
        }

        public static string RemoveAll(
            this string s, IEnumerable<char> characters)
        {
            return characters.Aggregate(
                s, (current, character) => current.Remove(character));
        }

        public static string RemoveAllBut(
            this string s, IEnumerable<char> characters)
        {
            return new string(s.Where(c => c.EqualsAny(characters)).ToArray());
        }

        public static string SpaceCamelCase(this string s)
        {
            return Regex.Replace(
                Regex.Replace(
                    s, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"),
                @"(\p{Ll})(\P{Ll})", "$1 $2");
        }

        public static string SubstringAtIndexOfOrdinal(
            this string s1, string s2)
        {
            return s1.Substring(s1.IndexOfOrdinal(s2));
        }

        public static string SubstringAtIndexOfOrdinalIgnoreCase(
            this string s1, string s2)
        {
            return s1.Substring(s1.IndexOfOrdinalIgnoreCase(s2));
        }

        public static bool ToBool(this string s)
        {
            return s.ParseBool();
        }

        public static byte ToByte(this string s)
        {
            return s.ParseByte();
        }

        public static byte ToByte(this string s, IFormatProvider provider)
        {
            return s.ParseByte(provider);
        }

        public static byte ToByte(this string s, NumberStyles style)
        {
            return s.ParseByte(style);
        }

        public static byte ToByte(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return s.ParseByte(style, provider);
        }

        public static char ToChar(this string s)
        {
            return s.ParseChar();
        }

        public static DateTime ToDateTime(this string s)
        {
            return s.ParseDateTime();
        }

        public static DateTime ToDateTime(
            this string s, IFormatProvider provider)
        {
            return s.ParseDateTime(provider);
        }

        public static DateTime ToDateTime(
            this string s, IFormatProvider provider, DateTimeStyles style)
        {
            return s.ParseDateTime(provider, style);
        }

        public static DateTime ToDateTime(
            this string s, string format, IFormatProvider provider)
        {
            return s.ParseExactDateTime(format, provider);
        }

        public static DateTime ToDateTime(
            this string s,
            string format,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return s.ParseExactDateTime(format, provider, style);
        }

        public static DateTime ToDateTime(
            this string s,
            string[] formats,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return s.ParseExactDateTime(formats, provider, style);
        }

        public static decimal ToDecimal(this string s)
        {
            return s.ParseDecimal();
        }

        public static decimal ToDecimal(
            this string s, IFormatProvider provider)
        {
            return s.ParseDecimal(provider);
        }

        public static decimal ToDecimal(this string s, NumberStyles style)
        {
            return s.ParseDecimal(style);
        }

        public static decimal ToDecimal(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return s.ParseDecimal(style, provider);
        }

        public static double ToDouble(this string s)
        {
            return s.ParseDouble();
        }

        public static double ToDouble(this string s, IFormatProvider provider)
        {
            return s.ParseDouble(provider);
        }

        public static double ToDouble(this string s, NumberStyles style)
        {
            return s.ParseDouble(style);
        }

        public static double ToDouble(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return s.ParseDouble(style, provider);
        }

        public static float ToFloat(this string s)
        {
            return s.ParseFloat();
        }

        public static float ToFloat(this string s, NumberStyles style)
        {
            return s.ParseFloat(style);
        }

        public static float ToFloat(this string s, IFormatProvider provider)
        {
            return s.ParseFloat(provider);
        }

        public static float ToFloat(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return s.ParseFloat(style, provider);
        }

        public static int ToInt(this string s)
        {
            return s.ParseInt();
        }

        public static int ToInt(this string s, NumberStyles style)
        {
            return s.ParseInt(style);
        }

        public static int ToInt(this string s, IFormatProvider provider)
        {
            return s.ParseInt(provider);
        }

        public static int ToInt(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return s.ParseInt(style, provider);
        }

        public static long ToLong(this string s)
        {
            return s.ParseLong();
        }

        public static long ToLong(this string s, NumberStyles style)
        {
            return s.ParseLong(style);
        }

        public static long ToLong(this string s, IFormatProvider provider)
        {
            return s.ParseLong(provider);
        }

        public static long ToLong(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return s.ParseLong(style, provider);
        }

        public static short ToShort(this string s)
        {
            return s.ParseShort();
        }

        public static short ToShort(this string s, IFormatProvider provider)
        {
            return s.ParseShort(provider);
        }

        public static short ToShort(this string s, NumberStyles style)
        {
            return s.ParseShort(style);
        }

        public static short ToShort(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return s.ParseShort(style, provider);
        }

        public static bool TryParse(this string s, out int result)
        {
            return int.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out int result)
        {
            return int.TryParse(s, style, provider, out result);
        }

        public static bool TryParse(this string s, out double result)
        {
            return double.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out double result)
        {
            return double.TryParse(s, style, provider, out result);
        }

        public static bool TryParse(this string s, out byte result)
        {
            return byte.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out byte result)
        {
            return byte.TryParse(s, style, provider, out result);
        }

        public static bool TryParse(this string s, out bool result)
        {
            return bool.TryParse(s, out result);
        }

        public static bool TryParse(this string s, out char result)
        {
            return char.TryParse(s, out result);
        }

        public static bool TryParse(this string s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            IFormatProvider provider,
            DateTimeStyles style,
            out DateTime result)
        {
            return DateTime.TryParse(s, provider, style, out result);
        }

        public static bool TryParse(
            this string s,
            string format,
            IFormatProvider provider,
            DateTimeStyles style,
            out DateTime result)
        {
            return DateTime.TryParseExact(
                s, format, provider, style, out result);
        }

        public static bool TryParse(
            this string s,
            string[] formats,
            IFormatProvider provider,
            DateTimeStyles style,
            out DateTime result)
        {
            return DateTime.TryParseExact(
                s, formats, provider, style, out result);
        }

        public static bool TryParse(this string s, out decimal result)
        {
            return decimal.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out decimal result)
        {
            return decimal.TryParse(s, style, provider, out result);
        }

        public static bool TryParse(this string s, out short result)
        {
            return short.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out short result)
        {
            return short.TryParse(s, style, provider, out result);
        }

        public static bool TryParse(this string s, out long result)
        {
            return long.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out long result)
        {
            return long.TryParse(s, style, provider, out result);
        }

        public static bool TryParse(this string s, out float result)
        {
            return float.TryParse(s, out result);
        }

        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out float result)
        {
            return float.TryParse(s, style, provider, out result);
        }

        private static bool ParseBool(this string s)
        {
            return bool.Parse(s);
        }

        private static byte ParseByte(this string s)
        {
            return byte.Parse(s);
        }

        private static byte ParseByte(this string s, IFormatProvider provider)
        {
            return byte.Parse(s, provider);
        }

        private static byte ParseByte(this string s, NumberStyles style)
        {
            return byte.Parse(s, style);
        }

        private static byte ParseByte(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return byte.Parse(s, style, provider);
        }

        private static char ParseChar(this string s)
        {
            return char.Parse(s);
        }

        private static DateTime ParseDateTime(this string s)
        {
            return DateTime.Parse(s);
        }

        private static DateTime ParseDateTime(
            this string s, IFormatProvider provider)
        {
            return DateTime.Parse(s, provider);
        }

        private static DateTime ParseDateTime(
            this string s, IFormatProvider provider, DateTimeStyles style)
        {
            return DateTime.Parse(s, provider, style);
        }

        private static decimal ParseDecimal(this string s)
        {
            return decimal.Parse(s);
        }

        private static decimal ParseDecimal(
            this string s, IFormatProvider provider)
        {
            return decimal.Parse(s, provider);
        }

        private static decimal ParseDecimal(this string s, NumberStyles style)
        {
            return decimal.Parse(s, style);
        }

        private static decimal ParseDecimal(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return decimal.Parse(s, style, provider);
        }

        private static double ParseDouble(this string s)
        {
            return double.Parse(s);
        }

        private static double ParseDouble(
            this string s, IFormatProvider provider)
        {
            return double.Parse(s, provider);
        }

        private static double ParseDouble(this string s, NumberStyles style)
        {
            return double.Parse(s, style);
        }

        private static double ParseDouble(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return double.Parse(s, style, provider);
        }

        private static DateTime ParseExactDateTime(
            this string s, string format, IFormatProvider provider)
        {
            return DateTime.ParseExact(s, format, provider);
        }

        private static DateTime ParseExactDateTime(
            this string s,
            string format,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }

        private static DateTime ParseExactDateTime(
            this string s,
            string[] formats,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return DateTime.ParseExact(s, formats, provider, style);
        }

        private static float ParseFloat(this string s)
        {
            return float.Parse(s);
        }

        private static float ParseFloat(
            this string s, IFormatProvider provider)
        {
            return float.Parse(s, provider);
        }

        private static float ParseFloat(this string s, NumberStyles style)
        {
            return float.Parse(s, style);
        }

        private static float ParseFloat(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return float.Parse(s, style, provider);
        }

        private static int ParseInt(this string s)
        {
            return int.Parse(s);
        }

        private static int ParseInt(this string s, IFormatProvider provider)
        {
            return int.Parse(s, provider);
        }

        private static int ParseInt(this string s, NumberStyles style)
        {
            return int.Parse(s, style);
        }

        private static int ParseInt(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return int.Parse(s, style, provider);
        }

        private static long ParseLong(this string s)
        {
            return long.Parse(s);
        }

        private static long ParseLong(this string s, IFormatProvider provider)
        {
            return long.Parse(s, provider);
        }

        private static long ParseLong(this string s, NumberStyles style)
        {
            return long.Parse(s, style);
        }

        private static long ParseLong(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return long.Parse(s, style, provider);
        }

        private static short ParseShort(this string s)
        {
            return short.Parse(s);
        }

        private static short ParseShort(
            this string s, IFormatProvider provider)
        {
            return short.Parse(s, provider);
        }

        private static short ParseShort(this string s, NumberStyles style)
        {
            return short.Parse(s, style);
        }

        private static short ParseShort(
            this string s, NumberStyles style, IFormatProvider provider)
        {
            return short.Parse(s, style, provider);
        }
    }
}