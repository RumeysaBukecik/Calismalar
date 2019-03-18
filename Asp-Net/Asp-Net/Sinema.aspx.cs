using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Net
{
    public partial class Sinema : System.Web.UI.Page
    {
        protected void Tablo_Cek()
        {
            SINEMAEntities ctx = new SINEMAEntities();
            DataList_Filmler.DataSource = ctx.Films.ToList();
            DataList_Filmler.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Güncelleme sırasında 
            // Kaydet tıklandığında PageLoad olayı önden çalıştığı için
            // textBox'a girilen veriler veritabanına kaydedilmeden kayboluyordu.
            // DataList güncellendiği için.
            // Aşağıdaki kontrol ile sayfadan gelen bir load işleminde;
            // Tablo güncellenmeden devam edilsin dedik.
            // tıklamadan sonra Load işlemi gerçekleşiyorsa çık.
            if (IsPostBack)
                return;

            Tablo_Cek();
        }
        protected void btn_FilmKaydet_Click(object sender,EventArgs e)
        {
            Film f1 = new Film();
            f1.FilmAdi = txt_FilmAd.Text;
            f1.FilmFragmanLink = txt_FilmFragman.Text;
            f1.FilmKisaBilgi = txt_FilmKisaBilgi.Text;

            SINEMAEntities ctx = new SINEMAEntities();
            ctx.Films.Add(f1);
            ctx.SaveChanges();
            Tablo_Cek();
        }

        protected void DataList_Filmler_DeleteCommand(object source, DataListCommandEventArgs e)
        {

            // CommandArgument ile gönderilen ID değerini değişkene atadık.
            int txtFilmID = Convert.ToInt32(e.CommandArgument);

            SINEMAEntities ctx = new SINEMAEntities();

            // gelen ID li elemanı veritabanından bulup 
            // f1 nesnesine atadık
            Film f1 = ctx.Films.Find(txtFilmID);

            ctx.Films.Remove(f1);
            ctx.SaveChanges();
            Tablo_Cek();
        }

        protected void DataList_Filmler_EditCommand(object source, DataListCommandEventArgs e)
        {
            // Editlemeyi Aktif Hale Getirdik.
            DataList_Filmler.EditItemIndex = e.Item.ItemIndex;
            Tablo_Cek();
        }

        protected void DataList_Filmler_CancelCommand(object source, DataListCommandEventArgs e)
        {
            // Editleme Ekranından Çıkmasını Sağlıyor.
            DataList_Filmler.EditItemIndex = -1;
            Tablo_Cek();
        }

        protected void DataList_Filmler_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            // Update İşlemleri

            int txtID = Convert.ToInt32(e.CommandArgument);

            // Formdan gelen textboxları eşledik. getElementByID benzeri, textbox a çevirdik.

            TextBox txtFilmAd = e.Item.FindControl("txt_Guncelle_FilmAdi") as TextBox;
            TextBox txtFilmFragmanLink = e.Item.FindControl("txt_Guncelle_FilmFragmanLink") as TextBox;
            TextBox txtFilmKisaBilgi = e.Item.FindControl("txt_Guncelle_FilmKisaBilgi") as TextBox;

            SINEMAEntities ctx = new SINEMAEntities();

            Film f1 = ctx.Films.Find(txtID);
            f1.FilmID = txtID;
            f1.FilmAdi = txtFilmAd.Text;
            f1.FilmFragmanLink = txtFilmFragmanLink.Text;
            f1.FilmKisaBilgi = txtFilmKisaBilgi.Text;

            ctx.SaveChanges();
            // Editleme ekranını kapatır.
            DataList_Filmler.EditItemIndex = -1;

            //Tabloyu günceller.
            Tablo_Cek();
        }
    }
}