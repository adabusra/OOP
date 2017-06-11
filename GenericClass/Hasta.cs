using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    //Birden fazla  tip çeşidi verebiliyoruz. <Temsili,t2,t3>
    public class Hasta<Temsili,IlacTip> where IlacTip : Ilac
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKN { get; set; }
        public Temsili HastaOzellikleri { get; set; }
        public List<IlacTip> Ilaclar { get; set; }
        //public t2 Raporlar { get; set; }
        //public t3 Tahliller { get; set; }
    }

    public class Ilac
    {
        public string Adi { get; set; }
        public string Marka { get; set; }
        public bool Cigneme { get; set; }

    }

    class AgriKesici : Ilac
    {
        public int Mg { get; set; }
    }

    class GribalEnfeksiyon<Tip>
    {
        public string Adi  { get; set; }
        public string Tur { get; set; }
        public int LD { get; set; }
        public string Antidot { get; set; }

    }
}
