using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            Mudur m = new Mudur();
            Ogretmen ogrt = new Ogretmen();

            Insan i = o;
            
            TCKNSorgula(i);
            TCKNSorgula(o);
            TCKNSorgula(ogrt);
            TCKNSorgula(m);
        }
        void TCKNSorgula(Insan i)
        {

        }
    }
}
