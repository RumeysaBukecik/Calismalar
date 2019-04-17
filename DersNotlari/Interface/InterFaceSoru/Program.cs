using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceSoru
{
    interface ISesGoruntuSistemleri
    {
        string Marka { get; set; }
        int Fiyat { get; set; }
        int Puan { get; set; }
        int PuanToplami { get; set; }
        int PuanciToplami { get; set; }

        void PuanVer(byte puan);

        void PuanGoster();

        void OzellikGoster();

    }

    interface ITeleviyon : ISesGoruntuSistemleri
    {
        string Cozunurluk { get; set; }
        byte EkranBoyutu { get; set; }
        bool UyduAlici { get; set; }
    }


    class Toshiba : ITeleviyon
    {
        private string TCozunurluk;
        public string Cozunurluk
        {
            get
            {
                return TCozunurluk;
            }
              
            set
            {
                TCozunurluk = value;
            }
        }
       
        private byte TEkranBoyutu;
        public byte EkranBoyutu
        {
            get
            {
                return TEkranBoyutu;
            }

            set
            {
                TEkranBoyutu = value;
            }
        }

        private bool TUyduAlici;
        public bool UyduAlici
        {
            get
            {
                return TUyduAlici;
            }

            set
            {
                TUyduAlici = value;
            }
        }
        private string TMarka;
        public string Marka
        {
            get
            {
                return TMarka;
            }

            set
            {
                TMarka = value;
            }
        }

        private int TFiyat;
        public int Fiyat
        {
            get
            {
                return TFiyat;
            }

            set
            {
                TFiyat = value;
            }
        }

       

        private int TPuan;
        public int Puan
        {
            get
            {
                return TPuan;
            }

            set
            {
                TPuan = value;
            }
        }

        private int TPuanToplami;
        public int PuanToplami
        {
            get
            {
                return TPuanToplami;
            }

            set
            {
                TPuanToplami = value;
            }
        }

        private int TPuanciToplami;
        public int PuanciToplami
        {
            get
            {
                return TPuanciToplami;
            }

            set
            {
                TPuanciToplami = value;
            }
        }

        public void PuanVer(byte puan)
        {
            switch (puan)
            {
                case 5:
                    this.PuanToplami += 5;
                    this.PuanciToplami += 1;
                    break;
                case 4:
                    this.PuanToplami += 4;
                    this.PuanciToplami += 1;
                    break;
                case 3:
                    this.PuanToplami += 3;
                    this.PuanciToplami += 1;
                    break;
                case 2:
                    this.PuanToplami += 2;
                    this.PuanciToplami += 1;
                    break;
                case 1:
                    this.PuanToplami += 1;
                    this.PuanciToplami += 1;
                    break;
                default:
                    Console.WriteLine("Hatalı puan girişi..");
                    break;
            }
        }

        public void PuanGoster()
        {
            int puansonuc = (PuanToplami / PuanciToplami);
            Console.WriteLine("Puan Ortalama: " + puansonuc);
        }

        public void OzellikGoster()
        {
            Console.WriteLine("Çözünürlük: " +Cozunurluk);
            Console.WriteLine("Ekran Boyutu: " + EkranBoyutu);
            Console.WriteLine("Uydu Alıcı: " + UyduAlici);
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Fiyat: " + Fiyat);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Toshiba tsh = new Toshiba();
            tsh.Cozunurluk = "12 İnç";
            tsh.EkranBoyutu = 208;
            tsh.UyduAlici = true;
            tsh.Marka = "Toshiba";
            tsh.Fiyat = 2890;
            tsh.PuanVer(5);
            tsh.PuanVer(3);
            tsh.PuanVer(2);
            tsh.PuanVer(4);
            tsh.PuanVer(5);
            tsh.PuanGoster();
            tsh.OzellikGoster();

            Console.Read();
        }
    }
}
