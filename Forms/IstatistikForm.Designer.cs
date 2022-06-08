namespace HastahaneRandevuSistemi.Forms
{
    partial class IstatistikForm
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
            this.lstPersonellerimiz = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstdoktorlarımız = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHemsirelerimiz = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldoktorsayisi = new System.Windows.Forms.Label();
            this.lblHemsireSayisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPersonelSayisi = new System.Windows.Forms.Label();
            this.lblperson = new System.Windows.Forms.Label();
            this.lblToplamCalisanSayisi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPersonellerimiz
            // 
            this.lstPersonellerimiz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPersonellerimiz.Location = new System.Drawing.Point(49, 511);
            this.lstPersonellerimiz.Name = "lstPersonellerimiz";
            this.lstPersonellerimiz.Scrollable = false;
            this.lstPersonellerimiz.Size = new System.Drawing.Size(350, 183);
            this.lstPersonellerimiz.TabIndex = 0;
            this.lstPersonellerimiz.UseCompatibleStateImageBehavior = false;
            this.lstPersonellerimiz.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Görevi";
            this.columnHeader2.Width = 232;
            // 
            // lstdoktorlarımız
            // 
            this.lstdoktorlarımız.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lstdoktorlarımız.Location = new System.Drawing.Point(49, 38);
            this.lstdoktorlarımız.Name = "lstdoktorlarımız";
            this.lstdoktorlarımız.Scrollable = false;
            this.lstdoktorlarımız.Size = new System.Drawing.Size(350, 183);
            this.lstdoktorlarımız.TabIndex = 2;
            this.lstdoktorlarımız.UseCompatibleStateImageBehavior = false;
            this.lstdoktorlarımız.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adı";
            this.columnHeader5.Width = 175;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Branşı";
            this.columnHeader6.Width = 232;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doktorlarımız ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hemşirelerimiz";
            // 
            // lstHemsirelerimiz
            // 
            this.lstHemsirelerimiz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstHemsirelerimiz.Location = new System.Drawing.Point(49, 273);
            this.lstHemsirelerimiz.Name = "lstHemsirelerimiz";
            this.lstHemsirelerimiz.Scrollable = false;
            this.lstHemsirelerimiz.Size = new System.Drawing.Size(350, 183);
            this.lstHemsirelerimiz.TabIndex = 5;
            this.lstHemsirelerimiz.UseCompatibleStateImageBehavior = false;
            this.lstHemsirelerimiz.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı";
            this.columnHeader3.Width = 175;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Branşı";
            this.columnHeader4.Width = 232;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personellerimiz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam :";
            // 
            // lbldoktorsayisi
            // 
            this.lbldoktorsayisi.AutoSize = true;
            this.lbldoktorsayisi.Location = new System.Drawing.Point(343, 13);
            this.lbldoktorsayisi.Name = "lbldoktorsayisi";
            this.lbldoktorsayisi.Size = new System.Drawing.Size(0, 13);
            this.lbldoktorsayisi.TabIndex = 8;
            // 
            // lblHemsireSayisi
            // 
            this.lblHemsireSayisi.AutoSize = true;
            this.lblHemsireSayisi.Location = new System.Drawing.Point(346, 246);
            this.lblHemsireSayisi.Name = "lblHemsireSayisi";
            this.lblHemsireSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblHemsireSayisi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(287, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Toplam :";
            // 
            // lblPersonelSayisi
            // 
            this.lblPersonelSayisi.AutoSize = true;
            this.lblPersonelSayisi.Location = new System.Drawing.Point(346, 486);
            this.lblPersonelSayisi.Name = "lblPersonelSayisi";
            this.lblPersonelSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblPersonelSayisi.TabIndex = 12;
            // 
            // lblperson
            // 
            this.lblperson.AutoSize = true;
            this.lblperson.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblperson.Location = new System.Drawing.Point(287, 484);
            this.lblperson.Name = "lblperson";
            this.lblperson.Size = new System.Drawing.Size(53, 15);
            this.lblperson.TabIndex = 11;
            this.lblperson.Text = "Toplam :";
            // 
            // lblToplamCalisanSayisi
            // 
            this.lblToplamCalisanSayisi.AutoSize = true;
            this.lblToplamCalisanSayisi.Location = new System.Drawing.Point(197, 725);
            this.lblToplamCalisanSayisi.Name = "lblToplamCalisanSayisi";
            this.lblToplamCalisanSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblToplamCalisanSayisi.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(46, 723);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Toplam Çalışan Sayımız :";
            // 
            // IstatistikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(450, 750);
            this.Controls.Add(this.lblToplamCalisanSayisi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPersonelSayisi);
            this.Controls.Add(this.lblperson);
            this.Controls.Add(this.lblHemsireSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldoktorsayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHemsirelerimiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstdoktorlarımız);
            this.Controls.Add(this.lstPersonellerimiz);
            this.Name = "IstatistikForm";
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.PersonellerimizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPersonellerimiz;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstdoktorlarımız;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstHemsirelerimiz;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldoktorsayisi;
        private System.Windows.Forms.Label lblHemsireSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPersonelSayisi;
        private System.Windows.Forms.Label lblperson;
        private System.Windows.Forms.Label lblToplamCalisanSayisi;
        private System.Windows.Forms.Label label11;
    }
}