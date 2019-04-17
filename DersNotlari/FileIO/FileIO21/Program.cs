using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO21
{
    class Program
    {
        static void Main(string[] args)
        {
            string klasorAdi = "ProjeDosyalari";
            string klasorAdi2 = @"C:\FileIO";//C de dosya açtı.
            //Console.WriteLine(Directory.GetCurrentDirectory());//exenin çalıştığı yeri buluyor.

            //Directory.CreateDirectory(klasorAdi);//klasör oluşturma
            //Directory.CreateDirectory(klasorAdi2);

            //Console.WriteLine("C:\\FileIO oluşturma tarihi: ");
            //Console.WriteLine(Directory.GetCreationTime(klasorAdi2));//klasör oluşturma tarihini veriyor.
            //Directory.Delete(klasorAdi2);//Siler

            //bool klasorVarMi = Directory.Exists(klasorAdi2);
            //if (klasorVarMi)
            //{
            //    Console.WriteLine("Klasör var");
            //}
            //else
            //{
            //    Console.WriteLine("Klasör yok.");
            //    Directory.CreateDirectory(klasorAdi2);
            //    Console.WriteLine("Klasör oluşturuldu.");
            //}
            //string yolc = @"c:\";
            //string[] cdekiklasorler = Directory.GetDirectories(yolc);

            //foreach (var item in CdekiKlasorler)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] CdekiDosyalar = Directory.GetDirectories(yolC);
            //foreach (var item in CdekiDosyalar)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] CdekiDosyalarr = Directory.GetFiles(yolc, "*.sys"); //sys olanları getirir. uzantı filtreleme
            //foreach (var item in CdekiDosyalarr)
            //{
            //    Console.WriteLine(item);
            //}

            string yolC = @"C:\";
            string[] dosyaveklasorler = Directory.GetFileSystemEntries(yolC); //klasörleri listeler C deki
            foreach (var item in dosyaveklasorler)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
