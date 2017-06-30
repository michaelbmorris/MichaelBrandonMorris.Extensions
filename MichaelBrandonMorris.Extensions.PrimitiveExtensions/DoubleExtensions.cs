namespace MichaelBrandonMorris.Extensions.PrimitiveExtensions
{
    /// <summary>
    ///     Class DoubleExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for DoubleExtensions
    public static class DoubleExtensions
    {
        /// <summary>
        ///     Determines whether the specified d is infinity.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <returns>
        ///     <c>true</c> if the specified d is infinity;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsInfinity
        public static bool IsInfinity(this double d)
        {
            return double.IsInfinity(d);
        }

        /// <summary>
        ///     Determines whether [is na n] [the specified d].
        /// </summary>
        /// <param name="d">The d.</param>
        /// <returns>
        ///     <c>true</c> if [is na n] [the specified d];
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNaN
        public static bool IsNaN(this double d)
        {
            return double.IsNaN(d);
        }

        /// <summary>
        ///     Determines whether [is negative infinity] [the
        ///     specified d].
        /// </summary>
        /// <param name="d">The d.</param>
        /// <returns>
        ///     <c>true</c> if [is negative infinity] [the specified
        ///     d]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNegativeInfinity
        public static bool IsNegativeInfinity(this double d)
        {
            return double.IsNegativeInfinity(d);
        }

        /// <summary>
        ///     Determines whether [is positive infinity] [the
        ///     specified d].
        /// </summary>
        /// <param name="d">The d.</param>
        /// <returns>
        ///     <c>true</c> if [is positive infinity] [the specified
        ///     d]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsPositiveInfinity
        public static bool IsPositiveInfinity(this double d)
        {
            return double.IsPositiveInfinity(d);
        }
    }
}