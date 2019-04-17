using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_2
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               // LİSTELEME İŞLEMLERİ
               var sinema_ctx = new SINEMAEntities();
               //dataGridView1.DataSource = sinema_ctx.Films.ToList();
               //dataGridView1.Columns["Yayins"].Visible = false;

               //var sorgu = sinema_ctx.Films.Where(f1 => f1.FilmID < 6).ToList();

               //var sorgu = sinema_ctx.Films.SqlQuery("SELECT FilmID,FilmAdi,FilmKisaBilgi,FilmFragmanLink FROM Film WHERE FilmID>15").ToList();

               var sorgu = sinema_ctx.Films
                             .Where(f => f.FilmAdi.Length<15)
                             .Select(f => new {
                                  Id = f.FilmID,
                                  Name = f.FilmAdi
                             });
               dataGridView1.DataSource = sorgu.ToList();
          }

          private void btn_FilmKaydet_Click(object sender, EventArgs e)
          {
               // KAYDETME İŞLEMLERİ

               SINEMAEntities sinema_ctx = new SINEMAEntities();
               //var sinema_ctx = new SINEMAEntities();
               // 2. tanımlama yöntemi

               Film f1 = new Film();
               f1.FilmAdi = textBox_FilmAdi_1.Text;
               f1.FilmKisaBilgi = textBox_KisaBilgi.Text;
               f1.FilmFragmanLink = textBox_FilmFragman.Text;

               sinema_ctx.Films.Add(f1);
               sinema_ctx.SaveChanges();
               MessageBox.Show(f1.FilmID.ToString());
          }

          private void button1_Click(object sender, EventArgs e)
          {
               // GÜNCELLEME İŞLEMLERİ
               var ctx = new SINEMAEntities();

               int filmID = Convert.ToInt32(textBox2.Text);

               var f1 = ctx.Films.Find(filmID);
               f1.FilmFragmanLink = textBox1.Text;
               ctx.SaveChanges();
               dataGridView1.DataSource = ctx.Films.ToList();

               MessageBox.Show(f1.FilmAdi.ToString());
          }

          private void button_Sil_Click(object sender, EventArgs e)
          {
               //SİLME İŞLEMLERİ
               SINEMAEntities ctx = new SINEMAEntities();
               int FilmID = Convert.ToInt32(textBox_Sil_ID.Text);
               Film f1 = ctx.Films.Find(FilmID);
               ctx.Films.Remove(f1);
               ctx.SaveChanges();
               dataGridView1.DataSource = ctx.Films.ToList();
               
          }
     }
}
