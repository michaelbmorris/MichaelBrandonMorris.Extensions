using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace MichaelBrandonMorris.Extensions.WebExtensions
{
    /// <summary>
    ///     Class ControllerExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for ControllerExtensions
    public static class ControllerExtensions
    {
        /// <summary>
        ///     Gets the user.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <returns>IdentityUser.</returns>
        /// TODO Edit XML Comment Template for GetUser
        public static IdentityUser GetUser(this IController controller)
        {
            return HttpContext.Current.GetOwinContext()
                .GetUserManager<UserManager<IdentityUser>>()
                .FindById(HttpContext.Current.User.Identity.GetUserId());
        }
    }
}