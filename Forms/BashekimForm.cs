using HastahaneRandevuSistemi.Classes;
using HastahaneRandevuSistemi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HastahaneRandevuSistemi
{
    public partial class BashekimForm : Form
    {
        public BashekimForm()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private void BasHekim_Load(object sender, EventArgs e)
        {
            XmlSerializer xmlHasta = new XmlSerializer(typeof(Context));
            TextReader readerHasta = new StreamReader(Properties.Resources.Context);
            context = xmlHasta.Deserialize(readerHasta) as Context;
            readerHasta.Close();
            readerHasta.Dispose();
        }

        private void DoktorEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            frmDoktor dr = new frmDoktor
            {
                MdiParent = this
            };
            dr = new frmDoktor();
            dr.Doktorlar = context.Doktorlar;
            dr.Show();

            this.LayoutMdi(MdiLayout.TileVertical);
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

     

      

        private void istatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();

            }

            IstatistikForm prsnl = new IstatistikForm
            {
                MdiParent = this
            };
            prsnl.Show();


            this.LayoutMdi(MdiLayout.TileVertical);
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlHasta = new XmlSerializer(typeof(Context));
            sfdKaydet.FileName = Properties.Resources.Context;
            TextWriter writeHasta = new StreamWriter(sfdKaydet.FileName);
            xmlHasta.Serialize(writeHasta, context);
            writeHasta.Close();
            writeHasta.Dispose();
            MessageBox.Show("Bilgiler Başarıyla Kaydedildi", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void disaAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdKaydet.Filter = "XML Format | *.xml";
            sfdKaydet.FileName = string.Empty;
            sfdKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfdKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlContextSerializer = new XmlSerializer(typeof(Context));
                TextWriter writer = new StreamWriter(sfdKaydet.FileName);
                xmlContextSerializer.Serialize(writer, context);
                writer.Close();
                writer.Dispose();
                MessageBox.Show("Veriler Dışarı Aktarıldı.");
            }
        }

        private void iceAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdAc.Filter = "XML Format | *.xml";
            ofdAc.Multiselect = false;
            ofdAc.FileName = string.Empty;
            ofdAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofdAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlContextSerializer = new XmlSerializer(typeof(Context));
                TextReader reader = new StreamReader(ofdAc.FileName);
                context = (Context)xmlContextSerializer.Deserialize(reader);
                reader.Close();
                reader.Dispose();
                MessageBox.Show("Dosya Aktarıldı");
            }
        }
    }
}
