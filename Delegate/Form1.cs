using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public delegate void MesajVerHandler(string mesaj);
    public delegate void SayHandler();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void KutudaMesajVer(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        void LabeldaMesajVer(string msg)
        {
            label1.Text = msg;
        }
        void TextBoxdaMesajVer(string msg)
        {
            textBox1.Text = msg;
        }

        void CaptiondaMesajVer(string msg)
        {
            this.Text = msg;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MesajVerHandler mesajverici = new MesajVerHandler(KutudaMesajVer);
            mesajverici += LabeldaMesajVer;
            mesajverici += TextBoxdaMesajVer;
            mesajverici += CaptiondaMesajVer;

            mesajverici.Invoke("Merhaba Dünya");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void Sayici1()
        {
            for(int i=0; i<=1000000; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        void Sayici2()
        {
            for (int i = 0; i <= 1000000; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        void takipci1(IAsyncResult sonuc)
        {
            SayHandler saydirici = (SayHandler)sonuc.AsyncState;
            saydirici.EndInvoke(sonuc);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SayHandler saydirici = new SayHandler(Sayici1);
            AsyncCallback callback = new AsyncCallback(takipci1);
            saydirici.BeginInvoke(callback, saydirici);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SayHandler saydirici2 = Sayici2;
            saydirici2.BeginInvoke(takipci1, saydirici2);
        }
    }
}
