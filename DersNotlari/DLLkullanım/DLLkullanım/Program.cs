using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rastgele;

namespace DLLkullanım
{
    class Program
    {
        static void Main(string[] args)
        {
            Rastgele.Sayi r1 = new Rastgele.Sayi();
            Console.WriteLine(r1.Rsayi);
            r1.Degistir();
            Console.WriteLine(r1.Rsayi);

            Console.ReadKey();

        }
    }
}
