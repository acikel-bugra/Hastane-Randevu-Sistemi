namespace HastahaneRandevuSistemi
{
    partial class BashekimForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoktorEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdKaydet = new System.Windows.Forms.SaveFileDialog();
            this.disaAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iceAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdAc = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.istatistikToolStripMenuItem,
            this.sistemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoktorEditToolStripMenuItem});
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doktorToolStripMenuItem.Text = "Doktor";
            // 
            // DoktorEditToolStripMenuItem
            // 
            this.DoktorEditToolStripMenuItem.Name = "DoktorEditToolStripMenuItem";
            this.DoktorEditToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.DoktorEditToolStripMenuItem.Text = "Doktor Edit";
            this.DoktorEditToolStripMenuItem.Click += new System.EventHandler(this.DoktorEditToolStripMenuItem_Click);
            // 
         
            // istatistikToolStripMenuItem
            // 
            this.istatistikToolStripMenuItem.Name = "istatistikToolStripMenuItem";
            this.istatistikToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.istatistikToolStripMenuItem.Text = "İstatistik";
            this.istatistikToolStripMenuItem.Click += new System.EventHandler(this.istatistikToolStripMenuItem_Click);
            // 
            // sistemToolStripMenuItem
            // 
            this.sistemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.disaAktarToolStripMenuItem,
            this.iceAktarToolStripMenuItem});
            this.sistemToolStripMenuItem.Name = "sistemToolStripMenuItem";
            this.sistemToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sistemToolStripMenuItem.Text = "Sistem";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // disaAktarToolStripMenuItem
            // 
            this.disaAktarToolStripMenuItem.Name = "disaAktarToolStripMenuItem";
            this.disaAktarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disaAktarToolStripMenuItem.Text = "Dışa Aktar";
            this.disaAktarToolStripMenuItem.Click += new System.EventHandler(this.disaAktarToolStripMenuItem_Click);
            // 
            // iceAktarToolStripMenuItem
            // 
            this.iceAktarToolStripMenuItem.Name = "iceAktarToolStripMenuItem";
            this.iceAktarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iceAktarToolStripMenuItem.Text = "İçe Aktar";
            this.iceAktarToolStripMenuItem.Click += new System.EventHandler(this.iceAktarToolStripMenuItem_Click);
            // 
            // ofdAc
            // 
            this.ofdAc.FileName = "openFileDialog1";
            // 
            // BashekimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BashekimForm";
            this.Text = "BasHekim";
            this.Load += new System.EventHandler(this.BasHekim_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoktorEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdKaydet;
        private System.Windows.Forms.ToolStripMenuItem disaAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iceAktarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdAc;
    }
}