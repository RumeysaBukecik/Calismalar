using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Dosyalama_Devam_2201
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dosyaYolu = @"C:\FileIO";
            //Console.WriteLine(Directory.GetDirectoryRoot(dosyaYolu)); //C:\ de nerde olduğunu gösterir.

            //Console.WriteLine(Directory.GetLastAccessTime(dosyaYolu)); //en son ne zaman açıldığı
            //Console.WriteLine(Directory.GetLastWriteTime(dosyaYolu)); //en son ne zaman yazıldığı, değiştirildiği

            //string[] logicalDrive = Directory.GetLogicalDrives();

            //foreach (var item in logicalDrive)
            //{
            //    Console.WriteLine(item);  // C:\ D:\ E:\ mantıksal driveleri gösterir
            //}

            //Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()));  //get parent bir üstteki dosyanın adresini getitir

            //string kaynakDosyaYolu = @"C:\FileIO";
            //string hedefDosyaYolu = @"C:\Rum\FileIO";

            //Directory.Move(kaynakDosyaYolu, hedefDosyaYolu);// cdeki FileIO 'yu Rum klasorune taşır.

            string dosyaYolu2 = @"C:\Rum\FileIO";
            ////DateTime simdi = DateTime.Now;
            ////Directory.SetLastAccessTime(dosyaYolu2, simdi);
            ////Directory.SetLastWriteTime(dosyaYolu2, simdi);
            ////Directory.SetCreationTime(dosyaYolu2, simdi); //son dosyanın oluşturulma tarihini şu an yaptık

            ////Console.WriteLine(Directory.GetLastAccessTime(dosyaYolu2));
            ////Console.WriteLine(Directory.GetCreationTime(dosyaYolu2));
            ////Console.WriteLine(Directory.GetLastWriteTime(dosyaYolu2));

            Console.WriteLine(Directory.GetCurrentDirectory()); //şu an çalışan dosyayı veriyor

            string orjinalYol = @"c: \users\rumeysa.bukecik\documents\visual studio 2015\Projects\Directory(Dosyalama)2201\Directory(Dosyalama)2201\bin\Debug";
            string yeniYol = @"C:\Rum";  //projemizin yeni yolu
            Directory.SetCurrentDirectory(yeniYol);
            Console.WriteLine(Directory.GetCurrentDirectory());//projenin yolunu değiştiriyor
            Console.Read();
        }
    }
}
