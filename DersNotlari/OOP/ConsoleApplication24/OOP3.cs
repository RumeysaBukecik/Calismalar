using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class OOP3
        //YIKICI METOTLAR
    {  //Nesne sonlandırılırken çalışan metot
        ~OOP3()
        {
            Console.WriteLine("Nesne çöpe gidiyor");
            Console.ReadKey();
        }

        public void Merhaba()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
