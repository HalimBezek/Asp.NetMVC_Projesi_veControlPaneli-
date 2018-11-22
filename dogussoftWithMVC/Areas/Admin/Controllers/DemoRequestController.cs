using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dogussoftWithMVC.Models;

namespace dogussoftWithMVC.Areas.Admin.Controllers
{
    [dogussoftWithMVC.Areas.Admin.Attribute.GirisKontrol]
    public class DemoRequestController : Controller
    {
        CountController count = new CountController();//sayılarını almak için
      

        // GET: Admin/DemoRequest
        public ActionResult Index()
        {
            
            DBaseContext db = new DBaseContext();

            ViewBag.demoTalepBilgileri = db.demoBilgilers;
            ViewBag.stildemo = "active-link";
            ViewBag.colorstildemo = "#214761";

            return View();
        }

        
        public ActionResult requestDetay(int ID)
        {
            DBaseContext db = new DBaseContext();

            var veriler = db.demoBilgilers.First(i => i.Id == ID);
            veriler.goruldu = true;

            // db.IletisimBilgileris.Add(veriler);  yeni bir kayı eklemek iiçin kullanılır
            db.SaveChanges();

            ViewBag.demoBilgileriDetay = db.demoBilgilers.First(i => i.Id == ID);

            return View();
        }

        [HttpPost]
        public ActionResult Index(int ID, String cevapNot)
        {
            DBaseContext db = new DBaseContext();

            var veriler = db.demoBilgilers.First(i => i.Id == ID);
            veriler.cevapVerildi = true;
            veriler.CevapTarihi = DateTime.Now;
            veriler.cevapNotu = cevapNot;

            db.SaveChanges();

            ViewBag.demoTalepBilgileri = db.demoBilgilers;

            return View();
        }
    }
}