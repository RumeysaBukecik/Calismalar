using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rumbotecik
{
    public partial class KullaniciKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string FotoUpload()
        {
            HttpPostedFile yuklenecekDosya = input_FotoUpload.PostedFile;
            string dosyaAdresi="";
            if (yuklenecekDosya != null)
            {
                FileInfo dosyaBilgisi = new FileInfo(yuklenecekDosya.FileName);
                string dizin = "IMG/Blog-Resimleri";

                string dosyaAdi = dosyaBilgisi.Name.Substring(0, dosyaBilgisi.Name.Length - dosyaBilgisi.Extension.Length);
                string gun = DateTime.Now.ToString("yyyy-MM-dd");

                //dosyaAdi += gun + dosyaBilgisi.Extension;
                dosyaAdi += "-" + gun + "-" + Guid.NewGuid().ToString().Replace("-", "") + dosyaBilgisi.Extension;

                string yuklenenDosya = Server.MapPath("~/" + dizin + "/" + dosyaAdi);
                dosyaAdresi = dizin + "/" + dosyaAdi;

                input_FotoUpload.SaveAs(yuklenenDosya);
            }
            return dosyaAdresi;
        }
        protected void btn_KaullaniciKaydet_Click(object sender, EventArgs e)
        {
            Kullanici k1 = new Kullanici();
            k1.KullaniciAdSoyad = txt_KullaniciAdSoyad.Text;
            k1.KullaniciDogumTarihi = Convert.ToDateTime(input_KullaniciDogumTarihi.Value.ToString());
            k1.KullaniciFotoUrl = FotoUpload();
            k1.KullaniciEposta = txt_KullaniciEposta.Text;
            k1.KullaniciParola = txt_KullaniciParola.Text;

            BLOGEntities db = new BLOGEntities();
            db.Kullanicis.Add(k1);
            db.SaveChanges();
        }
    }
}