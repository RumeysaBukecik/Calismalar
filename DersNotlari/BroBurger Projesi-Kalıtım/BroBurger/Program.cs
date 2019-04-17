using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroBurger
{
    interface ISahipBilgiler
    {
        string Sahibi { get; set; }
        int VergiNumarasi { get; set; }

        void SahipKaydet();

        void DukkanKaydet();
    }

    interface IDukkanBilgiler
    {
        string Adi { get; set; }
        int ID { get; set; }
        string Ulke { get; set; }
        string Sehir { get; set; }
        string İlce { get; set; }
    }

    class BroBurger : ISahipBilgiler, IDukkanBilgiler
    {
        private string BSahibi;
        public string Sahibi
        {
            get{ return BSahibi; }
            set{ BSahibi = value; }
        }

        private int BVergiNumarasi;
        public int VergiNumarasi
        {
            get{ return BVergiNumarasi; }
            set{ BVergiNumarasi = value; }
        }

        private string BAdi;
        public string Adi
        {
            get{ return BAdi; }
            set{ BAdi = value; }
        }

        private int BID;
        public int ID
        {
            get{ return BID; }
            set{ BID = value; }
        }

        private string BUlke;
        public string Ulke
        {
            get{ return BUlke; }
            set{ BUlke = value; }
        }

        private string BSehir;
        public string Sehir
        {
            get{ return BSehir; }
            set{ BSehir = value; }
        }

        private string Bİlce;
        public string İlce
        {
            get{ return Bİlce; }
            set{ Bİlce = value; }
        }

        public void SahipKaydet()
        {
            string dosyaAdresi = "C:\\Rum\\File2.txt";
            FileStream fs = new FileStream(dosyaAdresi, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write($"Sahibi: {Sahibi} \t Vergi Numarası: {VergiNumarasi} \t");

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void DukkanKaydet()
        {
            string dosyaAdresi = "C:\\Rum\\File2.txt";
            FileStream fs = new FileStream(dosyaAdresi, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine($"Adı: {Adi} \t ID: {ID} \t Ülke: {Ulke} \t Şehir: {Sehir} \t İlçe: {İlce}");

            sw.Flush();
            sw.Close();
            fs.Close();
        } 
        
        public void BilgiYaz()
        {
            string dosyaAdresi = "C:\\Rum\\File2.txt";
            FileStream fs = new FileStream(dosyaAdresi, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs, Encoding.Default);

            string satir;
            
            while ((satir = sw.ReadLine()) != null) 
            {
                Console.WriteLine(satir);
              
            }

            sw.Close();
            fs.Close();

            Console.WriteLine("Sahibi: " +Sahibi);
            Console.WriteLine("Vergi Numarası: " + VergiNumarasi);
            Console.WriteLine("Adı : " + Adi);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Ülke: " + Ulke);
            Console.WriteLine("Şehir: " + Sehir);
            Console.WriteLine("İlçe: " + İlce);     
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            BroBurger BBurger = new BroBurger();
            BBurger.Sahibi = "Rümeysa Bükecik";
            BBurger.VergiNumarasi = 19441;
            BBurger.Adi = "Burger*";
            BBurger.ID = 159753;
            BBurger.Ulke = "İsveç";
            BBurger.Sehir = "Stockholm";
            BBurger.İlce = "Vasastan";

            BBurger.BilgiYaz();
            BBurger.SahipKaydet();
            BBurger.DukkanKaydet();

            Console.Read();
        }
    }
}
