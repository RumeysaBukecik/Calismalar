using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Soru15._01
{
    class Ogretmen
    {
        public string OgretmenAdi;
        public int OgretmenYasi;

        public Siniif Siniff = new Siniif();

        public void BilgiYazdir()
        {
            Console.WriteLine("Öğretmen Adı:     "+OgretmenAdi);
            Console.WriteLine("Öğretmen Yaşı:    " + OgretmenYasi);
            Console.WriteLine("Sınıf Adı:        "+Siniff.SinifAdi);
            Console.WriteLine("Derslik Numarası: "+Siniff.DerslikNumarasi);
            Console.WriteLine("Sınıf Programı:   "+Siniff.SinifProgrami);
        }
    }

    class Siniif
    {
        public int SinifAdi;
        public int DerslikNumarasi;
        public string SinifProgrami;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogt = new Ogretmen();

            ogt.OgretmenAdi = "Mehmet Demir";
            ogt.OgretmenYasi = 30;
            ogt.Siniff.SinifAdi = 723726;
            ogt.Siniff.DerslikNumarasi = 404;
            ogt.Siniff.SinifProgrami = "Web ve Mobil Programlama";

            ogt.BilgiYazdir();

            Console.Read();
        }
    }
}
