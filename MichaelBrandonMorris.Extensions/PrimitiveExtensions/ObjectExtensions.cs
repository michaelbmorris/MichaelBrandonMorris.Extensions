using System;

namespace MichaelBrandonMorris.Extensions.PrimitiveExtensions
{
    /// <summary>
    ///     Provides extensions for <see cref="object"/>s.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        ///     Gets the value of a named property for this 
        ///     <see cref="object"/>.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static object GetPropertyValue(this object o, string propertyName)
        {
            var propertyInfo = o.GetType().GetProperty(propertyName);

            if (propertyInfo == null)
            {
                throw new Exception(
                    $"Object does not have property '{propertyName}'.");
            }

            return propertyInfo.GetValue(o, null);
        }
    }
}
