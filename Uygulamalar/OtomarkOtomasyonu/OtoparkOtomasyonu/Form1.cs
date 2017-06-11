using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomarkOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            arac.Plaka = txtPlaka.Text;
            arac.Tip = (AracTip)lstAracTip.SelectedItem;
            arac.Kontak = chkKontak.Checked;
            arac.Abone = chkAbone.Checked;
            lstAraclar.Items.Add(arac);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstAracTip.Items.Add(new AracTip { Adi = "Otomabil(1)", Fiyat = 1 });
            lstAracTip.Items.Add(new AracTip { Adi = "Minübüs(2)", Fiyat = 2 });
            lstAracTip.Items.Add(new AracTip { Adi = "Otobüs(3)", Fiyat = 4 });
            lstAracTip.Items.Add(new AracTip { Adi = "Kamyon(4)", Fiyat = 4 });
            lstAracTip.Items.Add(new AracTip { Adi = "Tır(5)", Fiyat = 8 });
        }
        
        List<Arac> CikisYapanlar = new List<Arac>();



        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null)
                return;
            Arac secili = (Arac)lstAraclar.SelectedItem;
            secili.Cikis = DateTime.Now;
            lblPlaka.Text = secili.Plaka;
            lblSure.Text = secili.Sure.ToString();
            lblUcret.Text = secili.Ucret.ToString("C2");

        }

        List<string> metinler = new List<string>();

        private void Cikisyap_Click(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null)
                return;
            Arac secili = (Arac)lstAraclar.SelectedItem;
            CikisYapanlar.Add(secili);
            lstAraclar.Items.Remove(secili);
        }

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            Rapor form = new Rapor();
            decimal total = 0;
            foreach(Arac item in CikisYapanlar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Plaka;
                li.SubItems.Add(item.Tip.Adi);
                li.SubItems.Add(item.Abone ? "Abone" : "Değil");
                li.SubItems.Add(item.Sure.ToString());
                li.SubItems.Add(item.Ucret.ToString("C2"));
                
                form.listView1.Items.Add(li);
                total += item.Ucret;
            }
            form.lblToplamUcret.Text = total.ToString("C2");
            form.lblToplamArac.Text = CikisYapanlar.Count.ToString();
            form.Show();
        }
    }
}
