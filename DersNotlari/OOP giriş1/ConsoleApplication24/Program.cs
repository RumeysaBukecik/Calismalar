using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Ogrenci ogrnci = new Ogrenci();
            ArrayList aList = new ArrayList();
            ogrnci.KayitEkle(aList);
            Console.WriteLine(Ogrenci.OkulOrtalamaHesapla(aList));
            Console.ReadKey();
        }
    }
}
