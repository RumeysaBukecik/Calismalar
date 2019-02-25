using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeFilm
{
        public class Film
        {
            public int FilmID { get; set; }
            public string FilmAd { get; set; }

        [ForeignKey("FilmYonetmen")]
        public int FilmYonetmenID { get; set; }
        public Yonetmen FilmYonetmen { get; set; }
        public ICollection<Oyuncu> FilmOyunculari { get; set; }

        }
    
}
