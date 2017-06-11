using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{

    class Koltuk : Button
    {
        public Koltuk()//default constructer, parametre almadan direk çalışsan constructer
        {
            KoltukTanimla();
        }

        public Koltuk(int boyut) //parametre alan constructer
        {
            KoltukTanimla(boyut);
        }
        void KoltukTanimla(int size = 30)
        {
            Boyut = size;
            Width = size;
            Height = size;
            FlatStyle = FlatStyle.Flat;
            Margin = new Padding(0);
            BackgroundImage = new Bitmap(Properties.Resources.yesil, size, size);

        }

        public int Boyut { get; set; }

        public int Numara { get; set; }

        public string Sira { get; set; }

        public Bilet Bilet { get; set; }

        private KoltukDurum koltukdurum;


        public KoltukDurum KoltukDurum
        {
            get { return koltukdurum; }
            set
            {
                switch (value)
                {
                    case KoltukDurum.Bos:
                        BackgroundImage = new Bitmap(Properties.Resources.yesil,
                            Boyut, Boyut);
                        break;
                    case KoltukDurum.Satildi:
                        BackgroundImage = new Bitmap(Properties.Resources.kirmizi, Boyut, Boyut);
                        break;
                    case KoltukDurum.Rezerve:
                        BackgroundImage = new Bitmap(Properties.Resources.kahve, Boyut, Boyut);
                        break;
                    case KoltukDurum.Kapali:
                        BackgroundImage = new Bitmap(Properties.Resources.gri, Boyut, Boyut);
                        break;
                    default:
                        break;
                }

                koltukdurum = value;
            }
        }

       // public KoltukDurum Durum { get; internal set; }
    }


    enum KoltukDurum
    {
        Bos,
        Satildi,
        Rezerve,
        Kapali
    }
}