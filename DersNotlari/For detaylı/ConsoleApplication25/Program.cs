using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    enum KurumTipi : byte { Devlet, Özel, Vakıf }
    enum OzelKursAlanı : byte { Yazılım, Muhasebe, YabancıDil, Ehliyet, Yüzme }

    class EgitimKurumu
    {
        public string KurumAdi;
        public string KurumAdresi;
        public KurumTipi KurumTipik;

        public EgitimKurumu(string kurumadi, string kurumadresi, KurumTipi kurumtipik)
        {
            KurumAdi=kurumadi;
            KurumAdresi=kurumadresi;
            KurumTipi KurumTipik = kurumtipik;
        }
    }

    class OzelKurs : EgitimKurumu
    {
        public string OzelKursSahibi;
        public OzelKursAlanı OzelKursAlanik;
        public ArrayList EgitmenListesi= new ArrayList();

        public OzelKurs(string ozelkurssahibi, OzelKursAlanı ozelkursalanik, string kurumadi, string kurumadresi, KurumTipi kurumtipik) : base(kurumadi, kurumadresi, kurumtipik)
        {
            this.OzelKursSahibi = ozelkurssahibi;
            this.OzelKursAlanik = ozelkursalanik;

            EgitmenEkle();
        }

        public void EgitmenEkle()
        {
            Console.Write("Eğitmen sayısı giriniz: ");
            int esayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < esayisi; i++)
            {
                Console.Write("TC giriniz: ");
                int tc = Convert.ToInt32(Console.ReadLine());
                EgitmenListesi.Add(tc);

                Console.Write("Adınızı ve soyadınızı giriniz: ");
                string adsoy = Console.ReadLine();
                EgitmenListesi.Add(adsoy);
            }

            EgitmenListele();
        }

        public void EgitmenListele()
        {
            for (int i = 0; i < EgitmenListesi.Count; i+=2)
            {
                Console.WriteLine("Tc : "+EgitmenListesi[i] +" Ad Soyad: "+EgitmenListesi[i+1]);
            }
        }

        public string EgitmenBul(int tc)
        {
            Console.WriteLine();
            int isimsiz = EgitmenListesi.IndexOf(tc); //Tcyi bulduğu yeri gösteriyor  
            return ($"Tc: " + EgitmenListesi[isimsiz] + " Adsoy:" +EgitmenListesi[isimsiz+1]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OzelKurs SmartPro = new OzelKurs("Rümeysa Bükecik", OzelKursAlanı.Yazılım, "SmartPro", "Kadıköy", KurumTipi.Özel);
            Console.WriteLine(SmartPro.EgitmenBul(404));
            Console.Read();
        }
    }
}
