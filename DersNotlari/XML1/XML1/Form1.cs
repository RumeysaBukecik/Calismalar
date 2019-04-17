using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
          XmlNode okulNode;
          XmlNodeList ogrenciNodeList;
          private void Form1_Load(object sender, EventArgs e)
          {
               xmlDosyasi = new XmlDocument();
               //xmlDosyasi.Load(@"C:\Users\mehmet.demir\Documents\
               //Visual Studio 2015\Projects\XML1\XML1\yemekler.xml");
               xmlDosyasi.Load(@"..\..\yemekler.xml");
               okulNode = xmlDosyasi.SelectSingleNode("yemeklistesi");

                ogrenciNodeList = okulNode.SelectNodes("menu");
               foreach (XmlNode menu in ogrenciNodeList)
               {
                    listBox_Menu_Adlari.Items.Add(menu.Attributes["adi"].Value);
               }
          }

          private void listBox_Menu_Adlari_SelectedIndexChanged(object sender, EventArgs e)
          {
               listBox_Menu_Detaylari.Items.Clear();

               string secilenMenu = listBox_Menu_Adlari.SelectedItem.ToString();

               foreach (XmlNode menu in menuNodeList)
               {
                    if (secilenMenu==menu.Attributes["adi"].Value)
                    {
                         listBox_Menu_Detaylari.Items.Add(menu.SelectSingleNode("corba").InnerText);
                         listBox_Menu_Detaylari.Items.Add(menu.SelectSingleNode("anayemek").InnerText);
                         listBox_Menu_Detaylari.Items.Add(menu.SelectSingleNode("tatlı").InnerText);
                    }
               }

          }
     }
}
