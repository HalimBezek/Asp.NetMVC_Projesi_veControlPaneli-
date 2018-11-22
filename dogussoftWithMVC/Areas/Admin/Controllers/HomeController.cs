using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dogussoftWithMVC.Areas.Admin.Controllers
{
  
    [dogussoftWithMVC.Areas.Admin.Attribute.GirisKontrol]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.stil = "active-link"; //ViewBag Runtime çalışır yani kod çalışırken hata varsa belli olur. 
            //Ancak aynı işlevde kullanılan ViewData(kullanımı: ViewData["AD"]="halim BEZEK") Compile time çalışır.
            ViewBag.colorstil = "#214761";
            return View();
        }
    }
}