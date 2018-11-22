using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dogussoftWithMVC.Areas.Admin.Controllers
{
    public class PartialController : Controller
    {
        // GET: Admin/Partial
        public ActionResult Menu()
        {
            CountController count = new CountController();//sayılarını almak için


            ViewBag.mesajSayi = count.sayiMesaj;
            ViewBag.demoSayi = count.sayiDemoTalep;
            
            return PartialView();
        }
    }
}