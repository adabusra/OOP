using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Ogretmen :Memur
    {
        //Ctrl+Shift+A -> Class eklemenin kısayolu
        public string Brans  { get; set; }
        public string Sinif { get; set; }
        public int HaftalikDersSaati { get; set; }
    }
}
