using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._01
{

    class KısıselBilgi
    {
        public string Ad;
        public string Soyad;

        public YasBilgi _YasBilgisi=new YasBilgi();
        //Yukarıdaki nesne tanımlama sayesinde yas bilgisi sınıfının üyelerine bu sınıf nesnesi aracılığı ile değer atayabiliriz.
        //Metotlarını kullanabiliriz.
        public void Yazdir()
        {
            Console.WriteLine(Ad+" "+Soyad);
            Console.WriteLine(_YasBilgisi.Yas);
        }
    }

    class YasBilgi
    {
        public int Yas;

        public void YasYazdir()
        {
            Console.WriteLine(Yas);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KısıselBilgi kb1 = new KısıselBilgi();
            kb1.Ad = "SmartPto";
            kb1.Soyad = "Kadıköy";
            kb1._YasBilgisi.Yas = 55;

            kb1.Yazdir();  //sınıf içinden sınıfa ulaştık

            Console.Read();
        }
    }
}
