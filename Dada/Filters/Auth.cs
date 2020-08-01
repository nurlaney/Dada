using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Repository.Repositories.AccountRepositories;

namespace Dada.Filters
{
    public class Auth : ActionFilterAttribute
    {
        private readonly IUserRepository _userRepository;

        public Auth(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Cookies.TryGetValue("user-token", out string token))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "index", controller = "auth" }));
            }

            var user = _userRepository.CheckByToken(token);

            if (user == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "index", controller = "auth" }));
            }

            var controller = context.Controller as Controller;

            if (controller != null)
            {
                controller.ViewBag.User = user;
            }

            context.RouteData.Values["User"] = user;
        }
    }
}