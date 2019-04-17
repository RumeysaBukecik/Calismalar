using System;
using System.Collections.Generic;
using System.Collections;  //koleksiyonlarda bu tanımlanır.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Koleksiyonlar
    {
        static void Main(string[] args)
        {
            //*************** KOLEKSİYONLAR
            //*********Array tek boyutlu
            ////System.Collection  sınıfınfan türetilir.
            //ArrayList aList = new ArrayList();
            //Console.WriteLine(aList.Capacity); //Eleman kapasitesini göster

            //aList.Add("Selma");
            //aList.Add(54);
            //aList.Add("Sakarya");
            //aList.Add(false);
            //aList.Add('R');
            //aList.Add(26.1F);
            //aList.Add(28.1D);
            //aList.Add(26.1F);
            //aList.Add(28.1D);
            //Console.WriteLine("Kapasitesi:" +aList.Capacity );   //Eleman sayısını değil kapasitesini verir.katlanarak gösterir.
            //Console.WriteLine("Eleman sayısı:" +aList.Count);

            //Console.WriteLine( );
            //Console.WriteLine("Silmeden önce:");
            //foreach (object item in aList)
            //{
            //    Console.WriteLine(item);
            //}
            //aList.Remove(false);
            //aList.Remove('R');
            //aList.Remove(26.1F);
            //aList.Remove(28.1D);
            //Console.WriteLine();
            //Console.WriteLine("Sildikten sonra:");
            //foreach (object item in aList)
            //{
            //    Console.WriteLine(item);
            //}
            //aList.TrimToSize(); //boş kapasiteyi sil
            //Console.WriteLine();
            ////Console.WriteLine("Kapasitesi:" +aList.Capacity);
            ////Console.WriteLine("Eleman sayısı:" +aList.Count);
            ////aList.Add(8);  //int 8 değerini ekliyor ve tekrar lapasitenin arttığını gördük. üstte de tanımlayabilirdik. farklı bir ekleme yöntemi bu.
            ////Console.WriteLine("Kapasitesi:" + aList.Capacity);
            ////Console.WriteLine("Eleman sayısı:" + aList.Count);

            ////Console.WriteLine(aList[0]);   //dizi gibi çağırabiliyoruz index 0 olanı getir yani ilk elemanı
            ////Console.WriteLine(aList[1]);
            ////Console.WriteLine(aList[3]);
            ////aList.Insert(2, "Çilek");

            ////Console.WriteLine(aList[0]);
            ////Console.WriteLine(aList[1]);
            ////Console.WriteLine(aList[2]);
            ////Console.WriteLine(aList[3]);









            //aList.Clear();  //Tüm elemanları sil.
            //aList.Add(54);  //int tipinde değer ekledik
            //aList.Add(41);   //""
            //aList.Add(17);   //""
            //aList.Sort();    //Dizi elemanlarını sıraladık. //17,41,54 oldu.
            //foreach (var item in aList)
            //{
            //    Console.WriteLine(item);
            //}
            //aList.Reverse();  //tersten yazdı
            //Console.WriteLine("----------Reverse sonrası----------");
            //foreach (var item in aList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(aList.Contains(55));  //55 değeri var mı yok mu
            //Console.WriteLine(aList.GetType());
            //Console.WriteLine(aList.IndexOf(17));  //17 nin hangi indexte olduğunu veriyor. 2
            //Console.WriteLine();
            //aList.RemoveAt(2);  //2.indexteki elemanı siler yani 17 yi
            //foreach (var item in aList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(aList.Count); //Eleman sayısını yazdırıyr
            ////aList.Clear();



            ////object[] odizi = new object[aList.Count]; // object türünde dizi tanımladık 
            ////aList.CopyTo(odizi); //elemansayısı array listimizin sayısı kadar olsun dedik
            ////foreach (var item in odizi)
            ////{
            ////    Console.WriteLine(item);
            ////}


            ////************


            //object[] odizi = aList.ToArray();
            //Console.WriteLine(odizi.Count());
            //foreach (var item in odizi)
            //{
            //    Console.WriteLine(item);
            //}





            //Klavyeden 0 girilene kadar girilen değerleri ArrayListe atan, bu arraylisti küçükten büyüğe sıralayan,arraylistteki elemanların aritmetik ortalamasını ekrana yazdıran ve son olarak arraylistin ortadaki elemanını da yazdırsın

            //int sayi;
            //int toplam = 0;
            //ArrayList aList = new ArrayList();
            //for (;;)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi==0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        aList.Add(sayi);
            //        toplam += sayi;
            //    }
            //}
            //aList.Sort();
            //Console.WriteLine("Sıralama:");
            //Console.WriteLine();
            //foreach (var item in aList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Aritmetik ortalama: {toplam/aList.Count}");
            //Console.WriteLine($"Ortancası:" +aList[aList.Count/2]);






            //ArrayList arr = new ArrayList();  //Array liste ilk değer(eleman) ataması yapıyoruz
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}











            //Kullanıcıdan 10 kişi için ad ve doğum yılı bilgisi istenecek.yaşı hesaplanacak(2019-Doğumyılı).ArrayListe aktarılacak.2 indis şeklinde.
            //Ekran çıktısı: Meltem Çelik 40
            //               Serhat Gülaştı 27


            //ArrayList aList = new ArrayList();
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Ad-Soyad giriniz:");
            //    string adsoy = Console.ReadLine();
            //    Console.WriteLine("Doğum yılınızı giriniz:");
            //    int dyili = Convert.ToInt32(Console.ReadLine());
            //    int yas = (2019 - dyili);
            //    aList.Add(adsoy);
            //    aList.Add(yas);
            //}
            //for (int i = 0; i < aList.Count; i+=2)  //i+=2 çünkü bizim 0,2,4 gibi çift indexlerimizde adsoy var. 1,3,5 gibi tek indexlerde yaş var. i++ olursa isim yas,isim yas yazar. 2 2 artırırsak ve içine alttakini yazarsak isim yas yazar 
            //{
            //    Console.WriteLine(aList[i] +" "+ aList[i+1]);      //aList[i] dedik adsoylar geldi bu şu demek; 0.indexi.. 0da da adsoy var. o yüzden onu yazdırıyor..aList[i+1] dedik bu da yaşları getirdi. 0 da adsoy var 1 de yaşlar
            //}



            //********** list, 2 boyutlu


            //List<Int32> listem = new List<int>();          //tip belirterek tanımlamış oluyoruz. hatalı tip belirtmek gibi hataların önüne geçer

            //listem.Add(88);
            //listem.Add(87);
            //listem.Add(86);
            //listem.Add(85);


            //Arraylist sınıfının metotları kullanılabilir.Örnek;
            //listem.Add, listem.Sort, listem.Clear gibi



            //****************** hashtable 2 boyutlu

            //keyi(1,2,3) bilmeden çağıramazsın değerini. 

            //Hashtable ht = new Hashtable();
            //ht.Add(1, "bir");
            //ht.Add(2, "iki");  //1,2,3 keyler ; bir,iki,üçler de değerler
            //ht.Add(3, "üç");

            //foreach (int item in ht.Keys)          //ilk sütun,anahtar değerler // ht.Keys şunu yapıyor; 1,2,3 ü yani ilk sütunu dizi gibi çağırıyor. 
            //{
            //    Console.WriteLine(item + "=>" +ht[item]);    //anahtar ile çağır
            //}












            
            Hashtable ht = new Hashtable();
            ht.Add(1, "bir");
            ht.Add(2, "iki");  
            ht.Add(3, "üç");
            Console.WriteLine(ht[2]); // keyi bilmeden olmadığının kanıtı
            ht.Remove(2);  //iki'yi sildi.
            foreach (int item in ht.Keys)          
            {
                Console.WriteLine(item + "=>" + ht[item]);    
            }
            Console.ReadKey();
        }
    }
}
