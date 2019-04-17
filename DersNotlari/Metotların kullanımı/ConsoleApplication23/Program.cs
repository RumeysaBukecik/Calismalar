using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{


    ////üçgenin kenar uzunluklarını aşağıdaki matematiksel kurallara göre alınız ve çevre hesaplama metodunu int dönüş tipi ile tanımlayıp kukkanınız.
    ////Her kenar diğer iki kenarın toplamından küçük, farkından büyük olmalıdır. 3.kenar koşulu sağlamıyorsa tekrar istesin.
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Ucgen ucg1 = new Ucgen();

    //        ucg1.KenarGir();


    //        Console.ReadKey();
    //    }
    //}
    //class Ucgen
    //{
    //    private int Kenar1;
    //    private int Kenar2;
    //    private int Kenar3;
    //    private int Yukseklik;

    //    public int publicKenar1
    //    {
    //        get { return Kenar1; }    //almak   //kontrollü alma
    //        set                                //private Kenar1 e kontrollü atama
    //        {
    //            if ((value < 0 || value == 99))
    //                Kenar1 = 10;
    //            else
    //                Kenar1 = value;
    //        }

    //    }


    //    public int publicKenar2
    //    {
    //        get { return Kenar2; }    //almak   //kontrollü alma
    //        set                                //private Kenar1 e kontrollü atama
    //        {
    //            if ((value < 0 || value == 99))
    //                Kenar2 = 10;
    //            else
    //                Kenar2 = value;
    //        }

    //    }


    //    public int publicKenar3
    //    {
    //        get { return Kenar3; }    //almak   //kontrollü alma
    //        set                                //private Kenar1 e kontrollü atama
    //        {
    //            if (value > Math.Abs(Kenar1 - Kenar2) && value < (Kenar1 + Kenar2))
    //                Kenar3 = value;
    //            else
    //            { 
    //                Console.Write("3.Kenarı giriniz:");
    //                publicKenar3 = Convert.ToInt32(Console.ReadLine());
    //            }
    //        }

    //    }


    //    public void KenarYazdir()
    //    {
    //        Console.WriteLine($"Kenar1={Kenar1} \nKenar2={Kenar2}  \nKenar3={Kenar3}");

    //        CevreHesapla();
    //    }


    //    public void KenarGir()
    //    {
    //        Console.Write("1.Kenarı giriniz:");
    //        publicKenar1 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("2.Kenarı giriniz:");
    //        publicKenar2 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("3.Kenarı giriniz:");
    //        publicKenar3 = Convert.ToInt32(Console.ReadLine());

    //        KenarYazdir();
    //    }


    //    public int CevreHesapla()
    //    {

    //        Console.WriteLine("Çevre Hesap:" +(Kenar1+Kenar2+Kenar3)/3);
    //        return ((Kenar1 + Kenar2 + Kenar3) / 3);

    //    }





    //    //int a;


    //    //a = 5; // SET metodu çalıştı. value(değer) atama
    //    //Console.WriteLine( a); // GET (oku, al metodu çalıştı


    //}










    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Ucgen ucg1 = new Ucgen();
    //        Console.WriteLine(ucg1.Kenar1);
    //        Console.WriteLine(ucg1.Kenar2);
    //        Console.WriteLine(ucg1.Kenar3);
    //        Console.WriteLine();

    //        Ucgen ucg2 = new Ucgen(6, 8, 10);

    //        Console.WriteLine(ucg2.Kenar1);
    //        Console.WriteLine(ucg2.Kenar2);
    //        Console.WriteLine(ucg2.Kenar3);

    //        Console.ReadKey();
    //    }
    //}







    ////

    //class Ucgen
    //{
    //    public int Kenar1;
    //    public int Kenar2;
    //    public int Kenar3;



    //    //Yapıcı metotlar class ile aynı isim olmalıdır
    //    public Ucgen()  //Yapıcı Metot(Constructor)
    //    {
    //        Kenar1 = 3;
    //        Kenar2 = 4;
    //        Kenar3 = 5;
    //        Console.WriteLine("Yapıcı(Constructor) çalıştı");

    //    }


    //    //YAPICI METOT(Constructor) Parametreli
    //    public Ucgen(int kenar1, int kenar2, int kenar3)
    //    {
    //        this.Kenar1 = kenar1;
    //        this.Kenar2 = kenar2;
    //        this.Kenar3 = kenar3;

    //    }

    //}












    //  Foto
    class Program
    {
        static void Main(string[] args)
        {
            Sirket srkt1 = new Sirket();    //Parametresiz Yapıcı  //1.pubic
            Sirket srkt2 = new Sirket();  //2.public
            Console.WriteLine(srkt2.Sirketadi);
            Console.WriteLine(srkt2.SirketTurleri[srkt2.SirketTuru]);     //arrayden istediğimiz için [] kullandık.
            Console.WriteLine(srkt1.Sirketadi);
            Console.WriteLine(srkt1.SirketTuru);
            Console.WriteLine(srkt1.SirketTurleri[srkt1.SirketTuru]);

            Console.ReadKey();
        }
        
    }
    
 
    class Sirket
    {
        public string Sirketadi;
        public string VergiDairesi;
        public string VergiNumarasi;
        public byte SirketTuru;

        public ArrayList SirketTurleri =new ArrayList { "Anonim", "Limeted", "Sahıs" };   //string oldukları için tırnak içinde belirttik

        public Sirket()
        {
            Sirketadi = "Bilgi eksik";
            VergiDairesi = "Bilgi eksik";
            VergiNumarasi = "Bilgi eksik";
            SirketTuru = 2;     //string veriyi kaydetmek yerine byte a atarsak yer açmış oluruz. bu yüzden 2 diye belirttik. 2, 8 bitlik yer demek
        }

        public Sirket(string sirketAdi, string vergiDairesi, string vergiNumarasi, byte sirketTuru)
        {
            Sirketadi = sirketAdi;
            VergiDairesi = vergiDairesi;
            VergiNumarasi = vergiNumarasi;
            SirketTuru = (byte)SirketTurleri.IndexOf(sirketTuru);   //tür dönüşümü yaptık bilinçli
        }


    }
}
