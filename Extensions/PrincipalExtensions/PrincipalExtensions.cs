using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using Extensions.PrimitiveExtensions;

namespace Extensions.PrincipalExtensions
{
    /// <summary>
    /// Provides useful extension methods for the <see cref="Principal"/> 
    /// class.
    /// </summary>
    public static class PrincipalExtensions
    {
        private static readonly char[] LegalSymbols =
        {
            ' ',
            '\\',
            '/',
            ',',
            '.',
            ':',
            ';',
            '@',
            '=',
            '-'
        };

        private static readonly IEnumerable<char> LegalCharacters =
            CharExtensions.AlphanumericCharacters.Concat(LegalSymbols);

        /// <summary>
        /// Gets the underlying <see cref="DirectoryEntry"/> for the 
        /// <see cref="Principal"/> if one exisits. Otherwise, returns null.
        /// </summary>
        public static DirectoryEntry GetAsDirectoryEntry(
            this Principal principal)
        {
            return principal.GetUnderlyingObject() as DirectoryEntry;
        }

        /// <summary>
        /// Gets the <see cref="GroupPrincipal"/>s this <see cref="Principal"/>
        ///  is a member of.
        /// </summary>
        public static IEnumerable<GroupPrincipal> GetGroupPrincipals(
            this Principal principal)
        {
            return principal.GetGroups().GetGroupPrincipals();
        }

        /// <summary>
        /// Gets the specified property from this <see cref="Principal"/>'s 
        /// underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static PropertyValueCollection GetProperty(
            this Principal principal, string propertyName)
        {
            return principal.GetAsDirectoryEntry().Properties[propertyName];
        }

        /// <summary>
        /// Gets the value for the specified property from this 
        /// <see cref="Principal"/>'s underlying <see cref="DirectoryEntry"/> 
        /// as an <see cref="object"/>.
        /// </summary>
        public static object GetPropertyValue(
            this Principal principal, string propertyName)
        {
            return principal.GetProperty(propertyName).Value;
        }

        /// <summary>
        /// Gets the value for the specified property from this 
        /// <see cref="Principal"/>'s underlying <see cref="DirectoryEntry"/> 
        /// as a <see cref="string"/>. Returns an empty <see cref="string"/> 
        /// if the property value is null.
        /// </summary>
        public static string GetPropertyValueAsString(
            this Principal principal, string propertyName)
        {
            var propertyValue = principal.GetPropertyValue(propertyName);
            return propertyValue == null
                ? string.Empty
                : propertyValue.ToString().RemoveAllBut(LegalCharacters);
        }
    }
}
