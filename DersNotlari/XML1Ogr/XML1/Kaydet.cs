using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML1
{
    public partial class Kaydet : Form
    {
        XmlDocument xmlDosyasi;
        XmlElement okul;

        private void Kaydet_Load(object sender, EventArgs e)
        {
            xmlDosyasi = new XmlDocument();
            if (!File.Exists(@"..\..\Okul.xml"))
            {
                okul = xmlDosyasi.CreateElement("okul");
                xmlDosyasi.AppendChild(okul);
            }
            else
            {
                xmlDosyasi.Load(@"..\..\Okul.xml");
                okul = (XmlElement)xmlDosyasi.SelectSingleNode("okul");
            }
        }

        public Kaydet()
        {
            InitializeComponent();
        }

        private void button_OgrKyt_Click(object sender, EventArgs e)
        {
            
            XmlElement ogrenci = xmlDosyasi.CreateElement("ogrenci");
            okul.AppendChild(ogrenci);


            XmlElement ogrenciNum = xmlDosyasi.CreateElement("Numara");
            ogrenciNum.InnerText = textBox_Num.Text;
            ogrenci.AppendChild(ogrenciNum);

            XmlElement ogrenciAdSoy = xmlDosyasi.CreateElement("AdSoy");
            ogrenciAdSoy.InnerText = textBox_Adsoy.Text;
            ogrenci.AppendChild(ogrenciAdSoy);

            XmlElement ogrenciSinif = xmlDosyasi.CreateElement("Sinif");
            ogrenciSinif.InnerText = textBox_Sinif.Text;
            ogrenci.AppendChild(ogrenciSinif);

            XmlElement DogumTarihi = xmlDosyasi.CreateElement("DogumTarihi");
            DogumTarihi.InnerText = dateTimePicker1.Text;
            ogrenci.AppendChild(DogumTarihi);

            xmlDosyasi.Save(@"..\..\Okul.xml");
            MessageBox.Show("Kayıt Başarılı");

        }


    }
}
