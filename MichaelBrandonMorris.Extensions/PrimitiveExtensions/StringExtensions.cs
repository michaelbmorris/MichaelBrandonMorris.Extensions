using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace MichaelBrandonMorris.Extensions.PrimitiveExtensions
{
    /// <summary>
    ///     Class StringExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for StringExtensions
    public static class StringExtensions
    {
        /// <summary>
        ///     Compares the specified s2.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Compare
        public static int Compare(this string s1, string s2)
        {
            // ReSharper disable once StringCompareIsCultureSpecific.1
            return string.Compare(s1, s2);
        }

        /// <summary>
        ///     Compares the specified s2.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <param name="ignoreCase">
        ///     if set to <c>true</c> [ignore
        ///     case].
        /// </param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Compare
        public static int Compare(this string s1, string s2, bool ignoreCase)
        {
            return string.Compare(s1, s2, ignoreCase);
        }

        /// <summary>
        ///     Compares the specified s2.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <param name="ignoreCase">
        ///     if set to <c>true</c> [ignore
        ///     case].
        /// </param>
        /// <param name="culture">The culture.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Compare
        public static int Compare(
            this string s1,
            string s2,
            bool ignoreCase,
            CultureInfo culture)
        {
            return string.Compare(s1, s2, ignoreCase, culture);
        }

        /// <summary>
        ///     Compares the specified s2.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <param name="culture">The culture.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Compare
        public static int Compare(
            this string s1,
            string s2,
            CultureInfo culture,
            CompareOptions options)
        {
            return string.Compare(s1, s2, culture, options);
        }

        /// <summary>
        ///     Compares the specified s2.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <param name="comparisonType">Type of the comparison.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Compare
        public static int Compare(
            this string s1,
            string s2,
            StringComparison comparisonType)
        {
            return string.Compare(s1, s2, comparisonType);
        }

        /// <summary>
        ///     Compares the ordinal.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for CompareOrdinal
        public static int CompareOrdinal(this string s1, string s2)
        {
            return string.CompareOrdinal(s1, s2);
        }

        /// <summary>
        ///     Determines whether [contains ignore case] [the
        ///     specified s2].
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>
        ///     <c>true</c> if [contains ignore case] [the specified
        ///     s2]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for ContainsIgnoreCase
        public static bool ContainsIgnoreCase(this string s1, string s2)
        {
            return s1.IndexOfOrdinalIgnoreCase(s2) >= 0;
        }

        /// <summary>
        ///     Converts to utf32.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ConvertToUtf32
        public static int ConvertToUtf32(this string s, int index)
        {
            return char.ConvertToUtf32(s, index);
        }

        /// <summary>
        ///     Copies the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for Copy
        public static string Copy(this string s)
        {
            return string.Copy(s);
        }

        /// <summary>
        ///     Equalses the current culture.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for EqualsCurrentCulture
        public static bool EqualsCurrentCulture(this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.CurrentCulture);
        }

        /// <summary>
        ///     Equalses the current culture ignore case.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for EqualsCurrentCultureIgnoreCase
        public static bool EqualsCurrentCultureIgnoreCase(
            this string s1,
            string s2)
        {
            return s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        ///     Equalses the invariant culture.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for EqualsInvariantCulture
        public static bool EqualsInvariantCulture(this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.InvariantCulture);
        }

        /// <summary>
        ///     Equalses the invariant culture ignore case.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for EqualsInvariantCultureIgnoreCase
        public static bool EqualsInvariantCultureIgnoreCase(
            this string s1,
            string s2)
        {
            return s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        ///     Equalses the ordinal.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for EqualsOrdinal
        public static bool EqualsOrdinal(this string s1, string s2)
        {
            return s1.Equals(s2, StringComparison.Ordinal);
        }

        /// <summary>
        ///     Equalses the ordinal ignore case.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for EqualsOrdinalIgnoreCase
        public static bool EqualsOrdinalIgnoreCase(this string s1, string s2)
        {
            if (s1 == null)
            {
                return false;
            }

            return s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        ///     Gets the numeric value.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for GetNumericValue
        public static double GetNumericValue(this string s, int index)
        {
            return char.GetNumericValue(s, index);
        }

        /// <summary>
        ///     Gets the unicode category.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>UnicodeCategory.</returns>
        /// TODO Edit XML Comment Template for GetUnicodeCategory
        public static UnicodeCategory GetUnicodeCategory(
            this string s,
            int index)
        {
            return char.GetUnicodeCategory(s, index);
        }

        /// <summary>
        ///     Indexes the of ordinal.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for IndexOfOrdinal
        public static int IndexOfOrdinal(this string s1, string s2)
        {
            return s1.IndexOf(s2, StringComparison.Ordinal);
        }

        /// <summary>
        ///     Indexes the of ordinal ignore case.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for IndexOfOrdinalIgnoreCase
        public static int IndexOfOrdinalIgnoreCase(this string s1, string s2)
        {
            return s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        ///     Determines whether the specified index is control.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is control;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsControl
        public static bool IsControl(this string s, int index)
        {
            return char.IsControl(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is digit.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is digit;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsDigit
        public static bool IsDigit(this string s, int index)
        {
            return char.IsDigit(s, index);
        }

        /// <summary>
        ///     Determines whether [is high surrogate] [the specified
        ///     index].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if [is high surrogate] [the specified
        ///     index]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsHighSurrogate
        public static bool IsHighSurrogate(this string s, int index)
        {
            return char.IsHighSurrogate(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is letter.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is letter;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLetter
        public static bool IsLetter(this string s, int index)
        {
            return char.IsLetter(s, index);
        }

        /// <summary>
        ///     Determines whether [is letter or digit] [the specified
        ///     index].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if [is letter or digit] [the specified
        ///     index]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLetterOrDigit
        public static bool IsLetterOrDigit(this string s, int index)
        {
            return char.IsLetterOrDigit(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is lower.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is lower;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLower
        public static bool IsLower(this string s, int index)
        {
            return char.IsLower(s, index);
        }

        /// <summary>
        ///     Determines whether [is low surrogate] [the specified
        ///     index].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if [is low surrogate] [the specified
        ///     index]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsLowSurrogate
        public static bool IsLowSurrogate(this string s, int index)
        {
            return char.IsLowSurrogate(s, index);
        }

        /// <summary>
        ///     Determines whether [is null or empty] [the specified
        ///     s].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        ///     <c>true</c> if [is null or empty] [the specified
        ///     s]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNullOrEmpty
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        /// <summary>
        ///     Determines whether [is null or white space] [the
        ///     specified s].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        ///     <c>true</c> if [is null or white space] [the specified
        ///     s]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNullOrWhiteSpace
        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        /// <summary>
        ///     Determines whether the specified index is number.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is number;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNumber
        public static bool IsNumber(this string s, int index)
        {
            return char.IsNumber(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is punctuation.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is punctuation;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsPunctuation
        public static bool IsPunctuation(this string s, int index)
        {
            return char.IsPunctuation(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is separator.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is separator;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsSeparator
        public static bool IsSeparator(this string s, int index)
        {
            return char.IsSeparator(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is surrogate.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is surrogate;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsSurrogate
        public static bool IsSurrogate(this string s, int index)
        {
            return char.IsSurrogate(s, index);
        }

        /// <summary>
        ///     Determines whether [is surrogate pair] [the specified
        ///     index].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if [is surrogate pair] [the specified
        ///     index]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsSurrogatePair
        public static bool IsSurrogatePair(this string s, int index)
        {
            return char.IsSurrogatePair(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is symbol.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is symbol;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsSymbol
        public static bool IsSymbol(this string s, int index)
        {
            return char.IsSymbol(s, index);
        }

        /// <summary>
        ///     Determines whether the specified index is upper.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if the specified index is upper;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsUpper
        public static bool IsUpper(this string s, int index)
        {
            return char.IsUpper(s, index);
        }

        /// <summary>
        ///     Determines whether [is white space] [the specified
        ///     index].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///     <c>true</c> if [is white space] [the specified
        ///     index]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsWhiteSpace
        public static bool IsWhiteSpace(this string s, int index)
        {
            return char.IsWhiteSpace(s, index);
        }

        /// <summary>
        ///     Determines whether [is white space] [the specified s].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        ///     <c>true</c> if [is white space] [the specified s];
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsWhiteSpace
        public static bool IsWhiteSpace(this string s)
        {
            return s.All(c => c.IsWhiteSpace());
        }

        /// <summary>
        ///     Removes the specified c.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="c">The c.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for Remove
        public static string Remove(this string s, char c)
        {
            return s.Replace(c.ToString(), string.Empty);
        }

        /// <summary>
        ///     Removes the specified s2.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for Remove
        public static string Remove(this string s1, string s2)
        {
            if (s1.IsNullOrWhiteSpace())
            {
                return string.Empty;
            }

            return s1.Replace(s2, string.Empty);
        }

        /// <summary>
        ///     Removes all.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="characters">The characters.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for RemoveAll
        public static string RemoveAll(
            this string s,
            IEnumerable<char> characters)
        {
            return characters.Aggregate(
                s,
                (current, character) => current.Remove(character));
        }

        /// <summary>
        ///     Removes all but.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="characters">The characters.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for RemoveAllBut
        public static string RemoveAllBut(
            this string s,
            IEnumerable<char> characters)
        {
            return new string(s.Where(c => c.EqualsAny(characters)).ToArray());
        }

        /// <summary>
        ///     Spaces the camel case.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for SpaceCamelCase
        public static string SpaceCamelCase(this string s)
        {
            return Regex.Replace(
                Regex.Replace(s, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2");
        }

        /// <summary>
        ///     Substrings at index of ordinal.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for SubstringAtIndexOfOrdinal
        public static string SubstringAtIndexOfOrdinal(
            this string s1,
            string s2)
        {
            return s1.Substring(s1.IndexOfOrdinal(s2));
        }

        /// <summary>
        ///     Substrings at index of ordinal ignore case.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for SubstringAtIndexOfOrdinalIgnoreCase
        public static string SubstringAtIndexOfOrdinalIgnoreCase(
            this string s1,
            string s2)
        {
            return s1.Substring(s1.IndexOfOrdinalIgnoreCase(s2));
        }

        /// <summary>
        ///     To the bool.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for ToBool
        public static bool ToBool(this string s)
        {
            return s.ParseBool();
        }

        /// <summary>
        ///     To the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ToByte
        public static byte ToByte(this string s)
        {
            return s.ParseByte();
        }

        /// <summary>
        ///     To the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ToByte
        public static byte ToByte(this string s, IFormatProvider provider)
        {
            return s.ParseByte(provider);
        }

        /// <summary>
        ///     To the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ToByte
        public static byte ToByte(this string s, NumberStyles style)
        {
            return s.ParseByte(style);
        }

        /// <summary>
        ///     To the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ToByte
        public static byte ToByte(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return s.ParseByte(style, provider);
        }

        /// <summary>
        ///     To the character.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ToChar
        public static char ToChar(this string s)
        {
            return s.ParseChar();
        }

        /// <summary>
        ///     To the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ToDateTime
        public static DateTime ToDateTime(this string s)
        {
            return s.ParseDateTime();
        }

        /// <summary>
        ///     To the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ToDateTime
        public static DateTime ToDateTime(
            this string s,
            IFormatProvider provider)
        {
            return s.ParseDateTime(provider);
        }

        /// <summary>
        ///     To the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ToDateTime
        public static DateTime ToDateTime(
            this string s,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return s.ParseDateTime(provider, style);
        }

        /// <summary>
        ///     To the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="format">The format.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ToDateTime
        public static DateTime ToDateTime(
            this string s,
            string format,
            IFormatProvider provider)
        {
            return s.ParseExactDateTime(format, provider);
        }

        /// <summary>
        ///     To the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="format">The format.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ToDateTime
        public static DateTime ToDateTime(
            this string s,
            string format,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return s.ParseExactDateTime(format, provider, style);
        }

        /// <summary>
        ///     To the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="formats">The formats.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ToDateTime
        public static DateTime ToDateTime(
            this string s,
            string[] formats,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return s.ParseExactDateTime(formats, provider, style);
        }

        /// <summary>
        ///     To the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ToDecimal
        public static decimal ToDecimal(this string s)
        {
            return s.ParseDecimal();
        }

        /// <summary>
        ///     To the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ToDecimal
        public static decimal ToDecimal(this string s, IFormatProvider provider)
        {
            return s.ParseDecimal(provider);
        }

        /// <summary>
        ///     To the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ToDecimal
        public static decimal ToDecimal(this string s, NumberStyles style)
        {
            return s.ParseDecimal(style);
        }

        /// <summary>
        ///     To the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ToDecimal
        public static decimal ToDecimal(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return s.ParseDecimal(style, provider);
        }

        /// <summary>
        ///     To the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ToDouble
        public static double ToDouble(this string s)
        {
            return s.ParseDouble();
        }

        /// <summary>
        ///     To the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ToDouble
        public static double ToDouble(this string s, IFormatProvider provider)
        {
            return s.ParseDouble(provider);
        }

        /// <summary>
        ///     To the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ToDouble
        public static double ToDouble(this string s, NumberStyles style)
        {
            return s.ParseDouble(style);
        }

        /// <summary>
        ///     To the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ToDouble
        public static double ToDouble(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return s.ParseDouble(style, provider);
        }

        /// <summary>
        ///     To the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ToFloat
        public static float ToFloat(this string s)
        {
            return s.ParseFloat();
        }

        /// <summary>
        ///     To the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ToFloat
        public static float ToFloat(this string s, NumberStyles style)
        {
            return s.ParseFloat(style);
        }

        /// <summary>
        ///     To the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ToFloat
        public static float ToFloat(this string s, IFormatProvider provider)
        {
            return s.ParseFloat(provider);
        }

        /// <summary>
        ///     To the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ToFloat
        public static float ToFloat(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return s.ParseFloat(style, provider);
        }

        /// <summary>
        ///     Converts the string representation of a number to an
        ///     integer.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ToInt
        public static int ToInt(this string s)
        {
            return s.ParseInt();
        }

        /// <summary>
        ///     Converts the string representation of a number to an
        ///     integer.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ToInt
        public static int ToInt(this string s, NumberStyles style)
        {
            return s.ParseInt(style);
        }

        /// <summary>
        ///     Converts the string representation of a number to an
        ///     integer.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ToInt
        public static int ToInt(this string s, IFormatProvider provider)
        {
            return s.ParseInt(provider);
        }

        /// <summary>
        ///     Converts the string representation of a number to an
        ///     integer.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ToInt
        public static int ToInt(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return s.ParseInt(style, provider);
        }

        /// <summary>
        ///     To the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ToLong
        public static long ToLong(this string s)
        {
            return s.ParseLong();
        }

        /// <summary>
        ///     To the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ToLong
        public static long ToLong(this string s, NumberStyles style)
        {
            return s.ParseLong(style);
        }

        /// <summary>
        ///     To the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ToLong
        public static long ToLong(this string s, IFormatProvider provider)
        {
            return s.ParseLong(provider);
        }

        /// <summary>
        ///     To the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ToLong
        public static long ToLong(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return s.ParseLong(style, provider);
        }

        /// <summary>
        ///     To the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ToShort
        public static short ToShort(this string s)
        {
            return s.ParseShort();
        }

        /// <summary>
        ///     To the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ToShort
        public static short ToShort(this string s, IFormatProvider provider)
        {
            return s.ParseShort(provider);
        }

        /// <summary>
        ///     To the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ToShort
        public static short ToShort(this string s, NumberStyles style)
        {
            return s.ParseShort(style);
        }

        /// <summary>
        ///     To the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ToShort
        public static short ToShort(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return s.ParseShort(style, provider);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out int result)
        {
            return int.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out int result)
        {
            return int.TryParse(s, style, provider, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out double result)
        {
            return double.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out double result)
        {
            return double.TryParse(s, style, provider, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out byte result)
        {
            return byte.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out byte result)
        {
            return byte.TryParse(s, style, provider, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out bool result)
        {
            return bool.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out char result)
        {
            return char.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            IFormatProvider provider,
            DateTimeStyles style,
            out DateTime result)
        {
            return DateTime.TryParse(s, provider, style, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="format">The format.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            string format,
            IFormatProvider provider,
            DateTimeStyles style,
            out DateTime result)
        {
            return DateTime.TryParseExact(
                s,
                format,
                provider,
                style,
                out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="formats">The formats.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            string[] formats,
            IFormatProvider provider,
            DateTimeStyles style,
            out DateTime result)
        {
            return DateTime.TryParseExact(
                s,
                formats,
                provider,
                style,
                out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out decimal result)
        {
            return decimal.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out decimal result)
        {
            return decimal.TryParse(s, style, provider, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out short result)
        {
            return short.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out short result)
        {
            return short.TryParse(s, style, provider, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out long result)
        {
            return long.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out long result)
        {
            return long.TryParse(s, style, provider, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(this string s, out float result)
        {
            return float.TryParse(s, out result);
        }

        /// <summary>
        ///     Tries the parse.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for TryParse
        public static bool TryParse(
            this string s,
            NumberStyles style,
            IFormatProvider provider,
            out float result)
        {
            return float.TryParse(s, style, provider, out result);
        }

        /// <summary>
        ///     Wraps the specified c.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="c">The c.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for Wrap
        public static string Wrap(this string s, char c)
        {
            return s.Wrap(c.ToString());
        }

        /// <summary>
        ///     Wraps the specified s1.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="s1">The s1.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for Wrap
        public static string Wrap(this string s, string s1)
        {
            return s1 + s + s1;
        }

        /// <summary>
        ///     Wraps the specified c.
        /// </summary>
        /// <param name="strings">The strings.</param>
        /// <param name="c">The c.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        /// TODO Edit XML Comment Template for Wrap
        public static IEnumerable<string> Wrap(
            this IEnumerable<string> strings,
            char c)
        {
            return strings.Wrap(c.ToString());
        }

        /// <summary>
        ///     Wraps the specified s1.
        /// </summary>
        /// <param name="strings">The strings.</param>
        /// <param name="s1">The s1.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        /// TODO Edit XML Comment Template for Wrap
        public static IEnumerable<string> Wrap(
            this IEnumerable<string> strings,
            string s1)
        {
            return strings.Select(s => s.Wrap(s1));
        }

        /// <summary>
        ///     Parses the bool.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for ParseBool
        private static bool ParseBool(this string s)
        {
            return bool.Parse(s);
        }

        /// <summary>
        ///     Parses the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ParseByte
        private static byte ParseByte(this string s)
        {
            return byte.Parse(s);
        }

        /// <summary>
        ///     Parses the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ParseByte
        private static byte ParseByte(this string s, IFormatProvider provider)
        {
            return byte.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ParseByte
        private static byte ParseByte(this string s, NumberStyles style)
        {
            return byte.Parse(s, style);
        }

        /// <summary>
        ///     Parses the byte.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Byte.</returns>
        /// TODO Edit XML Comment Template for ParseByte
        private static byte ParseByte(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return byte.Parse(s, style, provider);
        }

        /// <summary>
        ///     Parses the character.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Char.</returns>
        /// TODO Edit XML Comment Template for ParseChar
        private static char ParseChar(this string s)
        {
            return char.Parse(s);
        }

        /// <summary>
        ///     Parses the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ParseDateTime
        private static DateTime ParseDateTime(this string s)
        {
            return DateTime.Parse(s);
        }

        /// <summary>
        ///     Parses the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ParseDateTime
        private static DateTime ParseDateTime(
            this string s,
            IFormatProvider provider)
        {
            return DateTime.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ParseDateTime
        private static DateTime ParseDateTime(
            this string s,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return DateTime.Parse(s, provider, style);
        }

        /// <summary>
        ///     Parses the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ParseDecimal
        private static decimal ParseDecimal(this string s)
        {
            return decimal.Parse(s);
        }

        /// <summary>
        ///     Parses the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ParseDecimal
        private static decimal ParseDecimal(
            this string s,
            IFormatProvider provider)
        {
            return decimal.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ParseDecimal
        private static decimal ParseDecimal(this string s, NumberStyles style)
        {
            return decimal.Parse(s, style);
        }

        /// <summary>
        ///     Parses the decimal.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Decimal.</returns>
        /// TODO Edit XML Comment Template for ParseDecimal
        private static decimal ParseDecimal(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return decimal.Parse(s, style, provider);
        }

        /// <summary>
        ///     Parses the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ParseDouble
        private static double ParseDouble(this string s)
        {
            return double.Parse(s);
        }

        /// <summary>
        ///     Parses the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ParseDouble
        private static double ParseDouble(
            this string s,
            IFormatProvider provider)
        {
            return double.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ParseDouble
        private static double ParseDouble(this string s, NumberStyles style)
        {
            return double.Parse(s, style);
        }

        /// <summary>
        ///     Parses the double.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Double.</returns>
        /// TODO Edit XML Comment Template for ParseDouble
        private static double ParseDouble(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return double.Parse(s, style, provider);
        }

        /// <summary>
        ///     Parses the exact date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="format">The format.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ParseExactDateTime
        private static DateTime ParseExactDateTime(
            this string s,
            string format,
            IFormatProvider provider)
        {
            return DateTime.ParseExact(s, format, provider);
        }

        /// <summary>
        ///     Parses the exact date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="format">The format.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ParseExactDateTime
        private static DateTime ParseExactDateTime(
            this string s,
            string format,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }

        /// <summary>
        ///     Parses the exact date time.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="formats">The formats.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="style">The style.</param>
        /// <returns>DateTime.</returns>
        /// TODO Edit XML Comment Template for ParseExactDateTime
        private static DateTime ParseExactDateTime(
            this string s,
            string[] formats,
            IFormatProvider provider,
            DateTimeStyles style)
        {
            return DateTime.ParseExact(s, formats, provider, style);
        }

        /// <summary>
        ///     Parses the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ParseFloat
        private static float ParseFloat(this string s)
        {
            return float.Parse(s);
        }

        /// <summary>
        ///     Parses the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ParseFloat
        private static float ParseFloat(this string s, IFormatProvider provider)
        {
            return float.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ParseFloat
        private static float ParseFloat(this string s, NumberStyles style)
        {
            return float.Parse(s, style);
        }

        /// <summary>
        ///     Parses the float.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Single.</returns>
        /// TODO Edit XML Comment Template for ParseFloat
        private static float ParseFloat(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return float.Parse(s, style, provider);
        }

        /// <summary>
        ///     Parses the int.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ParseInt
        private static int ParseInt(this string s)
        {
            return int.Parse(s);
        }

        /// <summary>
        ///     Parses the int.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ParseInt
        private static int ParseInt(this string s, IFormatProvider provider)
        {
            return int.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the int.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ParseInt
        private static int ParseInt(this string s, NumberStyles style)
        {
            return int.Parse(s, style);
        }

        /// <summary>
        ///     Parses the int.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for ParseInt
        private static int ParseInt(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return int.Parse(s, style, provider);
        }

        /// <summary>
        ///     Parses the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ParseLong
        private static long ParseLong(this string s)
        {
            return long.Parse(s);
        }

        /// <summary>
        ///     Parses the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ParseLong
        private static long ParseLong(this string s, IFormatProvider provider)
        {
            return long.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ParseLong
        private static long ParseLong(this string s, NumberStyles style)
        {
            return long.Parse(s, style);
        }

        /// <summary>
        ///     Parses the long.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int64.</returns>
        /// TODO Edit XML Comment Template for ParseLong
        private static long ParseLong(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return long.Parse(s, style, provider);
        }

        /// <summary>
        ///     Parses the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ParseShort
        private static short ParseShort(this string s)
        {
            return short.Parse(s);
        }

        /// <summary>
        ///     Parses the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ParseShort
        private static short ParseShort(this string s, IFormatProvider provider)
        {
            return short.Parse(s, provider);
        }

        /// <summary>
        ///     Parses the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ParseShort
        private static short ParseShort(this string s, NumberStyles style)
        {
            return short.Parse(s, style);
        }

        /// <summary>
        ///     Parses the short.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="style">The style.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>System.Int16.</returns>
        /// TODO Edit XML Comment Template for ParseShort
        private static short ParseShort(
            this string s,
            NumberStyles style,
            IFormatProvider provider)
        {
            return short.Parse(s, style, provider);
        }
    }
}