using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_soru2201
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaAdresi = "C:\\Rum\\File2.txt";//dosya yolu belirlendi
            FileStream fs = new FileStream(dosyaAdresi, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default); //dosyaya text tabanlı veri girişi 
            while (true)
            {
                Console.Write("Ad giriniz: ");
                string yazi = Console.ReadLine();

                if (yazi.ToLower() == "kapat")
                {
                    break;
                }
                sw.WriteLine("Adı: " +yazi);//dosyaya yazma işi yapıldı

                Console.Write("Tc giriniz: ");
                string tc = Console.ReadLine();

                if (tc.ToLower()=="kapat")
                {
                    break;
                }
                sw.WriteLine("TC: " +tc);
            }
            sw.Flush();
            sw.Close();//streamwriter metoduna ilişkin kaynaklar iade edildi


            Console.Read();
        }
    }
}
