using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GenericClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //array list ile string ve integer yollanabilir.
            ArrayList liste = new ArrayList();

            liste.Add("deneme");
            liste.Add(12345);
            liste.Add(true);
            liste.Add("a");

            //Sınıf oluşturulurken tiplerin dışarıdan verilebilmesini generic mimari ile oluşturabiliriz.Tutacağımız tipi dışarıdan verebiliyoruz.

            Hasta<GribalEnfeksiyon<string>,AgriKesici> hasta = new Hasta<GribalEnfeksiyon<string>,AgriKesici>();
            List<string> metinlistesi = new List<string>();
            List<int> sayilistesi = new List<int>();

            GribalEnfeksiyon<string> enfk = new GribalEnfeksiyon<string>();
            enfk.Adi = "kuş gribi";
            enfk.Antidot = "Adaçayı, Ihlamur";
            enfk.LD = 9;
            hasta.HastaOzellikleri = enfk;




            
        }
    }
}
