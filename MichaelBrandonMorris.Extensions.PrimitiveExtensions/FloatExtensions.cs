namespace MichaelBrandonMorris.Extensions.PrimitiveExtensions
{
    /// <summary>
    ///     Class FloatExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for FloatExtensions
    public static class FloatExtensions
    {
        /// <summary>
        ///     Determines whether the specified f is infinity.
        /// </summary>
        /// <param name="f">The f.</param>
        /// <returns>
        ///     <c>true</c> if the specified f is infinity;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsInfinity
        public static bool IsInfinity(this float f)
        {
            return float.IsInfinity(f);
        }

        /// <summary>
        ///     Determines whether [is na n] [the specified f].
        /// </summary>
        /// <param name="f">The f.</param>
        /// <returns>
        ///     <c>true</c> if [is na n] [the specified f];
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNaN
        public static bool IsNaN(this float f)
        {
            return float.IsNaN(f);
        }

        /// <summary>
        ///     Determines whether [is negative infinity] [the
        ///     specified f].
        /// </summary>
        /// <param name="f">The f.</param>
        /// <returns>
        ///     <c>true</c> if [is negative infinity] [the specified
        ///     f]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNegativeInfinity
        public static bool IsNegativeInfinity(this float f)
        {
            return float.IsNegativeInfinity(f);
        }

        /// <summary>
        ///     Determines whether [is positive infinity] [the
        ///     specified f].
        /// </summary>
        /// <param name="f">The f.</param>
        /// <returns>
        ///     <c>true</c> if [is positive infinity] [the specified
        ///     f]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsPositiveInfinity
        public static bool IsPositiveInfinity(this float f)
        {
            return float.IsPositiveInfinity(f);
        }
    }
}