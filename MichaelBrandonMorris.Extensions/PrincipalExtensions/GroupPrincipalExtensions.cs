using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    ///     Class GroupPrincipalExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for GroupPrincipalExtensions
    public static class GroupPrincipalExtensions
    {
        /// <summary>
        ///     The managed by
        /// </summary>
        /// TODO Edit XML Comment Template for ManagedBy
        private const string ManagedBy = "managedBy";

        /// <summary>
        ///     Gets the computer principals.
        /// </summary>
        /// <param name="groupPrincipal">The group principal.</param>
        /// <returns>IEnumerable&lt;ComputerPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetComputerPrincipals
        public static IEnumerable<ComputerPrincipal> GetComputerPrincipals(
            this GroupPrincipal groupPrincipal)
        {
            return groupPrincipal.Members.OfType<ComputerPrincipal>();
        }

        /// <summary>
        ///     Gets the name of the managed by distinguished.
        /// </summary>
        /// <param name="groupPrincipal">The group principal.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetManagedByDistinguishedName
        public static string GetManagedByDistinguishedName(
            this GroupPrincipal groupPrincipal)
        {
            return groupPrincipal.GetPropertyValueAsString(ManagedBy);
        }

        /// <summary>
        ///     Gets the name of the managed by.
        /// </summary>
        /// <param name="groupPrincipal">The group principal.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GetManagedByName
        public static string GetManagedByName(
            this GroupPrincipal groupPrincipal)
        {
            var managedByDistinguishedName =
                groupPrincipal.GetManagedByDistinguishedName();

            if (managedByDistinguishedName.IsNullOrWhiteSpace())
            {
                return null;
            }

            using (var principalContext =
                PrincipalContextExtensions.GetPrincipalContext())

            using (var managedByUserPrincipal =
                UserPrincipalExtensions.FindByDistinguishedName(
                    principalContext,
                    managedByDistinguishedName))
            {
                return managedByUserPrincipal?.Name;
            }
        }

        /// <summary>
        ///     Gets the user principals.
        /// </summary>
        /// <param name="groupPrincipal">The group principal.</param>
        /// <returns>IEnumerable&lt;UserPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetUserPrincipals
        public static IEnumerable<UserPrincipal> GetUserPrincipals(
            this GroupPrincipal groupPrincipal)
        {
            return groupPrincipal.Members.OfType<UserPrincipal>();
        }
    }
}