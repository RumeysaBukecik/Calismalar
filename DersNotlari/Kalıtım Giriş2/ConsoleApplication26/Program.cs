using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{

    class AnaSinif
    {
        public int sayi;
        public string Yazi;
        private char C; //alt sınıftan private erişim yok
        protected char Cprotected; //mainden erişilmez alt sınıftan erişilir

        public void Yazdir()
        {
            Console.WriteLine("Sayı : "+sayi+ " Yazı : "+Yazi);
        }
    }

    class AltSinif : AnaSinif  //anasiniftan altsinifi türettik
    {
        public int AltSayi;
        public string AltYazi;

        public char CproAta  //mainden dolaylı erişim yapmak için yazdık bu metodu
        {
            get { return Cprotected;  }
            set { Cprotected = value; }
        }

        public void AltYazdir()
        {
            Console.WriteLine("Merhaba " +AltSayi+" " +AltYazi);
            Console.WriteLine(Cprotected);
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            AltSinif alt1 = new AltSinif();
            alt1.sayi = 55;
            alt1.Yazi = "Merhaba";
            alt1.AltYazi = "Dünya";
            alt1.AltSayi = 44;

            alt1.CproAta = 'F';

            alt1.Yazdir();
            alt1.AltYazdir();

            Console.Read();
        }
    }
}
