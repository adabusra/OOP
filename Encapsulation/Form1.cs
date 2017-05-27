using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
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
            try //if kontrolünü direk cacth içine alıp mesajı ekrana bastırabiliriz.
            {
                o.Adi = textBox1.Text;
                o.DogumTarihi = dateTimePicker1.Value;
                //MessageBox.Show(o.Adi);
                MessageBox.Show(o.Yas.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
