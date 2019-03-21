using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rumbotecik
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_KaullaniciGiris_Click(object sender, EventArgs e)
        {
            string eposta = txt_KullaniciEposta.Text.Trim();
            // SQLInjection Önlemi!!
            eposta = eposta.Replace("'", "");

            string parola = txt_KullaniciParola.Text.Trim();
            parola = parola.Replace("'", "");

            string sqlquery = $"SELECT * FROM Kullanici WHERE KullaniciEposta='{eposta}' AND KullaniciParola='{parola}'";
            BLOGEntities vt = new BLOGEntities();
            Kullanici k1 = vt.Kullanicis.SqlQuery(sqlquery).FirstOrDefault();
            if (k1 != null)
            {
                Session.Add("Oturum", k1.KullaniciID);
                Response.Redirect("BlogYaz.aspx");
            }
            else
            {
                Console.WriteLine("E-posta adresi veya parola geçersiz !!!");
            }

        }
    }
}