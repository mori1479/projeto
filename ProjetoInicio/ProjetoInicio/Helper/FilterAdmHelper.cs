using ProjetoInicio.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetoInicio.Helper
{
    public class FilterAdmHelper : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuario = filterContext.HttpContext.Session["admLogado"];

            if (usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index" }
                    )
                );
            }
        }

    }
}