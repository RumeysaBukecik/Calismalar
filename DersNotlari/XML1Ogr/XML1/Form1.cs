using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace XML1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDosyasi;
        XmlNode OkulNode;
        XmlNodeList ogrenciNodeList;

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            xmlDosyasi = new XmlDocument();
            xmlDosyasi.Load(@"..\..\Okul.xml");
            OkulNode = xmlDosyasi.SelectSingleNode("okul");
            ogrenciNodeList = OkulNode.SelectNodes("ogrenci");
            string secilenOgrenci = textBox1.Text;
            foreach (XmlNode ogrenci in ogrenciNodeList)
            {
                if (secilenOgrenci == ogrenci.SelectSingleNode("Numara").InnerText)
                {
                    listBox1.Items.Add(ogrenci.SelectSingleNode("Numara").InnerText);
                    listBox1.Items.Add(ogrenci.SelectSingleNode("AdSoy").InnerText);
                    listBox1.Items.Add(ogrenci.SelectSingleNode("Sinif").InnerText);
                    listBox1.Items.Add(ogrenci.SelectSingleNode("DogumTarihi").InnerText);
                }
                
            }

        }

        private void button_Kaydett_Click(object sender, EventArgs e)
        {
            Kaydet ekran2 = new Kaydet();
            ekran2.Show();
        }
    }
}
