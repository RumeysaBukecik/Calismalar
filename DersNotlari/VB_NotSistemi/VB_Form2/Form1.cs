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

namespace VB_Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.; Database=VB_VizeFinal; uid=sa; pwd=1234");

        private void button_Gonder_Click(object sender, EventArgs e)
        {
            string OgrenciNum = txt_OgrNo.Text;
            string DersAdi = txt_DersAdi.Text;
            string Vize = txt_Vize.Text;
            string Final = txt_Final.Text;
            int iVize = Convert.ToInt32(Vize);
            int iFinal = Convert.ToInt32(Final);

            SqlCommand komutEkle = new SqlCommand($@"INSERT INTO VizeFinal (OgrenciNum, DersAdi, Vize, Final) VALUES('{OgrenciNum}','{DersAdi}','{Vize}','{Final}')", baglanti);
            baglanti.Open();
            int etkilenensatirsayisi = komutEkle.ExecuteNonQuery();
            if (etkilenensatirsayisi > 0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı.");
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.");
            }
            
            double ortalama=((iFinal*60)/100)+((iVize*40)/100);
            if (ortalama<50)
            {
                MessageBox.Show($"Kaldınız. \nNotunuz: {ortalama}");
            }
            else if (ortalama<60)
            {
                MessageBox.Show($"D\nNotunuz: {ortalama}");
            }
            else if (ortalama<70)
            {
                MessageBox.Show($"C\nNotunuz: {ortalama}");
            }
            else if (ortalama<80)
            {
                MessageBox.Show($"B\nNotunuz: {ortalama}");
            }
            else if (ortalama>=80)
            {
                MessageBox.Show($"A\nNotunuz: {ortalama}");
            }
            
            baglanti.Close();
        }
    }
}
