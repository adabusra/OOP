using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{ 
    class Insan
    {
        public string TCKN { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        //ovveride içeriğini değiştirmek. metodun içeriğini değiştirmektir.
        //virtual değiştirilebilir durumunu değiştirmektir.
        public override void deneme()
        {

        }

    }
}
