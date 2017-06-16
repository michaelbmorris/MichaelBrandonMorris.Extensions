using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace MichaelBrandonMorris.Extensions.OtherExtensions
{
    /// <summary>
    /// Provides extensions for classes that implement the
    /// <see cref="IController" /> interface.
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// Gets the <see cref="IdentityUser" /> for the current
        /// <see cref="HttpContext" />.
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static IdentityUser GetUser(this IController controller)
        {
            return HttpContext.Current.GetOwinContext()
                .GetUserManager<UserManager<IdentityUser>>()
                .FindById(HttpContext.Current.User.Identity.GetUserId());
        }
    }
}