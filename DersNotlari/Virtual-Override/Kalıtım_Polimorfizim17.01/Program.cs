using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Polimorfizim17._01
{
    class Hayvan
    {
        virtual public void SesCikar()
        {
            Console.WriteLine("Hayvan sesleri çeşitlidir.");
        }
    }

    class Kedi : Hayvan //bu şu demek hayvan sınıfından türetiliyor ve hayvan sınıfındaki metot ve özellikleri alıyor.
    {
        override public void SesCikar() //new koyduğumuzda metot isminin altındali uyarı kalkar. tek işlevi budur. Derleyici program bizim aynı ismi bilerek koyduğumuzu bilmiş olur
        {//override koyduğumuzda bu metodu yazdır diyoruz
            Console.WriteLine("Miyav Miyav");
        }
    }

    class Tavuk : Hayvan
    {
        override public void SesCikar()  //Üst sınıftan bir metodu gizler aynı isimde olduğunda
        {//override yazdığımızda bunu da yaz diyoruz nırmalde hayvan sesleri çeşitlidir yazıyordu.
            Console.WriteLine("Gıt gıt Gıdaaakk");
        }
    }


    class Program
    {
        public static void SesCikar(Hayvan hyvn) //1 tane "hayvan" listesi istesin
        {
            hyvn.SesCikar();
        }

        static void Main(string[] args)
        {
            Hayvan hayvan1 = new Hayvan();
            Kedi kedi1 = new Kedi();
            Tavuk tavuk1 = new Tavuk();

            //hayvan1.SesCikar();
            //kedi1.SesCikar();
            //tavuk1.SesCikar();


            SesCikar(hayvan1);
            SesCikar(kedi1);
            SesCikar(tavuk1);

            Console.Read();
        }
    }
}
