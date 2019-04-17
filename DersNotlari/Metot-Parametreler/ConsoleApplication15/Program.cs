using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {

        //static bool asal(int sayi)
        //{
        //    for (int i =2; i < sayi; i++)
        //    {
        //        if (sayi%i==0)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;

        //}
        //static void Main(string[] args)
        //{

        //        Console.WriteLine("Sayı giriniz.");
        //        int sayi = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine(asal(sayi));                 


        //    Console.ReadKey();
        //}




        //10 tane sayı isteyecez klavyeden ondalıklı. diziye atayacaz. bu sayıların aritmetik ortalamasını alacaz başka bir metot oluşturarak.

        //static double arit (double[] sayi)
        //{
        //    double toplam = 0;
        //    foreach (var item in sayi)     //sayiyı diziye atamıştık. bu satırın anlamı şu;sayinın içindeki sayıları item kendine çeker. ve aşağıdaki işlemi yapar. toplama yani. toplam=toplam+item demek ; 0=0+(girilen ilk ondalıklı sayi mesela 2,3 olsun) bu şöyle olur artık= 2,3=2,3+(diğer girilen ondalıklı sayı)
        //     {
        //        toplam = toplam + item;
        //     }
        //    return toplam / 10;
        //}

        //static void Main(string[] args)
        //{
        //    double[] dizi = new double[10];

        //    for (int i = 0; i < 10; i++)

        //    {
        //        Console.WriteLine("Sayı giriniiz:");
        //        double sayi = Convert.ToDouble(Console.ReadLine());
        //        dizi[i] = sayi;
        //    }

        //    Console.WriteLine("Sayıların aritmetik ortalaması:"+arit(dizi));
        //    Console.ReadKey();
        //}




        //static void intDegistir(ref int sayi)
        //{
        //    sayi = 100;
        //}
        //static void intDegistir0(out int sayi)
        //{
        //    sayi = 100;
        //}
        //static void Main(string[] args)
        //{
        //    int intsayi=25;
        //    Console.WriteLine(intsayi);
        //    intDegistir0(out intsayi);
        //    Console.WriteLine(intsayi);
        //    Console.ReadKey();

        //}






        //static void Main(string[] args)
        //{
        //    int[] dizi = new int[20];

        //    Random rsayi = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {

        //        int rsayi2 = rsayi.Next(20, 80);
        //        dizi[i] = rsayi2;
        //    }

        //    foreach (var item in dizi)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    int20(ref dizi);


        //    foreach (var item in dizi)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadKey();
        //}
        //static void int20(ref int[] sayi)
        //{
        //    for (int i = 0; i < sayi.Length; i++)
        //    {
        //        sayi[i]= sayi[i] + 20;
        //    }
        //}




        //static void Main(string[] args)
        //{
        //    Console.WriteLine(carp(3,5));
        //    Console.WriteLine(carp(3,5,4));
        //    Console.WriteLine(carp(3,5,4,7,8,9,4,22));
        //    Console.ReadKey();
        //}

        //static int carp( params int[] dizi)
        //{
        //    int carpim = 1;
        //    foreach (int item in dizi)
        //    {
        //        carpim = carpim * item;
        //    }
        //    return carpim;
        //}








        //static void Main(string[] args)
        //{
        //    carp(1, 5, 5, 5, 5, 5, 5, 5);
        //    carp(0, 6, 6, 6, 6, 6,6,6,6);
        //    Console.ReadKey();
        //}

        //static void carp(int kontrol, params int[] dizi) //değişen sayıda parametre alan değerler için params kullanılır.farklı sayıda elemanlar ile çağırabiliyoruz.dizi göndermiyoruz burada mainden göderirken parametreyi direk gönderdi. diziyi kendi kendine çekiyor. elemanları kendimiz veriyoruz.ilk değeri atanmamış outla, değişken sayıda parametre göndereceksek paramsla,değişkenin adresini yazamadım ya uf
        //{
            
        //    if (kontrol==0)
        //    {
        //        foreach (int item in dizi)
        //        {
        //            Console.Write(item+" ");
        //        }
        //    }
        //    else
        //    {
        //        foreach (int item in dizi)
        //        {
        //            Console.WriteLine(item);
        //        }
                    
        //    }
           
        //}










            //method overloading/ metot aşırı yükleme
        static void Main(string[] args)
        {
            Console.WriteLine(topla(6, 7));
            Console.WriteLine(topla(3, 2, 5));
            Console.ReadKey();
        }
        static int topla(int a, int b)
        {
            return (a + b);
        }
        static int topla(int a, int b, int c)
        {
            return (a + b + c);
        }
    }
}
