using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    /// Provides useful extensions for the <see cref="GroupPrincipal"/> class.
    /// </summary>
    public static class GroupPrincipalExtensions
    {
        private const string ManagedBy = "managedBy";

        /// <summary>
        /// Gets the name of the manager of this group.
        /// </summary>
        public static string GetManagedByName(
            this GroupPrincipal groupPrincipal)
        {
            var managedByDistinguishedName =
                groupPrincipal.GetManagedByDistinguishedName();
            if (managedByDistinguishedName.IsNullOrWhiteSpace()) return null;
            using (var principalContext =
                PrincipalContextExtensions.GetPrincipalContext())
            using (var managedByUserPrincipal =
                UserPrincipalExtensions.FindByDistinguishedName(
                    principalContext, managedByDistinguishedName))
            {
                return managedByUserPrincipal?.Name;
            }
        }

        /// <summary>
        /// Gets the distinguished name of the manager of this group.
        /// </summary>
        /// <param name="groupPrincipal"></param>
        /// <returns></returns>
        public static string GetManagedByDistinguishedName(
            this GroupPrincipal groupPrincipal)
        {
            return groupPrincipal.GetPropertyValueAsString(ManagedBy);
        }

        /// <summary>
        /// Gets the <see cref="UserPrincipal"/> members of this 
        /// <see cref="GroupPrincipal"/>.
        /// </summary>
        public static IEnumerable<UserPrincipal> GetUserPrincipals(
            this GroupPrincipal groupPrincipal)
        {
            return groupPrincipal.Members.OfType<UserPrincipal>();
        }

        /// <summary>
        /// Gets the <see cref="ComputerPrincipal"/> members of this 
        /// <see cref="GroupPrincipal"/>.
        /// </summary>
        public static IEnumerable<ComputerPrincipal> GetComputerPrincipals(
            this GroupPrincipal groupPrincipal)
        {
            return groupPrincipal.Members.OfType<ComputerPrincipal>();
        }
    }
}
