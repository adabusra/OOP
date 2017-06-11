namespace OtomarkOtomasyonu
{
    partial class Rapor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.lblToplamArac = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.plaka = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 279);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Abone";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sure";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ucret";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamUcret);
            this.groupBox1.Controls.Add(this.lblToplamArac);
            this.groupBox1.Controls.Add(this.sure);
            this.groupBox1.Controls.Add(this.plaka);
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Bilgiler";
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblToplamUcret.Location = new System.Drawing.Point(112, 155);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(47, 22);
            this.lblToplamUcret.TabIndex = 21;
            this.lblToplamUcret.Text = "0 TL";
            this.lblToplamUcret.Click += new System.EventHandler(this.lblToplamUcret_Click);
            // 
            // lblToplamArac
            // 
            this.lblToplamArac.AutoSize = true;
            this.lblToplamArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblToplamArac.Location = new System.Drawing.Point(112, 81);
            this.lblToplamArac.Name = "lblToplamArac";
            this.lblToplamArac.Size = new System.Drawing.Size(20, 22);
            this.lblToplamArac.TabIndex = 20;
            this.lblToplamArac.Text = "0";
            this.lblToplamArac.Click += new System.EventHandler(this.lblToplamArac_Click);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.sure.Location = new System.Drawing.Point(13, 103);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(118, 22);
            this.sure.TabIndex = 18;
            this.sure.Text = "Toplam Ücret";
            // 
            // plaka
            // 
            this.plaka.AutoSize = true;
            this.plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.plaka.Location = new System.Drawing.Point(6, 41);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(112, 22);
            this.plaka.TabIndex = 17;
            this.plaka.Text = "Toplam Araç";
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label plaka;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label lblToplamUcret;
        public System.Windows.Forms.Label lblToplamArac;
    }
}