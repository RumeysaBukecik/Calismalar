using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1701Bilgisayarsorusu
{
    class Bilgisayar
    {
        public string Marka;
        public string CPU;
        public int RAM;

        public Bilgisayar(string marka, string cpu, int ram)
        {
            Marka = marka;
            CPU = cpu;
            RAM = ram;
        }
        virtual public void OzellikGoster()
        {
            Console.WriteLine("Marka" +Marka);
            Console.WriteLine("İşlemci" +CPU);
            Console.WriteLine("Ram Kapasitesi" +RAM);
        }
    }

    class DizustuBilgisayar : Bilgisayar
    {
        public bool Bluetooth;

        public DizustuBilgisayar(bool bluetooth, string marka, string cpu, int ram) : base(marka, cpu, ram)
        {
            this.Bluetooth = bluetooth;
        }

        override public void OzellikGoster()
        {
            Console.WriteLine("Marka: " +Marka);
            Console.WriteLine("İşlemci: " +CPU);
            Console.WriteLine("Ram Kapasitesi: " + RAM + "GB");
            Console.WriteLine("Bluetooth: " +Bluetooth);
        }
    }
    class Program
    {
        static void GenelOzellikGoster(Bilgisayar bilgiSayar)
        {
            bilgiSayar.OzellikGoster();                
        }
        
        static void Main(string[] args)
        {
            DizustuBilgisayar dzB = new DizustuBilgisayar(true, "LG", "Intel Core i7", 4);
            GenelOzellikGoster(dzB);
            
            Console.Read();
        }
    }
}
