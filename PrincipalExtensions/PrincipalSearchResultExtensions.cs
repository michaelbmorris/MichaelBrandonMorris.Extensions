using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace PrincipalExtensions
{
    /// <summary>
    /// Provides useful extensions for the 
    /// <see cref="PrincipalSearchResult{T}"/> class.
    /// </summary>
    public static class PrincipalSearchResultExtensions
    {
        /// <summary>
        /// Gets the <see cref="ComputerPrincipal"/>s from this 
        /// <see cref="PrincipalSearchResult{Principal}"/>.
        /// </summary>
        public static IEnumerable<ComputerPrincipal> GetComputerPrincipals(
            this PrincipalSearchResult<Principal> principalSearchResult)
        {
            return principalSearchResult.OfType<ComputerPrincipal>();
        }

        /// <summary>
        /// Gets the <see cref="GroupPrincipal"/>s from this 
        /// <see cref="PrincipalSearchResult{Principal}"/>.
        /// </summary>
        public static IEnumerable<GroupPrincipal> GetGroupPrincipals(
            this PrincipalSearchResult<Principal> principalSearchResult)
        {
            return principalSearchResult.OfType<GroupPrincipal>();
        }

        /// <summary>
        /// Gets the <see cref="UserPrincipal"/>s from this 
        /// <see cref="PrincipalSearchResult{Principal}"/>.
        /// </summary>
        public static IEnumerable<UserPrincipal> GetUserPrincipals(
            this PrincipalSearchResult<Principal> principalSearchResult)
        {
            return principalSearchResult.OfType<UserPrincipal>();
        }
    }
}
