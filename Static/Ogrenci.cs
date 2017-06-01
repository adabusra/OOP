using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Ogrenci
    {

        public Ogrenci()
        {
            //Kaç tane öğrenci tanımlandığını bulmak için kullanılır. Her öğrenci oluşturduğu an constractur dır.
            TanimliOgrenciSayisi++;
        }

        public static int TanimliOgrenciSayisi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string TCKN { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }

        public static void YoklamaAl()
        {
            //metot içinden instance öğeler(adi soyadi ulaılamaz. sadece static elemanlara ulaşabilir. Çünkü bu metot çalıştığında hiç bir örnek oluşturmamış olabilir. ve bu örnek hiçbir örneğe bağlı olarak çalışmayacaktır.)
        }

    }
}
