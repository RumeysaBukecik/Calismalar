using rumeysabukecik_com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rumeysabukecik_com.Controllers
{
    public class KullaniciController : Controller
    {
        BLOGEntities vt = new BLOGEntities();
        // GET: Kullanici

        public byte OturumKontrol()
        {

            if (Session["KullaniciID"] == null)
            {
                return 0;
            }
            else
            {
                var aktifKullaniciId = Convert.ToInt32(Session["KullaniciID"]);
                Kullanici aktifKullanici = vt.Kullanicis.FirstOrDefault(x => x.KullaniciID == aktifKullaniciId);
                return Convert.ToByte(aktifKullanici.KullaniciYetki);
            }
        }
        public ActionResult Index()
        {
            if (Session["KullaniciID"]==null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Merhaba = "Merhaba, hoş geldiniz sayın kullanıcı..";
            }
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(string KullaniciEposta, string KullaniciParola)
        {
            Kullanici kontrolkullanicisi = vt.Kullanicis.FirstOrDefault(x => x.KullaniciEposta == KullaniciEposta && x.KullaniciParola == KullaniciParola);

            if (kontrolkullanicisi!=null)
            {
                ViewBag.Oturum="Giriş Başarılı";
                Session["KullaniciID"] = kontrolkullanicisi.KullaniciID;
            }
            else
            {
                ViewBag.Oturum = "Hatalı";

            }
            return View();
        }

    }
}