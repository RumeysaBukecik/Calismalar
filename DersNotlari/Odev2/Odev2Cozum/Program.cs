using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Girisim
{
    enum OgretimDuzeyleri : byte { IlkOgretim, OrtaOgretim, Lise, Lisans }
    class Ogrenci
    {
        protected string AdSoy;
        protected string OkulNum;
        protected string OkulAdi = "Açıktan Eğitim";
        protected OgretimDuzeyleri OgretimDuzeyi;

        ArrayList OgrenciList = new ArrayList();

        public Ogrenci(string adsoy, string okulnum, string okuladi, OgretimDuzeyleri ogretimduzeyi)
        {
            this.AdSoy = adsoy;
            this.OkulNum = okulnum;
            this.OkulAdi = okuladi;
            this.OgretimDuzeyi = ogretimduzeyi;

            OgrenciList.Add(this.AdSoy);
            OgrenciList.Add(this.OkulNum);
            OgrenciList.Add(this.OkulAdi);
            OgrenciList.Add(this.OgretimDuzeyi);
        }

        virtual public void NotHesapla()
        {
            Console.WriteLine("Not bilgisi eksik...!");
        }
    }

    class LiseOgrenci : Ogrenci
    {
        private new string OkulAdi;
        private int Not1;
        private int Not2;

        public LiseOgrenci(int not1, int not2, string adsoy, string okulnum, string okuladi, OgretimDuzeyleri ogretimduzeyi) : base(adsoy, okulnum, okuladi, ogretimduzeyi)
        {
            this.OkulAdi = okuladi;
            this.Not1 = not1;
            this.Not2 = not2;
            
        }

        override public void NotHesapla()
        {
            Console.WriteLine("Not1: " + Not1);
            Console.WriteLine("Not2: " + Not2);
            
            int sonuc = ((this.Not1 + this.Not2) / 2);
            Console.WriteLine("Ortalama: " + sonuc);

            if (sonuc >= 0 && sonuc <= 49.99)
            {
                Console.WriteLine("Sonuç: Tekrar");
            }
            else if (sonuc >= 50 && sonuc <= 59.99)
            {
                Console.WriteLine("Sonuç: Geçer");
            }
            else if (sonuc >= 60 && sonuc <= 69.99)
            {
                Console.WriteLine("Sonuç: Orta");
            }
            else if (sonuc >= 70 && sonuc <= 84.99)
            {
                Console.WriteLine("Sonuç: İyi");
            }
            else if (sonuc >= 85 && sonuc <= 100)
            {
                Console.WriteLine("Sonuç: Pekiyi");
            }
            else
            {
                Console.WriteLine("Geçersiz not girdiniz.");
            }
        }

        public void Yazdir()
        {
            Console.WriteLine("Ad Soyad: " + AdSoy);
            Console.WriteLine("Okul Numarası: " + OkulNum);
            Console.WriteLine("Okul Adı: " + OkulAdi);
            Console.WriteLine("Öğretim Düzeyi: " + OgretimDuzeyi);
        }
    }

    class LisansOgrenci : Ogrenci
    {
        public string FakulteAdi;
        public int VizeNotu;
        public int FinalNotu;

        public LisansOgrenci(string fakulteadi, int vizenotu, int finalnotu, string adsoy, string okulnum, string okuladi, OgretimDuzeyleri ogretimduzeyi) : base(adsoy, okulnum, okuladi, ogretimduzeyi)
        {
            FakulteAdi = fakulteadi;
            VizeNotu = vizenotu;
            FinalNotu = finalnotu;
        }

        override public void NotHesapla()
        {
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("Vize Notu: " + VizeNotu);
            Console.WriteLine("Final Notu: " + FinalNotu);

            int Vize = (this.VizeNotu - ((this.VizeNotu * 40) / 100));
            int Final = (this.VizeNotu - ((this.VizeNotu * 60) / 100));
            int sonuc = (Vize + Final);

            if (sonuc > 0 && sonuc <= 44.99)
            {
                Console.WriteLine("Sonuç: F");
            }
            else if (sonuc > 45 && sonuc <= 49.99)
            {
                Console.WriteLine("Sonuç: E");
            }
            else if (sonuc > 50 && sonuc <= 59.99)
            {
                Console.WriteLine("Sonuç: D");
            }
            else if (sonuc > 60 && sonuc <= 69.99)
            {
                Console.WriteLine("Sonuç: C");
            }
            else if (sonuc > 70 && sonuc <= 84.99)
            {
                Console.WriteLine("Sonuç: B");
            }
            else if (sonuc > 85 && sonuc <= 100)
            {
                Console.WriteLine("Sonuç: A");
            }
            else
            {
                Console.WriteLine("Geçersiz not girdiniz.");
            }
        }
        public void Yazdirr()
        {
            Console.WriteLine("Fakülte Adı: " + FakulteAdi);
            Console.WriteLine("Ad Soyad: " + AdSoy);
            Console.WriteLine("Okul Numarası: " + OkulNum);
            Console.WriteLine("Okul Adı: " + OkulAdi);
            Console.WriteLine("Öğretim Düzeyi: " + OgretimDuzeyi);

        }

    }
    class Program
    {
        static void GenelNotHesapla(Ogrenci ogr)
        {
            ogr.NotHesapla();
        }

        static void Main(string[] args)
        {
            LiseOgrenci lso = new LiseOgrenci(50, 30, "Rümeysa", "120", "Ticaret", OgretimDuzeyleri.Lise);
            GenelNotHesapla(lso);
            lso.Yazdir();

            LisansOgrenci lsogr = new LisansOgrenci("Egitim Fakültesi", 100, 100, "Ömer", "717", "Sakarya Üniversitesi", OgretimDuzeyleri.Lisans);
            GenelNotHesapla(lsogr);
            lsogr.Yazdirr();

            Console.Read();
        }
    }
}

