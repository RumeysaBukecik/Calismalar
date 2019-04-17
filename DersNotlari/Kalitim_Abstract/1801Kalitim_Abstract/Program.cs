using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1801Kalitim_Abstract
{
    abstract class Birey
    {
        abstract public string Ad { get; set; }   //abstract zaten virtualı kapsıyor.Ön tanımlama gibi düşün
        abstract public void AdYaz();
        public int Yas;
    }

    class Calisan : Birey
    {
        private string AD;
        public override string Ad
        {
            get
            {
                return AD;
            }

            set
            {
                AD = value;
            }
        }

        public override void AdYaz()
        {
            Console.WriteLine("Birey adı: " +AD);
            Console.WriteLine("Birey yaşı: " +Yas);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calisan cls1 = new Calisan();
            cls1.Ad = "Mehmet";
            cls1.Yas = 70;
            cls1.AdYaz();/*Bu satırı aşağıdaki şekilde de yapabiliriz*/

            /*ayrıca şu şekilde de yapabiliriz:
             Birey br=cls1;
             br.AdYaz();*/
            Console.Read();
        }
    }
}
