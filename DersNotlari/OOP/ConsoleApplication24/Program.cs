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
            OOP3 obje1 = new OOP3();
            obje1.Merhaba();

            //statik konusu
            ArrayList aList = new ArrayList();

            StatikKonusu s1 = new StatikKonusu();
            s1.Ad = "SmartPro Akademi";
            s1.Unvan = "Bilişim Kursu";
            aList.Add(s1.Ad);
            aList.Add(s1.Unvan);
            StatikKonusu.NesneSayisi++;

            StatikKonusu s2 = new StatikKonusu();
            s2.Ad = "Rümeysa Bükecik";
            s2.Unvan = "BÖTEci";
            aList.Add(s2.Ad);
            aList.Add(s2.Unvan);

            StatikKonusu.TumunuListele(aList);
            Console.WriteLine(StatikKonusu.NesneSayisi);
            Console.ReadKey();
        }
    }
}
