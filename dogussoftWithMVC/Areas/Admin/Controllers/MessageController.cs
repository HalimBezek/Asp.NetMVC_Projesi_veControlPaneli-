using dogussoftWithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dogussoftWithMVC.Areas.Admin.Controllers
{
    [dogussoftWithMVC.Areas.Admin.Attribute.GirisKontrol]
    public class MessageController : Controller
    {
        CountController count = new CountController();//sayılarını almak için

        // GET: Admin/Message
        public ActionResult Index()
        {
            DBaseContext db = new DBaseContext();
            
            ViewBag.mesajBilgileri = db.IletisimBilgileris;

            ViewBag.stilmesaj = "active-link";
            ViewBag.colorstilmesaj = "#214761";

            return View();
        }

        public ActionResult mesajDetay(int ID)
        {
            DBaseContext db = new DBaseContext();

            var veriler = db.IletisimBilgileris.First(i => i.Id == ID);
            veriler.goruldu = true;

           // db.IletisimBilgileris.Add(veriler);  yeni bir kayı eklemek iiçin kullanılır
            db.SaveChanges();

            ViewBag.mesajBilgileriDetay = db.IletisimBilgileris.First(i => i.Id == ID);

            return View();
        }

        [HttpPost]
        public ActionResult Index(int ID, String cevapNot)
        {
            DBaseContext db = new DBaseContext();

            var veriler = db.IletisimBilgileris.First(i => i.Id == ID);
            veriler.cevapVerildi = true;
            veriler.CevapTarihi = DateTime.Now;
            veriler.cevapNotu = cevapNot;
                       
            db.SaveChanges();

            ViewBag.mesajBilgileri = db.IletisimBilgileris;

            return View();
        }


    }
}