using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console27Bitkisorusu1601
{
    enum Renkler : byte { Sarı, Kırmızı, Pembe, Turuncu, Karışık, Mor, Mavi, Yeşil, Beyaz }
    class Bitki
    {
        public string Bitkiadi;
        public bool Endemik;

        public Bitki(string bitkiadi, bool endemik)
        {
            Bitkiadi = bitkiadi;
            Endemik = endemik;
        }
    }

    class Cicek:Bitki
    {
        public Renkler Renk;
        public int Fiyat;
        public ArrayList Saticilar = new ArrayList();

        public Cicek(Renkler renk, int fiyat, string bitkiadi, bool endemik) : base(bitkiadi, endemik)
        {
            this.Renk = renk;
            this.Fiyat = fiyat;
        }

        public void SaticiEkle()
        {
            Console.WriteLine("Kaç tane satıcı var? ");  
            Console.Write("Cevap: " );
            int ksatici = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ksatici; i++)
            {
                Console.Write("Dükkan adı giriniz: ");
                string dadi = Console.ReadLine();
                Saticilar.Add(dadi);

                Console.Write("Dükkan adresi giriniz: ");
                string dadres = Console.ReadLine();
                Saticilar.Add(dadres);

                Console.WriteLine();
            }
            CicekBilgiListele();
        }
        
        public void SaticiListele()
        {
            for (int i = 0; i < Saticilar.Count; i+=2)
            {
                Console.WriteLine("Dükkan Adı: " +Saticilar[i]+ "\nDükkan Adresi: " +Saticilar[i+1] );
            }
            
        }

        public void CicekBilgiListele()
        {
            Console.WriteLine($"Renk: {Renk}");
            Console.WriteLine($"Fiyat: {Fiyat}");
            Console.WriteLine($"Bitki Adı: {Bitkiadi}");
            Console.WriteLine($"Endemik: { Endemik}");

            SaticiListele();
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Cicek cicekbilgi = new Cicek(Renkler.Kırmızı, 50, "Suni Çiçek", true);
            cicekbilgi.SaticiEkle();
            Console.Read();
        }
    }
}
