using dogussoftWithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dogussoftWithMVC.Controllers
{
    public class HomeController : Controller
    {
        public string bilgilendirmeMesaji = "";
        // GET: Home
        public ActionResult Index()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult Index(demoBilgiler db)
        {
            DBaseContext dataContext = new DBaseContext();
            try
            {
                db.cevapVerildi = false;
                db.TalepTarihi = DateTime.Now;
                db.CevapTarihi = DateTime.Now;
                dataContext.demoBilgilers.Add(db);

                dataContext.SaveChanges();
                ViewBag.Bilgi = "Talebiniz alındı, en kısa sürede sizinle iletişim sağlayacağız.";
               
            }
            catch (Exception )
            {
                ViewBag.Bilgi = "Bir hata oluştu! daha sonra tekrar deneyin. ";
                throw;
            }
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact(string mesaj)
        {
            ViewBag.Bilgi = mesaj;
            return View();
        }

        [HttpPost]
        public ActionResult Contact( IletisimBigileri Ib)
        {
            Ib.CevapTarihi = DateTime.Now;
            Ib.cevapVerildi = false;
            Ib.TalepTarihi = DateTime.Now;

            try
            {
                DBaseContext db = new DBaseContext();

                db.IletisimBilgileris.Add(Ib);
                db.SaveChanges();
                ViewBag.Bilgi = "İletişim bilgieriniz başarıyla alındı. En kısa sürede geri dönüş sağlayacağız";
            }
            catch (Exception)
            {
                ViewBag.Bilgi = "Bir hata oluştu! daha sonra tekrar deneyin. ";
            
            }

            
            return View();
        }

        public ActionResult Referances()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult SolutionPartner()
        {
            return View();
        }
    }
}