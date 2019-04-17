using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VB_KullaniciGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.; Database=KullaniciGiris; uid=sa; pwd=1234");

        private void Buton_Gonder_Click(object sender, EventArgs e)
        {
            string sKullaniciAdi = Text_KullaniciAdi.Text;
            string sParola = Text_Parola.Text;

            SqlCommand KomutEkle = new SqlCommand();
            KomutEkle.Connection = baglanti;
            KomutEkle.CommandText = @"select * from KullaniciFormGiris where KullaniciAdi=@KullaniciAdi and Parola=@Parola";
            KomutEkle.Parameters.AddWithValue("@KullaniciAdi", sKullaniciAdi);
            KomutEkle.Parameters.AddWithValue("@Parola", sParola);

            baglanti.Open();
            SqlDataReader reader = KomutEkle.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Kullanıcı giriş başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı giriş hatalı");
            }

            baglanti.Close();
        }

        private void Buton_Kayit_Click(object sender, EventArgs e)
        {
            string sKullaniciAdi = Text_KullaniciAdi.Text;
            string sParola = Text_Parola.Text;

            SqlCommand komutEkle = new SqlCommand($@"INSERT INTO KullaniciFormGiris (KullaniciAdi, Parola) VALUES(@KullaniciAdi,@Parola)");
            komutEkle.Parameters.AddWithValue("@KullaniciAdi", sKullaniciAdi);
            komutEkle.Parameters.AddWithValue("@Parola", sParola);
            komutEkle.Connection = baglanti;
            baglanti.Open();

            int etkilenensatirsayisi = komutEkle.ExecuteNonQuery();
            if (etkilenensatirsayisi>0)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Hatalı");
            }

            baglanti.Close();

        }
    }
}
