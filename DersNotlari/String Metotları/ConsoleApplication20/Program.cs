using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //string kucuk = "smartpro";
        //string buyuk = "SMARTPRO";
        //Console.WriteLine(kucuk.ToUpper()); //harfleri büyülttü.
        //Console.WriteLine(buyuk.ToUpper());  //harfleri küçülttü.
        //Console.WriteLine(buyuk.Remove(0,5)); //5 karakteri silecek.
        //Console.WriteLine(buyuk.Insert(8,"BRO"));
        //Console.WriteLine(buyuk.Replace('P','B'));   //p ile b yer değiştirdi

        //string str = "Merhaba 404";
        //Console.WriteLine(str.Substring(8)); //8. indexe kadar olan 8 indexi siliyor
        //Console.WriteLine(str.Substring(0,7)); //Merhaba
        //Console.WriteLine(str.Substring(0,1));  //M

        //Console.WriteLine(str.Contains("aba"));
        //Console.WriteLine(str[8]);   //8. elemanını getirdi






        //Klavyeden girilen metindeki harflerin ve boşlukların sayısını yazdıran(void) metodunu tanımlayınız.

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Metin giriniz:");
    //        string metin = Console.ReadLine();

    //        Metod(metin);   //metin değişkenimizi metoda yolluyoruz.

    //        Console.ReadKey();
    //    }

    //    static void Metod(string met) //string met veya metin olması farkermez. sadece kullanacaksak farkeder.
    //    {
    //        int bosluk = 0;
    //        int yazi = 0;

    //        for (int i = 0; i < met.Length; i++)
    //        {
    //            if (met.Substring(i, 1) == " ")  //i başlangıç indeksi. 1 de kaç tane karakter veya boşluk var onu sayıyor.
    //            {
    //                bosluk++;
    //            }
    //            else
    //            {
    //                yazi++;
    //            }
    //        }
    //        Console.WriteLine($"Boşluk sayısı: {bosluk}\nYazı sayısı:{yazi}");

    //    }

    //}







    //klavyeden cümle alıyoruz.cümledeki boşlukları silerek boşluksuz bir değişkene atayalım.
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Cümle giriniz:");
    //    string cumle2 = Console.ReadLine();

    //    Metod2(cumle2);   
    //    Console.ReadKey();
    //}

    //static void Metod2(string str2)
    //{


    //    for (int i = 0; i < str2.Length; i++)
    //    {
    //        if (str2.Substring(i, 1) == " ")
    //        {
    //            str2 = str2.Remove(i, 1);
    //        }

    //    }
    //    Console.WriteLine(str2);
    //    Console.ReadKey();









    //Klavyeden girilen metindeki karakteri string tipinde bir diziye atayacak.metot kullanmadan.chardiziyap metodu ile tüm karakterler char tipinde bir diziye atanacak.char tipinde dizi döndürecek
    //Bunu boşver ben yaptım
    //static void Main(string[] args)
    //{

    //    Console.WriteLine("Metin giriniz:");
    //    string metin = Console.ReadLine();
    //    string[] dizi = new string[metin.Length];   //girilen metnin karakterleri kadar(Length)

    //    for (int i = 0; i < metin.Length; i++)
    //    {
    //        dizi[i] = metin.Substring(i,1);   //metini diziye ata
    //    }
    //    Console.WriteLine(CharDiziYap);
    //    Console.ReadKey();
    //}
    //static char[] CharDiziYap(string[] dizi)
    //{
    //    char[] cDizi = new char[dizi.Length];

    //    for (int i = 0; i < dizi.Length; i++)
    //    {
    //        cDizi[i] = Convert.ToChar(dizi[i]);
    //    }
    //    return cDizi;
    //}


    //bu doğrusu

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Bir metin giriniz:");
    //    string text = Console.ReadLine();
    //    string[] sdizi = new string[text.Length];
    //    char[] charDizi = new char[text.Length];
    //    for (int i = 0; i < text.Length; i++)
    //    {
    //        sdizi[i] = text.Substring(i, 1);
    //    }

    //    charDizi = CharDiziYap(sdizi);

    //    foreach (var item in charDizi)
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.ReadKey();
    //}

    //static char[] CharDiziYap(string[] a)
    //{
    //    char[] diziChar = new char[a.Length];
    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        diziChar[i] = Convert.ToChar(a[i]);
    //    }
    //    return diziChar;
    //}









    ////klavyeden girilen metindeki kelime sayısını ekrana yazdıran(void) metodu yaz
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Metin giriniz:");
    //    string metin = Console.ReadLine();

    //    Metod(metin);
    //    Console.ReadKey();
    //}

    //static void Metod(string str)
    //{
    //    int kelime = 0;
    //    for (int i = 0; i < str.Length; i++)
    //    {
    //        if (str.Substring(i, 1) == " ")
    //        {
    //            kelime++;
    //        }
    //    }
    //    Console.WriteLine(kelime+1);

    //}




    //farklı yol

    //static void main(string[] args)
    //{
    //    console.writeline("metin giriniz:");
    //    string metin = console.readline();
    //    dizi(metin);

    //    console.readkey();
    //}

    //static void dizi(string qge)  
    //{
    //    string[] metindizi = degisken.split(' ');
    //    console.writeline(metindizi.length);
    //}




    //    //Ters yazma komutu
    //static void Main(string[] args)
    //{
    //    string asd = "Smartpro";
    //    for (int i = (asd.Length - 1); i >= 0; i--)
    //    {
    //        Console.Write(asd[i]);
    //    }
    //    Console.ReadKey();
    //}

}

