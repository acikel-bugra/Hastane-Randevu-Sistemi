namespace HastahaneRandevuSistemi
{
    partial class DoktorEkranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorEkranForm));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHastaCagir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTariheGoreListe = new System.Windows.Forms.Button();
            this.lstHastaRandevu = new System.Windows.Forms.ListView();
            this.columnIsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevu_tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevu_saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "40px-Liste_svg.png");
            this.ımageList1.Images.SetKeyName(1, "add.png");
            this.ımageList1.Images.SetKeyName(2, "hhh.jpg");
            // 
            // btnHastaCagir
            // 
            this.btnHastaCagir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaCagir.Location = new System.Drawing.Point(50, 315);
            this.btnHastaCagir.Name = "btnHastaCagir";
            this.btnHastaCagir.Size = new System.Drawing.Size(91, 66);
            this.btnHastaCagir.TabIndex = 125;
            this.btnHastaCagir.Text = "Hastayı Çağır";
            this.btnHastaCagir.UseVisualStyleBackColor = true;
            this.btnHastaCagir.Click += new System.EventHandler(this.btnHastaCagir_Click_1);
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKapat.ImageKey = "hhh.jpg";
            this.btnKapat.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(387, 315);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 66);
            this.btnKapat.TabIndex = 130;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 131;
            this.label1.Text = "Bugünün Hasta Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(47, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Muayene işlemi için listeden hasta bilgileri üzerine çift tıklayınız.";
            // 
            // btnTariheGoreListe
            // 
            this.btnTariheGoreListe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTariheGoreListe.ImageIndex = 0;
            this.btnTariheGoreListe.ImageList = this.ımageList1;
            this.btnTariheGoreListe.Location = new System.Drawing.Point(213, 315);
            this.btnTariheGoreListe.Name = "btnTariheGoreListe";
            this.btnTariheGoreListe.Size = new System.Drawing.Size(92, 66);
            this.btnTariheGoreListe.TabIndex = 133;
            this.btnTariheGoreListe.Text = "Hastaları Göster";
            this.btnTariheGoreListe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTariheGoreListe.UseVisualStyleBackColor = true;
            this.btnTariheGoreListe.Click += new System.EventHandler(this.btnTariheGoreListe_Click);
            // 
            // lstHastaRandevu
            // 
            this.lstHastaRandevu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIsim,
            this.randevu_tarih,
            this.randevu_saat});
            this.lstHastaRandevu.FullRowSelect = true;
            this.lstHastaRandevu.GridLines = true;
            this.lstHastaRandevu.Location = new System.Drawing.Point(50, 63);
            this.lstHastaRandevu.Name = "lstHastaRandevu";
            this.lstHastaRandevu.Size = new System.Drawing.Size(437, 205);
            this.lstHastaRandevu.TabIndex = 134;
            this.lstHastaRandevu.UseCompatibleStateImageBehavior = false;
            this.lstHastaRandevu.View = System.Windows.Forms.View.Details;
            // 
            // columnIsim
            // 
            this.columnIsim.Text = "Ad";
            this.columnIsim.Width = 150;
            // 
            // randevu_tarih
            // 
            this.randevu_tarih.Text = "Randevu Tarihi";
            this.randevu_tarih.Width = 150;
            // 
            // randevu_saat
            // 
            this.randevu_saat.Text = "Randevu Saati";
            this.randevu_saat.Width = 150;
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "dosyaAc";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.btnHastaCagir_Click_1);
            // 
            // DoktorEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HastahaneRandevuSistemi.Properties.Resources.nef;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 424);
            this.Controls.Add(this.lstHastaRandevu);
            this.Controls.Add(this.btnTariheGoreListe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnHastaCagir);
            this.Name = "DoktorEkranForm";
            this.Text = "Hasta Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHastaCagir;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTariheGoreListe;
        private System.Windows.Forms.ListView lstHastaRandevu;
        private System.Windows.Forms.ColumnHeader randevu_tarih;
        private System.Windows.Forms.ColumnHeader randevu_saat;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.ColumnHeader columnIsim;
        private System.Windows.Forms.Timer timer1;
    }
}