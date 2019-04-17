using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do while döngüsü
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("Merhaba Uzay" + i);
            //    i++;
            //} while (i < 16);
            //Console.WriteLine("Döngü Bitti");
            //Console.ReadKey();






            //1 den 100 e kadar olan sayıların karelerini ekrana yazdıran programı do while döngüsü ile yazınız.
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i*i);
            //    i++;
            //} while (i<=100);
            //Console.WriteLine("Döngü bitti.");
            //Console.ReadKey();








            //Kullanıcıdan kullanıcı adı ve parola isteyeceğiz. 5 kez deneme hakkı var. 5 kez denedikten sonra doğru ise ekrana "Giriş Başarılı" yazdırılacak ve döngüden çıkacak.

            //int i = 1;
            //const string ad = "smartpro";
            //const string parola = "SmartKD";

            //do
            //{
            //    Console.WriteLine("Ad soyad giriniz");
            //    string adsoy = Console.ReadLine();
            //    Console.WriteLine("Parola giriniz");
            //    string sifre = Console.ReadLine();
            //    if (adsoy == ad && sifre == parola)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else if (i<=5)
            //    {
            //        Console.WriteLine("Çok fazla hatalı giriş yaptınız.");
            //    }

            //    i++;

            //} while (i<=5);
            //Console.ReadKey();







            //continue
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i==10)

            //        continue;     //10 u yazdırmadan devam eder.
            //    if (i == 20)
            //            break;
            //        Console.WriteLine("Sayı" +i);

            //}







            //kullanıcı tarafından girilen sayı kadar ekrana SMARTPRO yazan,sayının yarısına gelince ekrana "SMART" yazıp SMARTPRO yazmadan döngüye devam etsin.

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    Console.WriteLine("iş miş meri veri christmas");
            //    if (i==sayi/2)
            //    {
            //        Console.WriteLine("hoh hoh hooo");
            //        continue;
            //        Console.WriteLine("iş miş meri veri christmas");
            //    }
            //}








            //Random
            //Random rastgele = new Random();

            //for (int i = 1; i < 10; i++)
            //{
            //    int rsayi = rastgele.Next();
            //    Console.WriteLine(rsayi);
            //}







            //Random rfonk = new Random();
            //int i = 1;
            //int rsayi = rfonk.Next(1,41);
            //int tahmin;
            //do
            //{

            //    do
            //    {
            //        Console.WriteLine("1-40 arasında tahmini sayı giriniz:");
            //        tahmin = Convert.ToInt32(Console.ReadLine());
            //        //if (tahmin < 0 || tahmin > 40)
            //        //{
            //        //    Console.WriteLine("Tahmin Aralığı Yanlış :");
            //        //}
            //    } while (tahmin<0 || tahmin>40);
            //    if (tahmin == rsayi)
            //    {
            //        Console.WriteLine("Tebrikler Bildiniz.");
            //        break;
            //    }
            //    else if (tahmin > rsayi)
            //    {
            //        Console.WriteLine("Tahmininiz sayıdan büyüktür.");
            //    }
            //    else if (tahmin < rsayi)
            //    {
            //        Console.WriteLine("Tahmininiz sayıdan küçüktür.");
            //    }
            //    i++;

            //} while (i<=10);
            //Console.WriteLine("Sayı: " +rsayi);
            //Console.ReadKey();










            //Random rfonk = new Random();
            //int rsayi = rfonk.Next();
            //Console.WriteLine("Bir sayı giriniz");
            //int tahmin = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("1-100 arasında tahmini sayı giriniz:");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //} while (tahmin>1 || tahmin<100);
            //for (int i = 1; i <= 15; i++)
            //    {
            //        if (tahmin == rsayi)
            //        {
            //            Console.WriteLine("Başarılı");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Başarısız" );
            //        }
            //    }



            //int sayi;

            //do
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //} while (sayi<1 || sayi >100);

            //Random rsayi = new Random();
            //for (int i = 1; i <= 15; i++)
            //{
            //    int rast = rsayi.Next(1, 100);
            //    if (sayi == rast)
            //    {
            //        Console.WriteLine(i + ". defada doğru bildiniz");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bilemediniz.");
            //    }
            //}





            //Console.WriteLine("1.ifade");
            //goto ifade3;
            //Console.WriteLine("2.ifade");
            //ifade3:
            //Console.WriteLine("3.ifade");

            //Console.ReadKey();
            //TODO: Diziler anlatılacak.         //view-task list




            int sayi;
            Random rast = new Random();
            for (;;)
            {
                sayi = rast.Next(1, 20);
                Console.WriteLine(sayi);
                if (sayi==11)
                {
                    Console.WriteLine("Döngü bitti.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
