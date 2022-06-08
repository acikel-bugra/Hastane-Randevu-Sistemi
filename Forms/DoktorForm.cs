using HastahaneRandevuSistemi.Classes;
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
using static HastahaneRandevuSistemi.Classes.RandevuBilgileri;
using static HastahaneRandevuSistemi.Person;

namespace HastahaneRandevuSistemi
{
    public partial class frmDoktor : Form
    {
        public frmDoktor()
        {
            InitializeComponent();
        }
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();

        List<Doktor> eskiListe = new List<Doktor>();
        //string path = Application.StartupPath + "\\Doktor.xml";


        private void frmDoktor_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Doktor.Branslar)));
           
        }

    
        Doktor seciliDoktor;
       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {            
                

                Doktor yeniDoktor = new Doktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Cinsiyetler = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpDogumTarihi.Value,
                    TCKN = txtTCKN.Text,
                    Maas = Convert.ToDecimal(nudMaas.Text),
                    Brans = (Doktor.Branslar)Enum.Parse(typeof(Doktor.Branslar), cmbBrans.SelectedItem.ToString()),
                };
               
                Doktorlar.Add(yeniDoktor);
                MessageBox.Show("İşlem Başarılı");
                
               
           

           
        
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbDoktorListe.SelectedItem == null)
            {
                MessageBox.Show("Silinecek Öge Yok ! "); return;
            }
            seciliDoktor = lbDoktorListe.SelectedItem as Doktor;

            DialogResult cevap = MessageBox.Show($"{seciliDoktor.Ad} adlı kişiyi silmek istiyor musunuz", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                Doktorlar.Remove(seciliDoktor);
             
                MessageBox.Show($"{seciliDoktor.Ad} adlı kişi silindi");
               
                seciliDoktor = null;
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

            if (seciliDoktor == null)
            {
                MessageBox.Show(" Lütfen Güncellenecek Personeli Seçiniz ! ");
                return;
            }
            seciliDoktor = Doktorlar.Where(item => item.TCKN == seciliDoktor.TCKN).FirstOrDefault();
            seciliDoktor.Ad = txtAd.Text;
            seciliDoktor.Soyad = txtSoyad.Text;
            seciliDoktor.TCKN = txtTCKN.Text;
            seciliDoktor.DogumTarihi = dtpDogumTarihi.Value;
            seciliDoktor.Cinsiyetler = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString());
        
            seciliDoktor = null;
           
            MessageBox.Show(" Güncelleme Başarılı ! ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Doktor> aranacak = Arama<Doktor>.Ara(Doktorlar, txtArama.Text);
            ListeyiDoldur(aranacak);
        }

        private void ListeyiDoldur(List<Doktor> aranacakListesi)
        {
            lbDoktorListe.Items.Clear();
            foreach (Doktor item in aranacakListesi)
            {
                lbDoktorListe.Items.Add(item);
            }
        }

        private void lbDoktorListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDoktorListe.SelectedIndex == -1) return;
            seciliDoktor = lbDoktorListe.SelectedItem as Doktor;
            txtAd.Text = seciliDoktor.Ad;
            txtSoyad.Text = seciliDoktor.Soyad;
            txtTCKN.Text = seciliDoktor.TCKN;
            dtpDogumTarihi.Value = seciliDoktor.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliDoktor.Cinsiyetler;
            nudMaas.Text = seciliDoktor.Maas.ToString();
            cmbBrans.SelectedIndex = (int)seciliDoktor.Brans;
           
        }
        private void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
            }

        }

       
    }
}