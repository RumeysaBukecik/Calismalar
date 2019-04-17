using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] dizi11 = { 2, 3, 5, 6 };
            ////int[] dizi12 = new int[4];
            //int[,] diziıb = new int[4, 3]; //4 satır 3 sütun sayısı
            //Random rast = new Random();
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int k = 0; k < 3; k++)
            //    {
            //        int rsayi = rast.Next(101);
            //        diziıb[i, k] = rsayi;
            //        Console.Write("  "+diziıb[i, k]+"  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(diziıb[1,1]);




            //int[,] diziıb2 = new int[3, 2];
            //Random rast2 = new Random();
            //int toplam = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int k = 0; k < 2; k++)
            //    {
            //        int rsayi2 = rast2.Next(10, 29);
            //        diziıb2[i, k] = rsayi2;
            //        Console.Write("  "+diziıb2[i, k]+" ");

            //        if (i==1)
            //        {
            //            toplam = toplam + diziıb2[i, k];
            //        }
            //    }
            //    Console.WriteLine();
            //}



            //Console.WriteLine("X değerini giriniz:");
            //int xsayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Y değerini giriniz:");
            //int ysayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Z değerini giriniz:");
            //int zsayi = Convert.ToInt32(Console.ReadLine());

            //int[,,] diziler = new int[xsayi, ysayi, zsayi];
            //Random rast = new Random();
            //int toplam = 0;
            //for (int i = 0; i < xsayi; i++)
            //{
            //    Console.Write("(");
            //    for (int k = 0; k < ysayi; k++)
            //    {
            //        Console.Write("[");
            //        for (int m = 0; m < zsayi; m++)
            //        {
            //            int rsayi = rast.Next(10, 91);
            //            diziler[i, k, m] = rsayi;
            //            Console.Write("  " + diziler[i, k, m] + " ");

            //            if (k==0 && m==0)
            //            {
            //                toplam = toplam + diziler[i, k, m]; //x satır sayısı, y sütun sayısı, z sütundaki sütun sayısı yani derinlik
            //            }
            //        }
            //        Console.Write("]");
            //    }
            //    Console.WriteLine(")");

            //}
            //Console.WriteLine("Toplam:"+toplam);














            //object[,] diziObje = new object[2,2];
            //diziObje[0, 0] = 5;
            //diziObje[0, 1] = "Smartpto";
            //diziObje[1, 0] = 'F';
            //diziObje[1, 1] = 14F;
            //foreach (var item in diziObje)
            //{
            //    Console.WriteLine(item);
            //}

            
            Console.WriteLine("Öğrenci sayısını giriniz:");
            int xsayi = Convert.ToInt32(Console.ReadLine());
            object[,] diziobje = new object[xsayi, 3];
            for (int i = 0; i < xsayi; i++)
            {
                Console.WriteLine("Ad soyad giriniz:");
                string adsoy = Console.ReadLine();
                diziobje[i, 0] = adsoy;
                Console.WriteLine("Not giriniz:");
                int not = Convert.ToInt32(Console.ReadLine());
                diziobje[i, 1] = not;


                if (not > 0 && not <= 29)
                {
                    diziobje[i, 2] = "Çok zayıf";

                }
                else if (not > 29 && not <= 54)
                {
                    diziobje[i, 2] = "Zayıf";
                }
                else if (not > 54 && not <= 69)
                {
                   
                    diziobje[i, 2] = "Orta";
                }
                else if (not > 69 && not <= 84)
                {
                    
                    diziobje[i, 2] = "İyi";
                }
                else
                {
                    
                    diziobje[i, 2] = "Pekiyi";
                }
            }
            for (int i = 0; i < xsayi; i++)
            {
                Console.Write(diziobje[i, 0] + " " + diziobje[i, 1] + " " +diziobje[i,2] );
                Console.WriteLine();
            }






            Console.ReadKey();
        }
    }
}
