using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusornegi1801
{
    abstract class Kus //özet sınıf
    {
        abstract public string Cins { get; set; }
        abstract public string Renk { get; set; }
        abstract public int Hiz { get; set; }
        public string KusTurAdi = "Tavuk";

        abstract public void SeyahatHesapla(int hiz, int mesafe);
    }

    class Karga : Kus
    {
        public new string KusTurAdi = "Alaca";
        private string CİNS;
        public override string Cins
        {
            get
            {
                return CİNS;
            }

            set
            {
                CİNS = value;
            }
        }

        private int HİZ;
        public override int Hiz
        {
            get
            {
                return HİZ;
            }

            set
            {
                HİZ = value;
            }
        }

        private string RENK;
        public override string Renk
        {
            get
            {
                return RENK;
            }

            set
            {
                RENK = value;
            }
        }

        public override void SeyahatHesapla(int hiz, int mesafe)
        {
            Console.WriteLine($"{RENK} {CİNS} {KusTurAdi} kuşu 100 km mesafeyi {(mesafe / hiz)} saatte alır.");
        }
    }

    class Kaz : Kus
    {
        private string CİNS;
        public override string Cins
        {
            get
            {
                return CİNS;
            }

            set
            {
                CİNS = value;
            }
        }

        private int HİZ;
        public override int Hiz
        {
            get
            {
                return HİZ;
            }

            set
            {
                HİZ = value;
            }
        }

        private string RENK;
        public override string Renk
        {
            get
            {
                return RENK;
            }

            set
            {
                RENK = value;
            }
        }

        public override void SeyahatHesapla(int hiz, int mesafe)
        {
           Console.WriteLine($"{RENK} {CİNS} {KusTurAdi} kuşu 100 km mesafeyi {(mesafe / hiz)} saatte alır.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Karga krg = new Karga();
            krg.Renk = "Mavi";
            krg.Cins = "Sivas";
            Kus ks = krg;
            ks.SeyahatHesapla(20,100);

            Kaz kz = new Kaz();
            kz.Renk = "Mavi";
            kz.Cins = "Kars";
            kz.KusTurAdi = "Kaz";
            Kus ks1 = kz;
            ks1.SeyahatHesapla(4, 100);
            Console.Read();
        }
    }
}
