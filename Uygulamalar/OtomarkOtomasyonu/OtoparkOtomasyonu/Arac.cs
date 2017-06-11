using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomarkOtomasyonu
{
    class Arac
    {
        public Arac()
        {
            Giris = DateTime.Now;
        }
        public string Plaka { get; set; }
        public AracTip Tip { get; set; } //bir özellik içerisinde birden fazla özellik tutacaksa yeni class tanımlanır.
        public bool Kontak { get; set; }
        public bool Abone { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }

        public int Sure
        {
            get
            {
                //iki süre farkını alır(Time span)
                TimeSpan fark = (Cikis - Giris);
                if(fark-TimeSpan.FromHours(fark.TotalHours)>TimeSpan.Zero)
                {
                   fark = fark.Add(TimeSpan.FromHours(1));
                }
                return (int)fark.TotalHours;
            }
        }

        public decimal Ucret
        {
            get
            {
                decimal toplam = Tip.Fiyat * (Sure-1)+Tip.Fiyat*2;
                if (Abone)
                {
                    toplam *= 0.80m;
                }
                return toplam;
            }
        }

        public override string ToString()
        {
            string metinAbone = Abone ? "Abone" : "Abone Değil";
            string metinKontak = Kontak ? "Kontak Var" : "Kontak Yok";
            return string.Format("{0}-{1}-{2}-{3}", Plaka, Tip.Adi,metinAbone,metinKontak);
        }


    }

    class AracTip
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        //Form load çalıştığında araç tip string olarak gözükmektedir. Adını listemek için ovveride etmek gerekiyor.
        public override string ToString()
        {
            return Adi;
        }
    }
}
