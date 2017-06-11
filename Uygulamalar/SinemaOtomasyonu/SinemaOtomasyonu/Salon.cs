using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    class Salon
    {
        public Salon()
        {
            Koltuklar = new List<Koltuk>();
        }

        public string Adi { get; set; }

        public string Sube { get; set; }

        public List<Koltuk> Koltuklar { get; set; }
    }
}
