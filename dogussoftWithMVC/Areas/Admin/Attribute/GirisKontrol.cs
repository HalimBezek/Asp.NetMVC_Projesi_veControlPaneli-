using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dogussoftWithMVC.Areas.Admin.Attribute
{
    public class GirisKontrol :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["ID"] == null)
            {
                filterContext.HttpContext.Response.Redirect("/Admin/Giris/Giris");
                //ve ya filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Index" }));
            }

            base.OnActionExecuting(filterContext);
        }
    }
}