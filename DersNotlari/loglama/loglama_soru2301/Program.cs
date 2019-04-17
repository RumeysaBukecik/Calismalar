using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loglama_soru2301
{
    //C:\TEST altında bulunan dosyalardan değiştirilme tarihi 1 gün önce olan dosyaları C:\HEDEF klasörüne kopyalayan programı yazınız.
    //C:\HEDEF klasörüne kopyalanan ve değiştirime tarihi 5 günden eski olan dosyaları silen programı yazınız.
    //C:TEST\SilmeLoglari.txt
    class Program
    {
        static void Main(string[] args)
        {

            string yolC = @"C:\";

            string[] CdekiKlasorler = Directory.GetDirectories(yolC);

            foreach (var item in CdekiKlasorler)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
