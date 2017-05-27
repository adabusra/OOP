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
        /*
        -Constructer -> Yapıcı metotdur Ram de nesneyi üreten bir metotdur.
        Geriye dönüş tipi olmayan tek metottur.
        -Tanımlanmazsa varsayılan olarak default constructer geçerlidir(parametre almayan new Personel() metodu)
        -Tanımlanırsa default iptal olur. Tanımlı olan geçerlidir.
        -Overload yapılabilir.(Aşırı yüklenme bir metodun birden fazla yüklenmesi)
        -class oluşurken bizimde yapmak istediğimiz işlemler ver ise onları yapmak için kullnabiliriz. Sınıfın tanımlanması sırasında parametre alrak tek satıda oluşmasını sağlayabiliriz.
        */
         
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
        
        public Personel() //bir constructer'dır.
        {
            IseGirisTarihi = DateTime.Now;
            // tarihi varsayılan olarak ayarlı gelmesini sağladık.
            Adi = "İsim girilmedi.";
            Soyadi = "Soyadi Girilmedi";
            TCKimlik = "Girilmedi";
            SicilNo = "Girilmedi";
        }
        public Personel (string adi, string soyadi) // parametreli constructer
        {
            IseGirisTarihi = DateTime.Now;
            Adi = adi;
            Soyadi = soyadi;
        }
        //Ramden silinmeden önce yapılması gereken işlemlere desructer da tanımlanır

        ~Personel() // Destructer -Sonsöz
        {
            System.Windows.Forms.MessageBox.Show("Bayyy");
        }

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
