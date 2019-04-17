using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    //enum:sabit farklı ifadelerin sayısal tiplerde liste gibi tutulmasında işe yarar

    enum Gunler :byte{Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar }


    class OOPdevam
    {

        public const string Metin = "Ahmet";  //değişmeyen özellik tanımlamış oluyoruz
        //public readonly int Sayi = 55;
        //public readonly int Sayi2; //kendisine bir değişken atandıktan sonra değiştirilmez sadece yapıcı metotda değiştirilir.

        //public void Ata() { Sayi = 99; Sayi2=90 } //bunu anlatmadı

        public OOPdevam()
        {
            Console.WriteLine("Normal Yapıcı Çalıştı.");
            //Sayi = 99;
            //Sayi2 = 90;//anlatmadı
        }

        static OOPdevam()  //sadece 1 defa çalışır. sınıfla ilgili temel değerleri atamada kullanılır. ilk değer vs
        {
            Console.WriteLine("Static yapıcı çalıştı.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            OOPdevam o1 = new OOPdevam();
            OOPdevam o2 = new OOPdevam();
            OOPdevam o3 = new OOPdevam();
        string bugun = Gunler.Pazartesi.ToString();

            string[] sDizi = Enum.GetNames(typeof(Gunler));

            byte bugun1 = (byte)Gunler.Cuma;  //index numrasını veriyor
            Console.WriteLine(bugun1);

            bool varMi = Enum.IsDefined (typeof(Gunler), "PAZAR"); //var mı diye bakıyor
        Console.WriteLine(varMi);

            Console.ReadKey();
        }
    }
}
