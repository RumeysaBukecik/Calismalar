using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    ////class Dortgen
    ////{
    ////    //erisim belirteci-Tip- değişken adı
    ////    public int sayi;
    ////    public string metin;
    ////    //double kare; //erişim belirteci yoksa: private
    ////    //private int cevre; //private sadece class içerisinde kullanmak istersek çağırılır.

    ////    public void Merhaba()
    ////    {
    ////        Console.WriteLine("Merhaba OOP");
    ////    }
    ////    private void Merhaba2()  //bunu yapmamızın hiçbir anlamı yok sırf dışarıda tanımlayamayacağımızı görmek için yazdık.
    ////    {
    ////        Console.WriteLine("Merhaba OOOOPPPPPP");
    ////    }
    ////    public string Merhaba3()
    ////    {
    ////        return "Merhaba OOPPSSSSSSSSSSSS";
    ////    }
    ////}
    ////class Program        //sınıftan nesne üretme araştır
    ////{
    ////    static string Merhaba22()
    ////    {
    ////        return "Merhaba";
    ////    }    
    ////    static void Main(string[] args)
    ////    {
    ////        //Nesne oluşturma
    ////        //sınıf adı-nesne adı=new sınıfadı()
    ////        Dortgen dortGen1 = new Dortgen();  //dortgen sınıfında dortgen1 nesne oldu //nesne tanımlama
    ////        //dortGen1.sayi = 7; //
    ////        //dortGen1.metin = "dörtGen1 Nesnesi"; //sadece metin ve sayiya eriştik çünkü diğerleri private.Public olanları dışarıya çağırabiliriz sadece
    ////        //Console.WriteLine($"{dortGen1.metin} {dortGen1.sayi}");

    ////        //ArrayList aList = new ArrayList(); //Sınıf kullanım örneği

    ////        dortGen1.Merhaba();
    ////        /* dortGen1.Merhaba2(); */  //hata verir çünkü private
    ////        Console.WriteLine(Merhaba22());  //farklı sınıfın nesnesini farklı sınıfta çağırırken dortgen1.Merhaba() diye çağırmalıyız. ama aynı sınıfta ise merhaba() diye çağırsak yeter
    ////        Console.WriteLine(dortGen1.Merhaba3()); //farklı sınıfta Merhaba3() yazdığımız için erişim belirteci kullanmalıyız.
    ////}
    ////}





        //fotooo

    //class Kurs
    //{
    //    public int sinif_no=404;
    //    public string Ogretmen_adi="Mehmet DEMİR";
    //    public int kursiyer_sayisi;

    //    private ArrayList Kursiyer_bilgileri = new ArrayList();

    //    private void Kursiyer_kayit()
    //    {
    //        for (int i = 0; i < kursiyer_sayisi; i++)
    //        {
    //            Console.Write("Kursiyer adını giriniz:");
    //            string kadi = Console.ReadLine();
    //            Kursiyer_bilgileri.Add(kadi);
    //        }

    //        Kursiyer_Listele(); //buradan çağırdık çünkü privatede gözükmez.

    //    }

    //    private void Kursiyer_Listele()
    //    {
    //        foreach (var item in Kursiyer_bilgileri)
    //        {
    //            Console.WriteLine("\nAdı:".PadRight(5)+item);
    //        }
    //    }

    //    public void Kurs_Ac()
    //    {
    //        Console.Write("Sınıf no giriniz:");
    //        sinif_no = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine();

    //        Console.Write("Öğretmen adı giriniz:");
    //        Ogretmen_adi = Console.ReadLine();
    //        Console.WriteLine();

    //        Console.Write("Kursiyer sayısı giriniz:");
    //        kursiyer_sayisi = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine();

    //        Kursiyer_kayit();
    //    }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Kurs Kurs404 = new Kurs();   //bunu diyerek biz yukarıdaki "kurs" sınıfımızı referans kıl yani takma adı gibi düşünebiliriz. 
    //        //Console.WriteLine("Sınıf numarası:" +Kurs404.Sınıf_no);
    //        //Console.WriteLine("Öğretmen Adı:" +Kurs404.Ogretmen_adi);
    //        //Console.Write("Kursiyer Sayısı giriniz:");
    //        //int ksayisi = Convert.ToInt32(Console.ReadLine());

    //        //Kurs404.Kursiyer_sayisi = (ksayisi);   //burada da klavye tarafından girilen ksayisini "kurs404" takma adını kullanılan sınıftaki "kursiyer_sayisine" yolla,ata
    //        //Kurs404.Kursiyer_kayit();       //bu metoda girmek için yazdık

    //        Kurs404.Kurs_Ac();

    //        Console.ReadKey();
    //    }

    //}




        //renk yazdırdık

    //class Araba
    //{
    //    public string Marka;
    //    public string Renk;
    //    private int Modelyili;

    //    public void ServisBigisiYaz(string renk)       //parametre olayını anlamadım küçük r büyük r falan
    //    {
    //        Console.WriteLine(this.Renk); //araba sınıfının rengini kastediyotuz this deyince
    //        Console.WriteLine(renk);

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Araba araba1 = new Araba();
    //        araba1.Renk = "Siyah";
    //        araba1.ServisBigisiYaz("Beyaz");

    //        Console.ReadKey();
    //    }
    //}



        //4 işlem yapan ç deyince çıkarma yapcak vs

    class Matematik
    {
        public char islem;
        public double sonuc;
        public double sayi1;
        public double sayi2;

        

        public void İslemYap()
        {
            Console.WriteLine("Sayı 1'i giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sayı 2'yi giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İşlem türünü seçiniz:");
            islem = Convert.ToChar(Console.ReadLine());

            

            if (islem=='T')
            {
                Topla();
            }

            if (islem=='C')
            {
                Cıkarma();
            }

            if (islem=='P')
            {
                Carpma();
            }

            if (islem=='B')
            {
                Bolme();
            }
        }


        public void Topla()
        {
          sonuc=sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }


        public void Cıkarma()
        {
            sonuc=sayi1 - sayi2;
            Console.WriteLine(sonuc);
        }


        public void Carpma()
        {
            sonuc=sayi1 * sayi2;
            Console.WriteLine(sonuc);
        }


        public void Bolme()
        {
            sonuc=sayi1 / sayi2;
            Console.WriteLine(sonuc);
        }


    }



    class Program
    {
        static void Main(string[] args)
        {

            Matematik mat = new Matematik();
            mat.İslemYap();
            
            Console.ReadKey();
        }


    }
} 
        
    

