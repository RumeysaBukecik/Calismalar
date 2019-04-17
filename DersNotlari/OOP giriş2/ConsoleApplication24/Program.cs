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
            ArrayList aList = new ArrayList();
            Araba arb = new Araba();
            arb.AracEkle(aList);
            Araba.AracListele(aList);
            Console.ReadKey();
        }
    }
}
