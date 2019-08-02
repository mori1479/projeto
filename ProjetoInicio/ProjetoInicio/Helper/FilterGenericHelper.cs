using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetoInicio.Helper
{
        public class FilteGenericHelper : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                object admin = filterContext.HttpContext.Session["admLogado"];
                object cliente = filterContext.HttpContext.Session["usuarioLogado"];
                if (admin == null && cliente == null)
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
