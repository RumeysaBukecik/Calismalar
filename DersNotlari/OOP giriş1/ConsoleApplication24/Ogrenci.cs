using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Ogrenci
    {
        private string OgrenciAdi;
        private int OgrenciNumarasi;
        private int Not1;
        private int Not2;
        public static int ToplamOgrenciSayisi=2;

        public void KayitEkle(ArrayList aList)
        {
            for (int i = 0; i < ToplamOgrenciSayisi; i++)
            {
                Console.WriteLine("Öğrenci Adınızı Giriniz:");
                OgrenciAdi = Console.ReadLine();
                aList.Add(OgrenciAdi);

                Console.WriteLine("Öğrenci Numarasi Giriniz:");
                OgrenciNumarasi = Convert.ToInt32(Console.ReadLine());
                aList.Add(OgrenciNumarasi);

                Console.WriteLine("Öğrencinin Not1 Giriniz:");
                Not1 = Convert.ToInt32(Console.ReadLine());
                aList.Add(Not1);

                Console.WriteLine("Öğrencinin not2 Giriniz:");
                Not2 = Convert.ToInt32(Console.ReadLine());
                aList.Add(Not2);

            }

        }

        public static double OkulOrtalamaHesapla(ArrayList aList)
        {
            double toplam = 0;
            for (int i = 0; i < aList.Count; i=i+4)
            {
                toplam += (int)aList[i + 2] + (int)aList[i + 3];
                
            }
            
            
            return toplam/(ToplamOgrenciSayisi*2);
            
        }
    }
}
