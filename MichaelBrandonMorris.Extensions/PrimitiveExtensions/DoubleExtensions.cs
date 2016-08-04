namespace MichaelBrandonMorris.Extensions.PrimitiveExtensions
{
    public static class DoubleExtensions
    {
        public static bool IsInfinity(this double d)
        {
            return double.IsInfinity(d);
        }

        public static bool IsNaN(this double d)
        {
            return double.IsNaN(d);
        }

        public static bool IsNegativeInfinity(this double d)
        {
            return double.IsNegativeInfinity(d);
        }

        public static bool IsPositiveInfinity(this double d)
        {
            return double.IsPositiveInfinity(d);
        }
    }
}