using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Sorusu2201
{
    class Program
    {
        static void Main(string[] args)
        {
            //fotooooo tarihli 
            //DateTime dt = DateTime.Now; //tarih aldı değişkene atadı
            //Console.WriteLine(dt.ToShortDateString()); //tarihi döndürdü bugünki
            //string date = dt.ToShortDateString();//bunu date değişkenine atadı
            //date = date.Replace('.', '_');//tarihin noktalarını _ yaptı
            //string DosyaYolu = $@"C:\Rum\{date}";//klasor yolu olarak bunu kullanmak için date var mı diye kontrol etmek istedi

            //bool klasorVarMi = Directory.Exists(DosyaYolu);
            //if (klasorVarMi)
            //{
            //    Console.WriteLine("Klasör var");
            //}
            //else
            //{
            //    Console.WriteLine("Klasör yok.");
            //    Directory.CreateDirectory(DosyaYolu);
            //    Console.WriteLine("Klasör oluşturuldu.");
            //}

            //Console.WriteLine(Directory.GetLastWriteTime(DosyaYolu));





            //FILE
            //string dosyaYolu = "C:\\FileIO\\FileIO.txt";
            //string destDosyaYolu = "C:\\Rum\\File2.txt";
            ////Console.WriteLine(File.Exists(dosyaYolu));//olup olmadığını döndürüyor. true veya false

            //////File.Copy(dosyaYolu, destDosyaYolu, true); //kopyala yapıştır
            ////File.Move(dosyaYolu, destDosyaYolu); //Kes yapıştır

            //Console.WriteLine(File.GetAttributes(destDosyaYolu));//işletim sisteminin tuttuğu dosya özelliğini veriyor
            //File.SetAttributes(destDosyaYolu, FileAttributes.Hidden); //dosyayı gizledi
            //Console.WriteLine(File.GetAttributes(destDosyaYolu));


            //**********************FileStream; Dosyaya veri akış kanalı açıyoruz. Bu akış yolunu kullanarak okuma ve yazma işlemi yapıyoruz

            //string DosyaYoluu = "C:\\Rum\\File2.txt";
            //FileStream fs = new FileStream(DosyaYoluu, FileMode.Open); //kanal açıyor. otoyol gibi düşün
            //StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));//dosyanın içindeki verileri bize getiriyor metrobüs gibi düşün. encoding ile de türkçe karakterleri de getiriyor
            //string satir;
            //int i=1;
            //while ((satir = sr.ReadLine()) != null) //satır satır oku
            //{
            //    Console.WriteLine($"Satır {i} : " +satir);
            //    i++;
            //}
            //fs.Close();
            //Console.Read();



            //***************FileStream Streamwriter
            string DosyaYolu = "C:\\Rum\\File2.txt";
            FileStream fs = new FileStream(DosyaYolu, FileMode.Create, FileAccess.Write);//FileMode'in yerine ne yazarsak onu yapıyor. mesela append ekliyor altta yazdıklarımızı, truncate daha önce altta yazdıklarımız haricinde yazılanları siliyor
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);//dosya kanalı açtık ve yazmak için de ayrı bir kanal oluşturmuş olduk

            //sw.WriteLine("Merhaba c#");
            //sw.WriteLine("Beşiktaş");
            //sw.WriteLine("Sarıyer");

            while (true) //döngüm sonsuz olsun
            {
                Console.Write("Yazı giriniz: ");
                string yazi = Console.ReadLine();

                if (yazi.ToLower()=="q")//tolower dedik çünkü adam büyük q da girse küçük q da girse küçüğe çevirecek.
                {
                    break;
                }
                sw.WriteLine(yazi); 
            }
            sw.Flush();//Bellekteki veriyi dosyaya yazdırıyor
            sw.Close();//streamWriter ı kapat
            Console.Read();
        }
    }
}