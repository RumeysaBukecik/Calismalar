using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1801aracsoru
{
    interface Arac
    {
        string AracAdi { get; set; }
    }

    interface Teker4
    {
       string AracTipi { get; set; }
       
    }

    class Audi : Arac, Teker4
    {
        private string TAracAdi;
        public string AracAdi
        {
            get {return TAracAdi;}
            set {TAracAdi = value; }
        }

        private string TAracTipi;
        public string AracTipi
        {
            get{ return TAracTipi; }
            set{ TAracTipi = value; }
        }

        public void TipYazdir()
        {
            Console.WriteLine($"Araç adı: {AracAdi} \nAraç Tipi: {AracTipi}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Audi audim = new Audi();
            audim.AracAdi = "Nissan Kaşgayi";
            audim.AracTipi = "Tipsiz";

            audim.TipYazdir();

            Console.Read();
        }
    }
}
