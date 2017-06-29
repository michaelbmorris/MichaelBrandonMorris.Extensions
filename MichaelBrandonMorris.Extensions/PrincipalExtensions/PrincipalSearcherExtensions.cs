using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    ///     Class PrincipalSearcherExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for PrincipalSearcherExtensions
    public static class PrincipalSearcherExtensions
    {
        /// <summary>
        ///     Gets all computer principals.
        /// </summary>
        /// <param name="principalSearcher">The principal searcher.</param>
        /// <returns>IEnumerable&lt;ComputerPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetAllComputerPrincipals
        public static IEnumerable<ComputerPrincipal> GetAllComputerPrincipals(
            this PrincipalSearcher principalSearcher)
        {
            return principalSearcher.FindAll().GetComputerPrincipals();
        }

        /// <summary>
        ///     Gets all group principals.
        /// </summary>
        /// <param name="principalSearcher">The principal searcher.</param>
        /// <returns>IEnumerable&lt;GroupPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetAllGroupPrincipals
        public static IEnumerable<GroupPrincipal> GetAllGroupPrincipals(
            this PrincipalSearcher principalSearcher)
        {
            return principalSearcher.FindAll().GetGroupPrincipals();
        }

        /// <summary>
        ///     Gets all user principals.
        /// </summary>
        /// <param name="principalSearcher">The principal searcher.</param>
        /// <returns>IEnumerable&lt;UserPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for GetAllUserPrincipals
        public static IEnumerable<UserPrincipal> GetAllUserPrincipals(
            this PrincipalSearcher principalSearcher)
        {
            return principalSearcher.FindAll().GetUserPrincipals();
        }
    }
}