using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{ //sabit veri tipleri
    enum Markalar : byte { Honda=1, Mazda, Ford, Mercedes, Renault, Toyota, Tofaşk, Lamborghini, Ferrari, Scania, Volvo}
    enum Vitesler : byte { Manuel, Otomatik, Yarı_Otomatik}
    enum Renkler  : byte  { Kırmızı, Beyaz, Siyah, Turuncu, Yeşil, Mavi, Mor}

    class Arac //üst sınıf  //araç sınıfı 
    {
        public Markalar Marka;  //enumdan değişken tanımlama
        public Vitesler Vites;
        public Renkler Renk;
        protected short MotorHacmi;
        //Mainde direkt atama yapılamaz. Ancak yapıcı metot ile değer ataması yapılabilir

        //Araç sınıfı Constructer(Yapıcı) Metodu
        public Arac(Markalar marka, Vitesler vites, Renkler renk, short motorHacmi)
        {
            Marka = marka; Vites = vites; Renk = renk; MotorHacmi = motorHacmi; 
            //yanyana olması bir şey farkettirmez. noktalı virgül ile ayrılır.
        }
    }
    //otomobil sınıfı alt sınıf
    class Otomobil:Arac
    {
        public byte KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        
        public Otomobil( byte kapiSayisi, string model, bool ceker4, bool parkSensoru, /* üst sınıfa gidecekler--->>>>>>>*/  Markalar marka, Vitesler vites, Renkler renk, short motorHacmi) : base(marka, vites, renk, motorHacmi)
        {
            this.KapiSayisi = kapiSayisi;
            this.Model = model;
            this.Ceker4 = ceker4;
            this.ParkSensoru = parkSensoru;

        }


        public void OtomobilBilgiYaz()
        {
            /*
             Ekrana yazdırırken bool tipindeki değişkenlere karşılık string ifadeler yazdırmak
             için 2 adet string tanımladık.     
             */

            string sCeker4;

            if (Ceker4 == true)
            {
                sCeker4 = "Araç 4 çeker.";
            }
            else
            {
                sCeker4 = "Araç 2 çeker.";
            }


            string sParkSensoru;

            if (ParkSensoru == true)
            {
                sParkSensoru = " var.";
            }
            else
            {
                sParkSensoru = " yok.";
            }

            Console.WriteLine($"Araç Markası: {Marka} Modeli: {Model}");
            Console.WriteLine($"Araç vites tipi: {Vites} Rengi: {Renk}");
            Console.WriteLine($"Araç motor hacmi: {MotorHacmi} Kapı sayısı: {KapiSayisi}");
            Console.WriteLine(sCeker4);
            Console.WriteLine("Park sensörü" +sParkSensoru);
            
        }
    }

    

    class Ticari:Arac
    {
        public short TasimaKapasitesi;
        public short YolcuKapasitesi;
        public bool Ceker4;
        

        public Ticari(short tasimaKapasitesi, short yolcuKapasitesi, bool ceker4, Markalar marka, Vitesler vites, Renkler renk, short motorHacmi) : base(marka, vites, renk, motorHacmi)
        {
            this.TasimaKapasitesi = tasimaKapasitesi;
            this.YolcuKapasitesi = yolcuKapasitesi;
            this.Ceker4 = ceker4;
        }

        public void TicariBilgiYaz()
        {
            string sCeker4;

            if (Ceker4 == true)
            {
                sCeker4 = "Araç 4 çeker.";
            }
            else
            {
                sCeker4 = "Araç 2 çeker.";
            }

            Console.WriteLine($"Araç Markası: {Marka} Taşıma kapasitesi: {TasimaKapasitesi} ");
            Console.WriteLine($"Araç vites tipi: {Vites} Rengi: {Renk}");
            Console.WriteLine($"Araç motor hacmi: {MotorHacmi} Yolcu kapasitesi: {YolcuKapasitesi}");
            Console.WriteLine(sCeker4);
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Otomobil ot1 = new Otomobil(2, "Practica", false,false,Markalar.Mazda,Vitesler.Otomatik, Renkler.Yeşil, 1500);//yapıcı metoda parametre yolluyoz sıkı dur

            ot1.OtomobilBilgiYaz();

            Console.WriteLine("\n**********\n");

            Ticari ti1 = new Ticari(1500, 2, true, Markalar.Volvo, Vitesler.Manuel, Renkler.Siyah, 4500);

            ti1.TicariBilgiYaz();

            Console.Read();


        }
    }
}
