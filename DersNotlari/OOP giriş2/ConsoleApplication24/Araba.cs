using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Araba
    {
        public int Fiyat;
        public int MotorHacmi;
        public string Plaka;
        public double OTV;

        public double OTVhesap(int Fiyat,int MotorHacmi)
        {
            if (MotorHacmi<1600 && Fiyat<70000)
            {
                
                OTV = Fiyat * 0.3;
            }

            else if (MotorHacmi<1600 && Fiyat<120000)
            {
                OTV = Fiyat * 0.35;

            }

            else if (MotorHacmi<1600 && Fiyat<169999)
            {
                OTV = Fiyat * 0.60;
            }

            else if (MotorHacmi<2000 && Fiyat<170000)
            {
                OTV = Fiyat * 1.00;
            }

            else if(MotorHacmi<2000 && Fiyat>170000)
            {
                OTV = Fiyat * 1.10;
            }

            else
            {
                OTV = Fiyat * 1.60;
            }

            return OTV;
        }

        public void AracEkle(ArrayList aList)
        {
            Console.WriteLine("Fiyat Giriniz:");
            Fiyat = Convert.ToInt32(Console.ReadLine());
            aList.Add(Fiyat);

            Console.WriteLine("Motor Hacmi Giriniz:");
            MotorHacmi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plaka Giriniz:");
            Plaka =Console.ReadLine();
            aList.Add(Plaka);

            OTV = OTVhesap(Fiyat, MotorHacmi);  //otvhesabı fiyat ve motorhacmi parametreleri ile çağırdık
            aList.Add(OTV);

        }

        static public void AracListele(ArrayList aList) //static tanıttığımızda sınıf ismiyle tanımlayabiliyoruz.
        {
            
            for (int i = 0; i < aList.Count; i = i + 3)
            {
                Console.WriteLine("Fiyat: "+aList[i + 0]);
                Console.WriteLine("Plaka: "+aList[i + 1]);
                Console.WriteLine("ÖTV: "+aList[i + 2]);
            }
        }

    }
}
