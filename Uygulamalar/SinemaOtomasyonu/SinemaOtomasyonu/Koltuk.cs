using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    class Koltuk : Button
    {
        public int  Numara { get; set; }
        public string Sira { get; set; }
        public Bilet Bilet { get; set; }
        public KoltukDurum Durum { get; set; }
    }


    enum KoltukDurum
    {
        Bos,
        Satildi,
        Rezerve,
        Kapali
    }
}