using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Random
    {
        int Next() { return 0; }
        int Next(int max) { return 0; }
        int Next(int min, int max) { return 0; }
    }

    public class Personel { 
        /*Access  Modiiers: Sınıfın içindeki elemanlara nerelerden erişebileceğini belirleyen elemanlara denir. 
          *Private -sadece tanımlandığı sını içinde erişilebilir yapar. Sınıf içinde access modiier yazılmadıysa private kabul edilir.
          *Protected -miras alınan sınılardan erişelebilmeyi sağlar. 
          *internal - bulunduğu  proje içinden erişelebilmeyi sağlar.
          *protected internal -hem miraas alanlar hemde proje içindeki kullanılan yerlerde erişebilir olur. 
          *public -umumi demektir her yerden erişilebilir. Bütün izinleri açar.
        */

        //Bir nesne tasarlandığında default private 'dır.
        //Persone ile ilgili işlemler burada yapılacaktır.
        //Class içinde tanımlanırsa alan field olur. Nesne ile ilgili alanlara field denir.
        //class ile üretilmiş her bir nesnein özelliği olacaktır.
        internal string Adi;
        internal string Soyadi;
        internal string SicilNo;
        internal decimal Maas;
        internal string TCKimlik;
        DateTime IseGirisTarihi;

        void IseAl()
        {
            //veritabanına kayıt yapan kodlar burada yer alacaktır.
        }

        decimal KıdemTazminatiHesapla()
        {
            //hesaplama kodları yer alacaktır.

            return 0;
        }

        public void IstenCikar()
        {
            decimal para = KıdemTazminatiHesapla();
            //veritabanında işten çıkarma ile ilgili işlemler yapılacaktır.
        }

    }
}
