using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i =  1; i <= 3; i++)
            //{
            //    Console.WriteLine("For Dögüsü");
            //}




            //for (int i = 1; i <=100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i+" Sayısı çifttir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i+ " Sayısı tektir.");
            //    }
            //}







            //for (int i = 100; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i+ " Sayısı çifttir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i+ " Sayısı tektir.");
            //    }
            //}








            //int toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    int kare = i * i;
            //    toplam = toplam + kare;
            //    Console.WriteLine(i+ "'nin karesi "+kare);
            //}
            //    Console.WriteLine("Karelerin toplamı:"+toplam);







            //for (int dikey = 5; dikey >= 1; dikey--)
            //{
            //    for (int yatay = 1; yatay <= dikey; yatay++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            //int calisansayisi = 3;
            //int toplamcocuk = 0;
            //for (int i = 1; i <= calisansayisi; i++)

            //{
            //    Console.Write(i + ". İşçinin çocuk sayısı: ");
            //    int cocuksayisi = int.Parse(Console.ReadLine());

            //    for (int k = 1; k <= cocuksayisi; k++)
            //    {
            //        Console.Write(k + ". Çocuğun tc no: ");
            //        int tcno = Convert.ToInt32(Console.ReadLine());

            //    }
            //    toplamcocuk = toplamcocuk + cocuksayisi;

            //}

            //Console.WriteLine("Toplam çocuk sayısı" + toplamcocuk);










            //int sayi = 45;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    for (int k = 1; k <= i; k++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.Write("#");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();








            //int sayi = 21;
            //for (int i = 1; i <=sayi; i++)
            //{
            //    for (int k = 1; k <=i; k++)
            //    {
            //        if (i%9==0)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(i);
            //        }
            //    }
            //    Console.WriteLine();
            //}







            //for (int i = 1; i <= 21; i++)
            //{

            //    if (i % 9 == 0)
            //    {

            //        for (int k = 1; k <= i; k++)
            //            Console.Write("*");
            //        }

            //        else

            //    {
            //        for (int j = 0; j < i; j++)
            //            Console.Write(i);
            //        }

            //    Console.Write("\n");
            //}
            //Console.ReadKey();













            //for (int i = 1; i <=15; i++)
            //{
            //    for (int k = 1; k <=10; k++)
            //    {
            //        Console.WriteLine(i+"x"+k+"="+(i*k));
            //    }
            //    Console.WriteLine("\n.........\n");
            //}
            //Console.WriteLine();







            //int i = 1;
            //while (i <= 10) 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadKey();








            //char a = ' ';
            //while (a != 'K')
            //{
            //    Console.WriteLine("Klavyeden harf giriniz:");
            //    a = Convert.ToChar(Console.ReadLine());

            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();













            Console.WriteLine("Sayı giriniz");
            String sayi = Console.ReadLine();
            int sayig = Int32.Parse(sayi);
            long donusum = long.Parse(sayi);
            short donusum2 = short.Parse(sayi);

            while (sayig!=0)
            {
                if (sayig>1024)
                {
                    Console.WriteLine("Sayı: "+donusum+ "\nTürü"+donusum.GetType());
                }
                else if (sayig<1024)
                {
                    Console.WriteLine("Sayı: "+donusum2+"\nTürü"+donusum2.GetType());
                }
            }

            Console.ReadKey();
            }


        }
  
        }
    

