namespace OtomarkOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lstAracTip = new System.Windows.Forms.ListBox();
            this.aractipi = new System.Windows.Forms.Label();
            this.chkKontak = new System.Windows.Forms.CheckBox();
            this.chkAbone = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.plaka = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.ucret = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnGunlukRapor = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chkAbone);
            this.groupBox1.Controls.Add(this.chkKontak);
            this.groupBox1.Controls.Add(this.aractipi);
            this.groupBox1.Controls.Add(this.lstAracTip);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giris";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(74, 19);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(153, 20);
            this.txtPlaka.TabIndex = 1;
            // 
            // lstAracTip
            // 
            this.lstAracTip.FormattingEnabled = true;
            this.lstAracTip.Location = new System.Drawing.Point(74, 56);
            this.lstAracTip.Name = "lstAracTip";
            this.lstAracTip.Size = new System.Drawing.Size(153, 95);
            this.lstAracTip.TabIndex = 4;
            // 
            // aractipi
            // 
            this.aractipi.AutoSize = true;
            this.aractipi.Location = new System.Drawing.Point(6, 56);
            this.aractipi.Name = "aractipi";
            this.aractipi.Size = new System.Drawing.Size(49, 13);
            this.aractipi.TabIndex = 5;
            this.aractipi.Text = "Araç Tipi";
            // 
            // chkKontak
            // 
            this.chkKontak.AutoSize = true;
            this.chkKontak.Location = new System.Drawing.Point(74, 157);
            this.chkKontak.Name = "chkKontak";
            this.chkKontak.Size = new System.Drawing.Size(79, 17);
            this.chkKontak.TabIndex = 6;
            this.chkKontak.Text = "Kontak Var";
            this.chkKontak.UseVisualStyleBackColor = true;
            // 
            // chkAbone
            // 
            this.chkAbone.AutoSize = true;
            this.chkAbone.Location = new System.Drawing.Point(170, 157);
            this.chkAbone.Name = "chkAbone";
            this.chkAbone.Size = new System.Drawing.Size(57, 17);
            this.chkAbone.TabIndex = 7;
            this.chkAbone.Text = "Abone";
            this.chkAbone.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(152, 195);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAraclar);
            this.groupBox2.Location = new System.Drawing.Point(396, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 366);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İçerdeki Araçlar";
            // 
            // lstAraclar
            // 
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.Location = new System.Drawing.Point(25, 33);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(253, 277);
            this.lstAraclar.TabIndex = 0;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGunlukRapor);
            this.groupBox3.Controls.Add(this.lblUcret);
            this.groupBox3.Controls.Add(this.lblSure);
            this.groupBox3.Controls.Add(this.lblPlaka);
            this.groupBox3.Controls.Add(this.ucret);
            this.groupBox3.Controls.Add(this.sure);
            this.groupBox3.Controls.Add(this.plaka);
            this.groupBox3.Location = new System.Drawing.Point(21, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 167);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // plaka
            // 
            this.plaka.AutoSize = true;
            this.plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.plaka.Location = new System.Drawing.Point(6, 32);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(55, 22);
            this.plaka.TabIndex = 11;
            this.plaka.Text = "Plaka";
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.sure.Location = new System.Drawing.Point(6, 60);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(48, 22);
            this.sure.TabIndex = 12;
            this.sure.Text = "Süre";
            // 
            // ucret
            // 
            this.ucret.AutoSize = true;
            this.ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ucret.Location = new System.Drawing.Point(6, 88);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(53, 22);
            this.ucret.TabIndex = 13;
            this.ucret.Text = "Ücret";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblPlaka.Location = new System.Drawing.Point(101, 32);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(104, 22);
            this.lblPlaka.TabIndex = 14;
            this.lblPlaka.Text = "00 XX 0000";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSure.Location = new System.Drawing.Point(105, 60);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(62, 22);
            this.lblSure.TabIndex = 15;
            this.lblSure.Text = "0 Saat";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblUcret.Location = new System.Drawing.Point(105, 88);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(47, 22);
            this.lblUcret.TabIndex = 16;
            this.lblUcret.Text = "0 TL";
            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.Location = new System.Drawing.Point(6, 126);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(221, 23);
            this.btnGunlukRapor.TabIndex = 9;
            this.btnGunlukRapor.Text = "Günlük Satış Raporu";
            this.btnGunlukRapor.UseVisualStyleBackColor = true;
            this.btnGunlukRapor.Click += new System.EventHandler(this.btnGunlukRapor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip1.Click += new System.EventHandler(this.Cikisyap_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkAbone;
        private System.Windows.Forms.CheckBox chkKontak;
        private System.Windows.Forms.Label aractipi;
        private System.Windows.Forms.ListBox lstAracTip;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ucret;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label plaka;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}

