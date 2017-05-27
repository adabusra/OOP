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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calisanlar personelform = new Calisanlar();

        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //Arkadaşlar nesne lazım olmasa bile üretelim. Büyük çamplı projelerde ilerleyen süreçlerde gerekli olma ihtimali yüksektir. Önemli olan projelerimizin ne kadar hızlı bir şekilde güncellenebileceği önemlidir. DEğiştirmek istediğimizde ne kadar esnek olabilmesidir. OOP burada devreye girmektedir.
            Personel prs = new Personel(textBox1.Text, textBox2.Text); // nesne ürettik.
            //prs.Adi = textBox1.Text;
            //prs.Soyadi = textBox2.Text;
            prs.SicilNo = textBox3.Text;
            prs.Maas = numericUpDown1.Value;

            personelform.PersonelEkle(prs);


            textBox1.Text = textBox2.Text = textBox3.Text = "";
            numericUpDown1.Value = 0;
            textBox1.Focus();
        }
        void PersonelAl( Personel yenikisi)
        { 
            //Personel alımı ile alakalı metotdur.
            //veritabanına kayıt yapan kodlar burada yer alacakıtr.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personelform.Show();
        }
    }
}
