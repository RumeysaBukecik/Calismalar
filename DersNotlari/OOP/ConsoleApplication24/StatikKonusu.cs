using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class StatikKonusu
    {
        public string Ad;
        public string Unvan;
        public static int NesneSayisi;  //statik sadece sınıfta kullanıyor nesnede kullanılmıyor

        public static void TumunuListele(ArrayList aList)
        {
            for (int i = 0; i < aList.Count; i=i+2)
            {
                Console.WriteLine("Ad: " +aList[i]);
                Console.WriteLine("Unvan: " + aList[i+1]);

            }
        }
    }
}
