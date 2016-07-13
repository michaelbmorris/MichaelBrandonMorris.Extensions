using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace PrincipalExtensions
{
    /// <summary>
    /// Provides useful extensions for the <see cref="GroupPrincipal"/> class.
    /// </summary>
    public static class GroupPrincipalExtensions
    {
        private const string ManagedBy = "managedBy";

        /// <summary>
        /// Gets the managed by property of this <see cref="GroupPrincipal"/>'s
        ///  underlying <see cref="DirectoryEntry"/>.
        /// </summary>
        public static string GetManagedBy(this GroupPrincipal groupPrincipal)
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
