using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFilm
{
    public class Oyuncu
    {
        public int OyuncuID { get; set; }
        public string OyuncuAdSoyad { get; set; }
        public string OyuncuDogumTarihi { get; set; }

        public ICollection<Film> OyuncuFilmleri { get; set; }
    }
}
