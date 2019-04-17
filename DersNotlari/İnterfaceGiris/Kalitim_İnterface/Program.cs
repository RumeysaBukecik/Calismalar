using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_İnterface
{
    interface ISablon1
    {
        string Renk { get; set; }
        string Tat { get; set; }
    }

    interface ISablon2
    {
        int Agirlik { get; set; }
        int Fiyat { get; set; }
    }

    class Portakal : ISablon1, ISablon2
    {
        private string PRenk;
        private string PTat; 
        private int PAgirlik;
        private int PFiyat;

        public string Renk
        {
            get { return PRenk; }
            set { PRenk = value; }
        }
        
        public string Tat
        {
            get { return PTat; }
            set { PTat = value; }
       
        }

        public int Agirlik
        {
            get { return PAgirlik; }
            set { PAgirlik = value; }
        }

        public int Fiyat
        {
            get{ return PFiyat; }
            set { PFiyat = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Portakal pr1 = new Portakal();
            pr1.Renk = "Turuncu";
            pr1.Tat = "Bal Şeker";
            pr1.Agirlik = 5;
            pr1.Fiyat = 20;

            Console.WriteLine(pr1.Renk);
            Console.WriteLine(pr1.Tat);
            Console.WriteLine(pr1.Agirlik);
            Console.WriteLine(pr1.Fiyat);
            
            Console.Read();
        }
    }
}
