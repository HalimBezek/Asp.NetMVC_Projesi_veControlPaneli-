using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using dogussoftWithMVC.Models;

namespace dogussoftWithMVC.Areas.Admin.Controllers
{
    public class CountController : Controller
    {
        public int sayiMesaj=0 , sayiDemoTalep=0;
        DBaseContext db = new DBaseContext();

        public CountController() {
            sayiMesaj = db.IletisimBilgileris.Where(i => i.goruldu==false).Count();
            sayiDemoTalep = db.demoBilgilers.Where(i => i.goruldu == false).Count();
           
        }

        // GET: Admin/Count
        public ActionResult Index()
        {
            return View();
        }
        
    }
}
