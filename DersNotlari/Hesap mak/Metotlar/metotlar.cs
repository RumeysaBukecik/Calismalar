using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        //static void merhabaYaz()  //metot oluşturuldu //programın başından sonuna kadar tutuyordu çalıştırıyordu; static. 
        //{
        //    Console.WriteLine("Merhaba");
        //}
        //static int carpma(int a, int b) //parametreli metot
        //{
        //    return a * b; //a*b çarpım değerini döndür
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hey");
        //    merhabaYaz(); //metot çağırıldı
        //    Console.WriteLine("Dünya");

        //    int sonuc = carpma(7, 7);
        //    Console.WriteLine(sonuc);
        //    Console.ReadKey();
        //}



        //static void merhaba(string isim)
        //{
        //    Console.WriteLine("Merhaba" + isim);
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Adınızı yazınız:");
        //    string ad = Console.ReadLine();
        //    merhaba(ad);   
        //    Console.ReadKey();
        //}



        //klavyeden girilen x değerini alan ve aşağıdaki işlemin sonucunu döndüren metodu yazınız.
        // (x+2)*(x+2)-12


        //    static int carpim(int x)
        //{
        //    return (x + 2) * (x + 2) - 12;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("X değerini giriniz:");
        //    int xsayi = Convert.ToInt32(Console.ReadLine());

        //    int sonuc = carpim(xsayi);
        //    Console.WriteLine("Sonuç:" +sonuc);

        //    Console.ReadKey();
        //}





//klavyeden iki sayı isteyecez. sonra bir de karakter isteyecez. karaktere göre işlem yapacaz. 
        static int islem(int x, int y, char c)    //int diyerek dönüş tipi belirtmiş oluyoruz ve return eklememiz gerekiyor.
        {
            if(c=='ç')
            {
                return x * y;
            }

            if (c=='b')
            {
                return x / y;
            }
            if (c == 't')
            {
                return x + y;
            }
            if (c == 'c')
            {
                return x - y;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("X değerini giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y değerini giriniz:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çarpma işlemi için ç, Bölme işlemi için b, toplam işlemi için t, çıkarma işlemi için r tuşuna basınız.");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(islem (x,y,c));
            Console.ReadKey();
        }
    }
}
