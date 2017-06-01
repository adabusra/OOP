using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Adi = "murtaza";
            Ogrenci o2 = new Ogrenci();
            o2.Adi = "kadriye";

            //Static tanımlı class ile direk erişim sağlar.
            Ogrenci.YoklamaAl();
            //statci değişken heryerden erişilebilir bir metotdur.
        }
    }
}
