using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFilm
{
    public class Yonetmen
    {
        public int YonetmenID { get; set; }
        public string YonetmenAdSoyad { get; set; }

        public ICollection<Film> YonetmenFilmleri { get; set; }
    }
}
