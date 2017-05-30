using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    class Ogrenci: Insan
    {
        public decimal Vize { get; set; }
        public decimal Final { get; set; }
        //virtual olan değişkenleri oluşturmaak için kullanılan metoddur.
        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }

    }
}
