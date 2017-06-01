using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //Miras alınacak sınıf
    //Abstract alınan sınıf intance alınamaz.
    public abstract class Cari
    {
        public abstract string CarKodu { get; set; }
        public string Unvan { get; set; }

        //burada değil miras alındığı ksımda dolsun diye abstract yapılır.
        public abstract string[] getBanks();
        public decimal getKDV()
        {
            return 0.18m;
        }
    }

    public class CariMusteri : Cari
    {
        private string cariKod;
        public override string CarKodu
        {
            get
            {
                return cariKod;
            }

            set
            {
                cariKod = value;
            }
        }

        public override string[] getBanks()
        {
            return new string[] { "işbankası", "ziraatbankası" };
        }
    }

    public class CariTedarikci : Cari
    {
        string cariKodu;
        public override string CarKodu
        {
            get
            {
                return cariKodu;
            }

            set
            {
                cariKodu = value;
            }
        }

        public override string[] getBanks()
        {
            throw new NotImplementedException();
        }
    }
}
