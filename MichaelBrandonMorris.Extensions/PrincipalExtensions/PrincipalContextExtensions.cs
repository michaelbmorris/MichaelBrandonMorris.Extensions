using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace MichaelBrandonMorris.Extensions.PrincipalExtensions
{
    /// <summary>
    ///     Class PrincipalContextExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for PrincipalContextExtensions
    public static class PrincipalContextExtensions
    {
        /// <summary>
        ///     Finds the name of the principal by distinguished.
        /// </summary>
        /// <param name="principalContext">The principal context.</param>
        /// <param name="distinguishedName">Name of the distinguished.</param>
        /// <returns>Principal.</returns>
        /// TODO Edit XML Comment Template for FindPrincipalByDistinguishedName
        public static Principal FindPrincipalByDistinguishedName(
            this PrincipalContext principalContext,
            string distinguishedName)
        {
            return Principal.FindByIdentity(
                principalContext,
                IdentityType.DistinguishedName,
                distinguishedName);
        }

        /// <summary>
        ///     Finds the principals by distinguished names.
        /// </summary>
        /// <param name="principalContext">The principal context.</param>
        /// <param name="distinguishedNames">The distinguished names.</param>
        /// <returns>IEnumerable&lt;Principal&gt;.</returns>
        /// TODO Edit XML Comment Template for FindPrincipalsByDistinguishedNames
        public static IEnumerable<Principal> FindPrincipalsByDistinguishedNames(
            this PrincipalContext principalContext,
            IEnumerable<string> distinguishedNames)
        {
            return distinguishedNames.Select(
                principalContext.FindPrincipalByDistinguishedName);
        }

        /// <summary>
        ///     Finds the name of the user principal by distinguished.
        /// </summary>
        /// <param name="principalContext">The principal context.</param>
        /// <param name="distinguishedName">Name of the distinguished.</param>
        /// <returns>UserPrincipal.</returns>
        /// TODO Edit XML Comment Template for FindUserPrincipalByDistinguishedName
        public static UserPrincipal FindUserPrincipalByDistinguishedName(
            this PrincipalContext principalContext,
            string distinguishedName)
        {
            return UserPrincipal.FindByIdentity(
                principalContext,
                IdentityType.DistinguishedName,
                distinguishedName);
        }

        /// <summary>
        ///     Finds the user principals by distinguished names.
        /// </summary>
        /// <param name="principalContext">The principal context.</param>
        /// <param name="distinguishedNames">The distinguished names.</param>
        /// <returns>IEnumerable&lt;UserPrincipal&gt;.</returns>
        /// TODO Edit XML Comment Template for FindUserPrincipalsByDistinguishedNames
        public static IEnumerable<UserPrincipal>
            FindUserPrincipalsByDistinguishedNames(
                this PrincipalContext principalContext,
                IEnumerable<string> distinguishedNames)
        {
            return distinguishedNames.Select(
                principalContext.FindUserPrincipalByDistinguishedName);
        }

        /// <summary>
        ///     Gets the principal context.
        /// </summary>
        /// <returns>PrincipalContext.</returns>
        /// TODO Edit XML Comment Template for GetPrincipalContext
        public static PrincipalContext GetPrincipalContext()
        {
            return new PrincipalContext(ContextType.Domain);
        }
    }
}