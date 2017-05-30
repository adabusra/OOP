using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Alaaddin";
            ogr.Soyadi = "Ozdemir";
            ogr.Alani = ALan.Dil;
            Ders d = new Ders { Adi = "matatik", Vize = 60, Final = 80 };
            Ders d2 = new Ders { Adi = "fen", Vize = 60, Final = 80 };

            ogr.Dersler.Add(d);
            ogr.Dersler.Add(d2);
            int durum = (int)ogr.Durum;
            //enumlar int e cast edilebilir.
            OgrenciDurum drm = (OgrenciDurum)100;
            //int ler enumlara castedilebilir.
            switch (ogr.Durum)
            {
                case OgrenciDurum.Gecti:
                    MessageBox.Show("Geçtiniz.");
                    break;
                case OgrenciDurum.SartliGecti:
                    MessageBox.Show("Şimdilik geçtiniz");
                    break;
                case OgrenciDurum.Devamsiz:
                    MessageBox.Show("Kaldınız");
                    break;
                case OgrenciDurum.Kaldi:
                    MessageBox.Show("Kaldınız");
                    break;
                case OgrenciDurum.SinifEkle:
                    break;
                default:
                    break;
            }
        }
    }
}
