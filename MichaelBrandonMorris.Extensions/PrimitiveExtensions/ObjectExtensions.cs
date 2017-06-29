using System;

namespace MichaelBrandonMorris.Extensions.PrimitiveExtensions
{
    /// <summary>
    ///     Class ObjectExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for ObjectExtensions
    public static class ObjectExtensions
    {
        /// <summary>
        ///     Gets the property value.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="Exception"></exception>
        /// TODO Edit XML Comment Template for GetPropertyValue
        public static object GetPropertyValue(
            this object o,
            string propertyName)
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