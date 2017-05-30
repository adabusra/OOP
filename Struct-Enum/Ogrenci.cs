using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        //Generic list. Dizi gibi ama diziden daha esnek.
        public List<Ders> Dersler { get; set; }
        public ALan Alani { get; set; }
        public decimal Ortalama
        {
            get
            {

            }
        }
        
        public OgrenciDurum Durum
        {
            get
            {
                if (Ortalama >= 70)
                    return OgrenciDurum.Gecti;
                else if (Ortalama >= 50)
                    return OgrenciDurum.SartliGecti;
                else
                    return OgrenciDurum.Kaldi;
            }
        }


    }
    // struct lar parametresiz constractır barındıramaz.
    struct Ders
    {
        
        public Ders(string adi, decimal vize, decimal final)
        {
            Adi = adi;
            Vize = vize;
            Final = final;
        }
        public string Adi { get; set; }
        public decimal Vize { get; set; }
        public decimal Final { get; set; }
        public decimal Ortalama
        {
            get
            {
                return Vize * 0.4m + Final * 0.6m;
            }
        }
    }
    enum OgrenciDurum
    {
        Gecti=100,
        SartliGecti=70,
        Devamsiz,
        Kaldi,
        SinifEkle
    }
    enum ALan
    {
        Sayısal,
        Sözel,
        EşitAgirlik,
        Dil
    }

}
