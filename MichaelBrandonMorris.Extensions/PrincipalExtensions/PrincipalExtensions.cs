using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Principal;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;
using Microsoft.AspNet.Identity;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    ///     Class PrincipalExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for PrincipalExtensions
    public static class PrincipalExtensions
    {
        /// <summary>
        ///     The legal symbols
        /// </summary>
        /// TODO Edit XML Comment Template for LegalSymbols
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

        /// <summary>
        ///     The legal characters
        /// </summary>
        /// TODO Edit XML Comment Template for LegalCharacters
        private static readonly IEnumerable<char> LegalCharacters =
            CharExtensions.AlphanumericCharacters.Concat(LegalSymbols);


        /// <summary>
        ///     Gets as directory entry.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <returns>DirectoryEntry.</returns>
        /// TODO Edit XML Comment Template for GetAsDirectoryEntry
        public static DirectoryEntry GetAsDirectoryEntry(
            this Principal principal)
        {
            return principal.GetUnderlyingObject() as DirectoryEntry;
        }

        /// <summary>
        ///     Gets the group principals.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <returns>IEnumerable&lt;GroupPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetGroupPrincipals
        public static IEnumerable<GroupPrincipal> GetGroupPrincipals(
            this Principal principal)
        {
            return principal.GetGroups().GetGroupPrincipals();
        }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetId
        public static string GetId(this IPrincipal principal)
        {
            return principal.Identity.GetUserId();
        }

        /// <summary>
        ///     Gets the property.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>PropertyValueCollection.</returns>
        /// TODO Edit XML Comment Template for GetProperty
        public static PropertyValueCollection GetProperty(
            this Principal principal,
            string propertyName)
        {
            return principal.GetAsDirectoryEntry().Properties[propertyName];
        }

        /// <summary>
        ///     Gets the property value.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>System.Object.</returns>
        /// TODO Edit XML Comment Template for GetPropertyValue
        public static object GetPropertyValue(
            this Principal principal,
            string propertyName)
        {
            return principal.GetProperty(propertyName).Value;
        }

        /// <summary>
        ///     Gets the property value as string.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetPropertyValueAsString
        public static string GetPropertyValueAsString(
            this Principal principal,
            string propertyName)
        {
            var propertyValue = principal.GetPropertyValue(propertyName);
            return propertyValue == null
                ? string.Empty
                : propertyValue.ToString().RemoveAllBut(LegalCharacters);
        }
    }
}