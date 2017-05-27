using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Ogrenci
    {
        /*
        set değişkeni alıp atayan 
        get değeri elde edip dışarı alan elemandır. 
        */

        //encapsulatin field a değer atarken kontollü olabilmemizi sağlar. Değer atama esnasında işlem yapabilmemize sağlar.
        //Auto Prperty -> field içinde olan property dir. Faydası tekrar filed oluşturmayız. Böylelikle iled kalabalığı oluşmamış olur. Property field ını kendi içinde oluşturur(backing ield)
        //auto prperty içerisindeki get ve set komutların içinde komut olamaz. Olursa auto property bozulur. Get veya set silinmez silinirse auto property bozulur.
        private string adi; //değer sadece field tutar

        public string Adi
        {
            get { return adi; }
            set
            {
                if (value == "Cenk") throw new Exception("Cenk değeri kabul edilemez. Lütfen tekrar deneyiniz.");

                adi = value;
            }// dışarıdan gönderile değer value ile gelir.
        }
        public string Soyadi { get; set; } //auto proerty

        private DateTime dogumtarihi;

        public DateTime DogumTarihi
        {
            get { return dogumtarihi; }
            set
            {
                if (value <= DateTime.Now)
                {
                    dogumtarihi = value;
                }
                else
                {
                    dogumtarihi = DateTime.Now;
                }

                dogumtarihi = value;
            }
        }

        public int Yas
        {
            get
            {
                //timespan zamansal büyüklük
                return (int)((DateTime.Now - DogumTarihi).TotalDays / 365);
            }
        }

        public double Vize
        {
            get
            {
                return vize;
            }

            set
            {
                //value dışardan gönderilen değer
                if (value >= 0 && value <= 100)

                    vize = value;
            }
        }

        public double Final
        {
            get
            {
                return final;
            }

            set
            {
                if (value >= 0 && value <= 100)
                    final = value;
            }
        }

        public double Ortalama1
        {
            get
            {
                return Vize *0.4 + Final *0.6;
            }

            set
            {
                Ortalama = value;
            }
        }

        double vize;
        double final;
        double Ortalama;



        // değişken üerine gelip Ctrl + R + E otomatik property oluşturur.

        //public void setAdi(string value)
        //{
        //    //Değer atama ve alma anında güvenlik işlemlerin yapmalıyız.
        //    if (value == "a")
        //        throw new Exception("a kabul edilemez");
        //    adi = value; 
        //}

        //public string getAdi()
        //{
        //    return adi;
        //}
    }
}
