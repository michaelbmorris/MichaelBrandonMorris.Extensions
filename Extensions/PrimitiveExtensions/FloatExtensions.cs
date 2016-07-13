namespace Extensions.PrimitiveExtensions
{
    public static class FloatExtensions
    {
        public static bool IsInfinity(this float f)
        {
            return float.IsInfinity(f);
        }

        public static bool IsNaN(this float f)
        {
            return float.IsNaN(f);
        }

        public static bool IsNegativeInfinity(this float f)
        {
            return float.IsNegativeInfinity(f);
        }

        public static bool IsPositiveInfinity(this float f)
        {
            return float.IsPositiveInfinity(f);
        }
    }
}