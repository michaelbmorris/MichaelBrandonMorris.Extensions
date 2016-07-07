using System;

namespace PrimitiveExtensions
{
    public static class ArrayExtensions
    {
        public static bool IsEmpty(this Array array)
        {
            return array.Length == 0;
        }

        public static bool IsNullOrEmpty(this Array array)
        {
            return array == null || array.IsEmpty();
        }
    }
}