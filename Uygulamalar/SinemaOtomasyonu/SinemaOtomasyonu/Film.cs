using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    class Film
    {
        public Film()
        {
            Seanslar = new List<Seans>();
        }

        //static elemanlar instance üretilmeden kullanılan alanlardır.
        private static List<Film> filmler = new List<Film>();

        public List<Film> Filmler
        {
            get { return filmler; }
            set { filmler = value; }
        }

        public string Adi { get; set; }

        public string Tur { get; set; }

        public TimeSpan Sure { get; set; }

        public string Acilama { get; set; }

        public List<Seans> Seanslar { get; set; }

    }
}
