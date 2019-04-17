using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    enum Aylar : byte { Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık }
    class Program
    { //foto aylarr
        static void Main(string[] args)
        {

            Aylar ays = new Aylar();
            ays = Aylar.Haziran;  //atama yapıyor

            byte sira = (byte)Enum.Parse(typeof(Aylar), "Ocak");
            Console.WriteLine(sira);  //index veriyor

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Bir ay giriniz:");
                string ay = Console.ReadLine();

                bool varMi = Enum.IsDefined(typeof(Aylar), ay); 
                Console.WriteLine(varMi);
            }

            Console.ReadKey();
        }
    }
}
