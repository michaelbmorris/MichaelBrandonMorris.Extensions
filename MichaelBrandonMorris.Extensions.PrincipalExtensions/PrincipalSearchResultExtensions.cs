using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    ///     Class PrincipalSearchResultExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for PrincipalSearchResultExtensions
    public static class PrincipalSearchResultExtensions
    {
        /// <summary>
        ///     Gets the computer principals.
        /// </summary>
        /// <param name="principalSearchResult">
        ///     The principal search
        ///     result.
        /// </param>
        /// <returns>IEnumerable&lt;ComputerPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetComputerPrincipals
        public static IEnumerable<ComputerPrincipal> GetComputerPrincipals(
            this PrincipalSearchResult<Principal> principalSearchResult)
        {
            return principalSearchResult.OfType<ComputerPrincipal>();
        }

        /// <summary>
        ///     Gets the group principals.
        /// </summary>
        /// <param name="principalSearchResult">
        ///     The principal search
        ///     result.
        /// </param>
        /// <returns>IEnumerable&lt;GroupPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetGroupPrincipals
        public static IEnumerable<GroupPrincipal> GetGroupPrincipals(
            this PrincipalSearchResult<Principal> principalSearchResult)
        {
            return principalSearchResult.OfType<GroupPrincipal>();
        }

        /// <summary>
        ///     Gets the user principals.
        /// </summary>
        /// <param name="principalSearchResult">
        ///     The principal search
        ///     result.
        /// </param>
        /// <returns>IEnumerable&lt;UserPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetUserPrincipals
        public static IEnumerable<UserPrincipal> GetUserPrincipals(
            this PrincipalSearchResult<Principal> principalSearchResult)
        {
            return principalSearchResult.OfType<UserPrincipal>();
        }
    }
}