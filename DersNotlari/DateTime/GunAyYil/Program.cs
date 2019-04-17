using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAyYil
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarihsaat = new DateTime();
            tarihsaat = DateTime.Now;

            Console.WriteLine("Gün : " + tarihsaat.Day);
            Console.WriteLine("Ay : " + tarihsaat.Month);
            Console.WriteLine("Yıl : " + tarihsaat.Year);

            Console.Read();
        }
    }
}
