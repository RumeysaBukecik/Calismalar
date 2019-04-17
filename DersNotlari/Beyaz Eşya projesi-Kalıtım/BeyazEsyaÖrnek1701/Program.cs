using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyazEsyaOrnek1701
{
    enum EnerjiSiniflari : byte {A,B,C,D,E }
    enum FirinTipleri : byte { MiniFirin, NormalFirin }
    class BeyazEsya
    {
        public string Marka;
        public int Fiyat;
        public int GarantiSuresi;
        public EnerjiSiniflari EnerjiSinifi;

        public BeyazEsya(string marka, int fiyat, int garantisuresi, EnerjiSiniflari enerjisinifi)
        {
            Marka = marka;
            Fiyat = fiyat;
            GarantiSuresi = garantisuresi;
            EnerjiSinifi = enerjisinifi;
        }

        virtual public void IndirimliFiyatiHesapla()
        {
            Console.WriteLine("İndirim Yok...!", "Fiyat Bilgisi: "  +Fiyat);
        }
    }

    class BulasikMakinesi:BeyazEsya
    {
        public int ProgramSayisi;
        public string Modeli;
        public int IndirimOrani;

        public BulasikMakinesi(int programsayisi, string modeli, int indirimorani, string marka, int fiyat, int garantisuresi, EnerjiSiniflari enerjisinifi) : base(marka, fiyat, garantisuresi, enerjisinifi)
        {
            this.ProgramSayisi = programsayisi;
            this.Modeli = modeli;
            this.IndirimOrani = indirimorani;
        }
        
        override public void IndirimliFiyatiHesapla()
        {
            int IndirimliFiyat = (this.Fiyat / 100) * (100 - this.IndirimOrani);
            Console.WriteLine("İndirimli Fiyatı: " +IndirimliFiyat);
        }

        public void BilgiListele()
        {
            Console.WriteLine($"Program Sayısı: {ProgramSayisi}");
            Console.WriteLine($"Modeli: {Modeli}");
            Console.WriteLine($"İndirim Oranı: {IndirimOrani}");
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Fiyat: {Fiyat}");
            Console.WriteLine($"Garanti Süresi: {GarantiSuresi}");
            Console.WriteLine($"Enerji Sınıfı: {EnerjiSinifi}");

        }
    }

    class Firin : BeyazEsya
    {
        public FirinTipleri FirinTipi;
        public int IndirimOrani;

        public Firin(FirinTipleri firintipi, int indirimorani, string marka, int fiyat, int garantisuresi, EnerjiSiniflari enerjisinifi) : base(marka, fiyat, garantisuresi, enerjisinifi)
        {
            FirinTipleri FirinTipi = firintipi;
            IndirimOrani = indirimorani;
        }

        override public void IndirimliFiyatiHesapla()
        {
            int IndirimliFiyat = (this.Fiyat / 100) * (100 - this.IndirimOrani);
            Console.WriteLine("İndirimli Fiyatı: " + IndirimliFiyat);
        }
    }

    class MiniFirin : Firin
    {
        public MiniFirin(FirinTipleri firintipi, int indirimorani, string marka, int fiyat, int garantisuresi, EnerjiSiniflari enerjisinifi) : base(firintipi, indirimorani, marka, fiyat, garantisuresi, enerjisinifi)
        {
            this.IndirimOrani = indirimorani;
        }

        override public void IndirimliFiyatiHesapla()
        {
            int IndirimliFiyat = (this.Fiyat / 100) * (100 - this.IndirimOrani);
            Console.WriteLine("**********************");
            Console.WriteLine("İndirimli Fiyatı: " + IndirimliFiyat);
        }

        public void BilgiListele()
        {
            Console.WriteLine($"Fırın Tipi: {FirinTipi}");
            Console.WriteLine($"İndirim Oranı: {IndirimOrani}");
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Fiyat: {Fiyat}");
            Console.WriteLine($"Garanti Süresi: {GarantiSuresi}");
            Console.WriteLine($"Enerji Sınıfı: {EnerjiSinifi}");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            
            BulasikMakinesi bm1 = new BulasikMakinesi(5, "Tigernu944", 25, "Tigernu", 1000, 3, EnerjiSiniflari.A );
            bm1.IndirimliFiyatiHesapla();
            bm1.BilgiListele();

            MiniFirin mf1 = new MiniFirin(FirinTipleri.NormalFirin, 15, "Tigerrum", 1800, 2, EnerjiSiniflari.B ); 
            mf1.IndirimliFiyatiHesapla();
            mf1.BilgiListele();

            Console.Read();
        }
    }
}
