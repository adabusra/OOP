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
        public string Adi { get; set; }
        public string Tur { get; set; }
        public TimeSpan Sure { get; set; }
        public string Acilama { get; set; }

        public List<Seans> Seanslar { get; set; }

    }
}
