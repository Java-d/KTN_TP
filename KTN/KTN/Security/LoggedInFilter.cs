using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KTN.Security
{
    public class LoggedInFilter : ActionFilterAttribute, IActionFilter
    { 
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {

            var isLoggedIn = filterContext.HttpContext.Session["IsAuth"];
            if (isLoggedIn == null || !(bool)isLoggedIn)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Account", action = "Login" })
                );
            }
            this.OnActionExecuting(filterContext);
        }
    }
}