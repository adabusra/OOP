using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {

        }
        Personel[] personeller = new Personel[100];
        int sayac = 0;
        public void PersonelEkle(Personel yp)
        {
            personeller[sayac] = yp;
            listBox1.Items.Add(yp.Adi + " " + yp.Soyadi);
            sayac++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return; // seçili değilse çık

            Personel kovulacak = personeller[listBox1.SelectedIndex];
            kovulacak.IstenCikar();
        }
    }
}
