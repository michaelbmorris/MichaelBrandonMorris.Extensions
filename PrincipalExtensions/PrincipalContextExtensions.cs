using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace PrincipalExtensions
{
    /// <summary>
    /// Provides useful extensions for the <see cref="PrincipalContext"/> 
    /// class.
    /// </summary>
    public static class PrincipalContextExtensions
    {
        /// <summary>
        /// Finds the <see cref="Principal"/> in this 
        /// <see cref="PrincipalContext"/> with the specified distinguished 
        /// name.
        /// </summary>
        public static Principal FindPrincipalByDistinguishedName(
            this PrincipalContext principalContext, string distinguishedName)
        {
            return Principal.FindByIdentity(
                principalContext,
                IdentityType.DistinguishedName,
                distinguishedName);
        }

        /// <summary>
        /// Finds the <see cref="UserPrincipal"/> in this 
        /// <see cref="PrincipalContext"/> with the specified distinguished 
        /// name.
        /// </summary>
        public static UserPrincipal FindUserPrincipalByDistinguishedName(
            this PrincipalContext principalContext, string distinguishedName)
        {
            return UserPrincipal.FindByIdentity(
                principalContext,
                IdentityType.DistinguishedName,
                distinguishedName);
        }

        /// <summary>
        /// Finds the <see cref="UserPrincipal"/>s in this 
        /// <see cref="PrincipalContext"/> with the specified distinguished 
        /// names.
        /// </summary>
        public static IEnumerable<UserPrincipal>
            FindUserPrincipalsByDistinguishedNames(
            this PrincipalContext principalContext,
            IEnumerable<string> distinguishedNames)
        {
            return distinguishedNames.Select(
                principalContext.FindUserPrincipalByDistinguishedName);
        }

        /// <summary>
        /// Finds the <see cref="Principal"/>s in this 
        /// <see cref="PrincipalContext"/> with the specified distinguished 
        /// names.
        /// </summary>
        public static IEnumerable<Principal>
            FindPrincipalsByDistinguishedNames(
            this PrincipalContext principalContext,
            IEnumerable<string> distinguishedNames)
        {
            return distinguishedNames.Select(
                principalContext.FindPrincipalByDistinguishedName);
        }
    }
}