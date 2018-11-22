using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using dogussoftWithMVC.Models;

namespace dogussoftWithMVC.Areas.Admin.Controllers
{
    public class GirisController : Controller
    {
        // GET: Admin/Giris
        public ActionResult giris()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult giris(String username, String password)
        {
            DBaseContext db = new DBaseContext();
           var user =  db.Users.Where(i => i.kullanici_adi == username).Where(i => i.sifre == password ).Where(i => i.durum == true );

            if (user.Count()>0)
            {
                
               Session.Add("ID", "1"); //veya Session.Add["ID"] = "1"; ve ya System.Web.HttpContext.Current.Session["ID"] = "1";olabilirdi.
                //okurken : HttpContext.Current.Session["ID"] ve ya  Response.Write(Session["ID"].ToString()); olabilir.

                return Redirect("/Admin");
            }
            else
            {
                return Redirect("/Admin/Giris/Giris");
            }
           
        }
        public ActionResult Cikis(String username, String password)
        {

            Session["ID"]=null;

            return Redirect("/Admin/Giris/Giris");
           
        }
    }
}