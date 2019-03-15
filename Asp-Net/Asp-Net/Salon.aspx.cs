using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Net
{
    public partial class Salon1 : System.Web.UI.Page
    {
        protected void Tablo_Cek()
        {
            SINEMAEntities ctx = new SINEMAEntities();
            DataList_Salonlar.DataSource = ctx.Salons.ToList();
            DataList_Salonlar.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            Tablo_Cek();
        }

        protected void btn_SalonKaydet_Click(object sender, EventArgs e)
        {
            Salon s1 = new Salon();
            s1.SalonAdi = txt_SalonAd.Text;
            s1.SalonTest = txt_SalonTest.Text;

            SINEMAEntities ctx = new SINEMAEntities();
            ctx.Salons.Add(s1);
            ctx.SaveChanges();
            Tablo_Cek();
        }

        protected void DataList_Salonlar_EditCommand(object source, DataListCommandEventArgs e)
        {
            // Editlemeyi Aktif Hale Getirdik.
            DataList_Salonlar.EditItemIndex = e.Item.ItemIndex;
            Tablo_Cek();
        }

        protected void DataList_Salonlar_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            // CommandArgument ile gönderilen ID değerini değişkene atadık.
            int txtSalonID = Convert.ToInt32(e.CommandArgument);

            SINEMAEntities ctx = new SINEMAEntities();

            // gelen ID li elemanı veritabanından bulup 
            // s1 nesnesine atadık
            Salon s1 = ctx.Salons.Find(txtSalonID);

            ctx.Salons.Remove(s1);
            ctx.SaveChanges();
            Tablo_Cek();
        }

        protected void DataList_Salonlar_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            // Update İşlemleri

            int txtID = Convert.ToInt32(e.CommandArgument);

            // Formdan gelen textboxları eşledik. getElementByID benzeri, textbox a çevirdik.

            TextBox txtSalonAd = e.Item.FindControl("txt_Guncelle_SalonAdi") as TextBox;
            TextBox txtSalonTest = e.Item.FindControl("txt_Guncelle_SalonTest") as TextBox;

            SINEMAEntities ctx = new SINEMAEntities();

            Salon s1 = ctx.Salons.Find(txtID);
            s1.SalonID = txtID;
            s1.SalonAdi = txtSalonAd.Text;
            s1.SalonTest = txtSalonTest.Text;

            ctx.SaveChanges();
            // Editleme ekranını kapatır.
            DataList_Salonlar.EditItemIndex = -1;

            //Tabloyu günceller
            Tablo_Cek();
        }

        protected void DataList_Salonlar_CancelCommand(object source, DataListCommandEventArgs e)
        {
            // Editleme Ekranından Çıkmasını Sağlıyor.
            DataList_Salonlar.EditItemIndex = -1;
            Tablo_Cek();
        }
    }
}