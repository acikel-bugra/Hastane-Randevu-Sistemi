namespace HastahaneRandevuSistemi
{
    partial class frmDoktor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            this.lbHemsireListe = new System.Windows.Forms.ListBox();
            this.lbDoktorListe = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(94, 19);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(178, 20);
            this.txtTCKN.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 55);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(178, 20);
            this.txtAd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cinsiyet";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 91);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(178, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(94, 124);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(178, 20);
            this.dtpDogumTarihi.TabIndex = 9;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(94, 163);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(178, 21);
            this.cmbCinsiyet.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Branş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Maaş";
            // 
            // cmbBrans
            // 
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            " "});
            this.cmbBrans.Location = new System.Drawing.Point(94, 199);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(178, 21);
            this.cmbBrans.TabIndex = 13;
           
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 383);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 38);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(106, 383);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 38);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(197, 383);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 38);
            this.btnGüncelle.TabIndex = 17;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(310, 19);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(282, 20);
            this.txtArama.TabIndex = 18;
            this.txtArama.Text = "Arama...";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // nudMaas
            // 
            this.nudMaas.Location = new System.Drawing.Point(94, 236);
            this.nudMaas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(178, 20);
            this.nudMaas.TabIndex = 20;
            // 
            // lbHemsireListe
            // 
            this.lbHemsireListe.FormattingEnabled = true;
            this.lbHemsireListe.Location = new System.Drawing.Point(15, 268);
            this.lbHemsireListe.Name = "lbHemsireListe";
            this.lbHemsireListe.Size = new System.Drawing.Size(257, 95);
            this.lbHemsireListe.TabIndex = 21;
            // 
            // lbDoktorListe
            // 
            this.lbDoktorListe.FormattingEnabled = true;
            this.lbDoktorListe.Location = new System.Drawing.Point(310, 55);
            this.lbDoktorListe.Name = "lbDoktorListe";
            this.lbDoktorListe.Size = new System.Drawing.Size(282, 368);
            this.lbDoktorListe.TabIndex = 22;
            // 
            // frmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 440);
            this.Controls.Add(this.lbDoktorListe);
            this.Controls.Add(this.lbHemsireListe);
            this.Controls.Add(this.nudMaas);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoktor";
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.frmDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.NumericUpDown nudMaas;
        private System.Windows.Forms.ListBox lbHemsireListe;
        private System.Windows.Forms.ListBox lbDoktorListe;
    }
}