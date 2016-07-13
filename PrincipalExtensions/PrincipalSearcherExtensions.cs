using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;

namespace PrincipalExtensions
{
    /// <summary>
    /// Provides useful extensions for the <see cref="PrincipalSearcher"/> 
    /// class.
    /// </summary>
    public static class PrincipalSearcherExtensions
    {
        /// <summary>
        /// Gets all <see cref="ComputerPrincipal"/>s from this 
        /// <see cref="PrincipalSearcher"/>.
        /// </summary>
        public static IEnumerable<ComputerPrincipal> GetAllComputerPrincipals(
            this PrincipalSearcher principalSearcher)
        {
            return principalSearcher.FindAll().GetComputerPrincipals();
        }

        /// <summary>
        /// Gets all <see cref="UserPrincipal"/>s from this 
        /// <see cref="PrincipalSearcher"/>.
        /// </summary>
        public static IEnumerable<UserPrincipal> GetAllUserPrincipals(
            this PrincipalSearcher principalSearcher)
        {
            return principalSearcher.FindAll().GetUserPrincipals();
        }

        /// <summary>
        /// Gets all <see cref="GroupPrincipal"/>s from this 
        /// <see cref="PrincipalSearcher"/>.
        /// </summary>
        public static IEnumerable<GroupPrincipal> GetAllGroupPrincipals(
            this PrincipalSearcher principalSearcher)
        {
            return principalSearcher.FindAll().GetGroupPrincipals();
        }
    }
}