using Microsoft.AspNetCore.Mvc.Filters;

namespace CMSPlus.Presentation.CustomAttribute
{
    public class CustomAuthorizationFilter: IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (!user.Identity.IsAuthenticated)
            {
                context.ModelState.AddModelError(string.Empty, "You must be logged in to add a comment.");
            }
        }
    }
}
