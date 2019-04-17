using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hOkul_VT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var okul_ctx = new hOkul_VTEntities();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            hOkul_VTEntities okul_ctx = new hOkul_VTEntities();

            Ogretmenler Ogrtmn1 = new Ogretmenler();
            Ogrtmn1.OgretmenAdi = textBox_Ogrtmn_Adi.Text;
            Ogrtmn1.DogumTarihi = dateTimePicker.Value;

            okul_ctx.Ogretmenlers.Add(Ogrtmn1);
            okul_ctx.SaveChanges();
            dataGridView1.DataSource = okul_ctx.Ogretmenlers.ToList();
            MessageBox.Show(Ogrtmn1.OgretmenID.ToString());
        }

        private void button_Gncl_Click(object sender, EventArgs e)
        {
            var okul_ctx = new hOkul_VTEntities();

            int OgretmenID = Convert.ToInt32(textBox_Ogrtmn_Adi.Tag);

            var ogrtmn1 = okul_ctx.Ogretmenlers.Find(OgretmenID);

            ogrtmn1.OgretmenAdi = textBox_Ogrtmn_Adi.Text;
            okul_ctx.SaveChanges();
            dataGridView1.DataSource = okul_ctx.Ogretmenlers.ToList();
            MessageBox.Show(ogrtmn1.OgretmenAdi.ToString());
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Ogrtmn_Adi.Tag = dataGridView1.CurrentRow.Cells[0].Value;
            textBox_Ogrtmn_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[2].Value==null|| dataGridView1.CurrentRow.Cells[2].Value=="")
            {
                dateTimePicker.Value = DateTime.Now;
            }
            else
            {
                dateTimePicker.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);

            }
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            hOkul_VTEntities okul_ctx = new hOkul_VTEntities();
            int OgretmenID = Convert.ToInt32(textBox_Ogrtmn_Adi.Tag);
            Ogretmenler ogt1 = okul_ctx.Ogretmenlers.Find(OgretmenID);
            okul_ctx.Ogretmenlers.Remove(ogt1);
            okul_ctx.SaveChanges();
            dataGridView1.DataSource = okul_ctx.Ogretmenlers.ToList();
        }

        private void button_Ekle2_Click(object sender, EventArgs e)
        {
            hOkul_VTEntities okul_ctx2 = new hOkul_VTEntities();

            Ogrenciler Ogrnci1 = new Ogrenciler();
            Ogrnci1.OgrenciAdi = textBox_Ogrnci_Adi.Text;

            okul_ctx2.Ogrencilers.Add(Ogrnci1);
            okul_ctx2.SaveChanges();
            dataGridView2.DataSource = okul_ctx2.Ogrencilers.ToList();
            MessageBox.Show(Ogrnci1.OgrenciID.ToString());
        }

        private void button_Gncl2_Click(object sender, EventArgs e)
        {
            var okul_ctx2 = new hOkul_VTEntities();

            int OgrenciID = Convert.ToInt32(textBox_Ogrnci_Adi.Tag);

            var Ogrnci1 = okul_ctx2.Ogrencilers.Find(OgrenciID);

            Ogrnci1.OgrenciAdi = textBox_Ogrnci_Adi.Text;
            okul_ctx2.SaveChanges();
            dataGridView2.DataSource = okul_ctx2.Ogrencilers.ToList();
            MessageBox.Show(Ogrnci1.OgrenciAdi.ToString());
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBox_Ogrnci_Adi.Tag = dataGridView2.CurrentRow.Cells[0].Value;
            textBox_Ogrnci_Adi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void button_Sil2_Click(object sender, EventArgs e)
        {
            hOkul_VTEntities okul_ctx2 = new hOkul_VTEntities();
            int OgrenciID = Convert.ToInt32(textBox_Ogrnci_Adi.Tag);
            Ogrenciler ogr1 = okul_ctx2.Ogrencilers.Find(OgrenciID);
            okul_ctx2.Ogrencilers.Remove(ogr1);
            okul_ctx2.SaveChanges();
            dataGridView2.DataSource = okul_ctx2.Ogrencilers.ToList();
        }

        
    }
}
