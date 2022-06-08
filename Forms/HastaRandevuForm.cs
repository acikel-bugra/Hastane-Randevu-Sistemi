using HastahaneRandevuSistemi;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static HastahaneRandevuSistemi.Classes.Randevu2;
using static HastahaneRandevuSistemi.Classes.RandevuBilgileri;

namespace mhrs
{
    public partial class HastaRandevuForm : Form
    {

        public HastaRandevuForm()
        {
            InitializeComponent();


        }
        public string kullaniciAdi { get; set; }
        public string kullaniciSoyadi { get; set; }

        bool saatDolu_mu = false;

        string path = Application.StartupPath + "\\Accounts.xml";
        string path4 = Application.StartupPath + "\\Hasta.xml";
        string path5 = Application.StartupPath + "\\Randevu.xml";


        List<Hasta> hastalar = new List<Hasta>();
        List<Person> kayitlar = new List<Person>();
        List<Randevu2> eskiListe5 = new List<Randevu2>();

        private void Form1_Load(object sender, EventArgs e)

        {

            cmbPoliklinik.Items.AddRange(Enum.GetNames(typeof(Poliklinik)));
            dateTimePicker1.Value = DateTime.Now;
            txtAd.Text = kullaniciAdi;
            txtSoyad.Text = kullaniciSoyadi;
            
        }



        private void button13_MouseClick(object sender, MouseEventArgs e)  //seçili butonu gri renk yapma
        {

            if ((sender as Button).BackColor == Color.LightSeaGreen)
            {

                button1.BackColor = Color.LightSeaGreen;
                button2.BackColor = Color.LightSeaGreen;
                button3.BackColor = Color.LightSeaGreen;
                button4.BackColor = Color.LightSeaGreen;
                button5.BackColor = Color.LightSeaGreen;
                button6.BackColor = Color.LightSeaGreen;
                button7.BackColor = Color.LightSeaGreen;
                button8.BackColor = Color.LightSeaGreen;
                button9.BackColor = Color.LightSeaGreen;
                button10.BackColor = Color.LightSeaGreen;
                button11.BackColor = Color.LightSeaGreen;
                button12.BackColor = Color.LightSeaGreen;
                button13.BackColor = Color.LightSeaGreen;
                button14.BackColor = Color.LightSeaGreen;
                button15.BackColor = Color.LightSeaGreen;
                button16.BackColor = Color.LightSeaGreen;
                button17.BackColor = Color.LightSeaGreen;
                button18.BackColor = Color.LightSeaGreen;
                button19.BackColor = Color.LightSeaGreen;
                button20.BackColor = Color.LightSeaGreen;
                button21.BackColor = Color.LightSeaGreen;
                button22.BackColor = Color.LightSeaGreen;
                button23.BackColor = Color.LightSeaGreen;
                button24.BackColor = Color.LightSeaGreen;

                (sender as Button).BackColor = Color.Silver;

                txtRandevu.Text = (sender as Button).Text;


            }
            else
            {
                MessageBox.Show("Bu randevu saati alınmış!");
            }
        }

        private void Button26_Click(object sender, EventArgs e)        //temizle butonu
        {
            lstHastaRandevu.Items.Clear();
            cmbPoliklinik.Items.Clear();
            cmbPoliklinik.Items.AddRange(Enum.GetNames(typeof(Poliklinik)));
            cmbHekim.Items.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtRandevu.Text = "";

            button1.BackColor = Color.LightSeaGreen;
            button2.BackColor = Color.LightSeaGreen;
            button3.BackColor = Color.LightSeaGreen;
            button4.BackColor = Color.LightSeaGreen;
            button5.BackColor = Color.LightSeaGreen;
            button6.BackColor = Color.LightSeaGreen;
            button7.BackColor = Color.LightSeaGreen;
            button8.BackColor = Color.LightSeaGreen;
            button9.BackColor = Color.LightSeaGreen;
            button10.BackColor = Color.LightSeaGreen;
            button11.BackColor = Color.LightSeaGreen;
            button12.BackColor = Color.LightSeaGreen;
            button13.BackColor = Color.LightSeaGreen;
            button14.BackColor = Color.LightSeaGreen;
            button15.BackColor = Color.LightSeaGreen;
            button16.BackColor = Color.LightSeaGreen;
            button17.BackColor = Color.LightSeaGreen;
            button18.BackColor = Color.LightSeaGreen;
            button19.BackColor = Color.LightSeaGreen;
            button20.BackColor = Color.LightSeaGreen;
            button21.BackColor = Color.LightSeaGreen;
            button22.BackColor = Color.LightSeaGreen;
            button23.BackColor = Color.LightSeaGreen;
            button24.BackColor = Color.LightSeaGreen;
        }       

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            

            XDocument File = XDocument.Load(path5);

            foreach (var profile in File.Descendants("Randevu2"))
            {
                if (profile.Element("hekimler").Value == cmbHekim.Text && profile.Element("saat").Value == txtRandevu.Text)
                {
                    MessageBox.Show("Seçilen hekime ait bu randevu saati dolu!");
                    saatDolu_mu = true;
                    break;
                }
            }

            if (saatDolu_mu != true)

            {
                DialogResult secenek = MessageBox.Show("Randevunuzu Kaydetmek İster misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    Randevu2 yeniKayit = new Randevu2();

                    yeniKayit.Ad = txtAd.Text;
                    yeniKayit.Soyad = txtSoyad.Text;

                    yeniKayit.poliklinikler = (Poliklinikler)Enum.Parse(typeof(Poliklinikler), cmbPoliklinik.Text);
                    yeniKayit.hekimler = (Hekimler)Enum.Parse(typeof(Hekimler), cmbHekim.Text);

                    yeniKayit.tarih = dateTimePicker1.Value.ToLongDateString();
                    yeniKayit.saat = txtRandevu.Text;


                    ListViewItem kayit = new ListViewItem(txtAd.Text + " " + txtSoyad.Text);
                    kayit.SubItems.Add(cmbPoliklinik.Text);
                    kayit.SubItems.Add(cmbHekim.Text);
                    kayit.SubItems.Add(dateTimePicker1.Value.ToLongDateString());
                    kayit.SubItems.Add(txtRandevu.Text);
                    kayit.Tag = yeniKayit.Id;
                    lstHastaRandevu.Items.Add(kayit);



                    XmlSerializer cevirici = new XmlSerializer(typeof(List<Randevu2>));
                    if (System.IO.File.Exists(path5))
                    {
                        FileStream gelenXML5 = System.IO.File.OpenRead(path5);
                        eskiListe5 = (List<Randevu2>)cevirici.Deserialize(gelenXML5);
                        gelenXML5.Close();
                    }

                    eskiListe5.Add(yeniKayit);
                    FileStream yazici5 = new FileStream(path5, FileMode.Create);
                    cevirici.Serialize(yazici5, eskiListe5);
                    yazici5.Close();

                }

                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Randevunuz Dışarı aktarılmadı");

                }
            }
        }  //randevu alma butonu

        private void btnIptal_Click(object sender, EventArgs e)   //randevu iptal etme butonu
        {

            foreach (ListViewItem item in lstHastaRandevu.SelectedItems)
            {
                item.Remove();


                XDocument File = XDocument.Load(path5);
                
                foreach (var profile in File.Descendants("Randevu2"))
                {
                    if (profile.Element("Id").Value.ToString() == item.Tag.ToString())
                    {
                        profile.Remove();
                        break;
                    }
                }
                File.Save(path5);

            }
            button26.PerformClick();
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)  //polikliniğe göre hekimleri listeleme
        {
            cmbHekim.Items.Clear();
            if (cmbPoliklinik.Text == "BEYİN_VE_SİNİR_CERRAHİSİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(B_Cerrah)));
            else if (cmbPoliklinik.Text == "KALP_DAMAR_CERRAHİSİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Kalp_Damar)));
            else if (cmbPoliklinik.Text == "KARDİYOLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Kardiyoloji)));
            else if (cmbPoliklinik.Text == "KBB")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(KBB)));
            else if (cmbPoliklinik.Text == "NEFROLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Nefroloji)));
            else if (cmbPoliklinik.Text == "NÖROLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Nöroloji)));
            else if (cmbPoliklinik.Text == "DİYABET")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Diyabet)));
            else if (cmbPoliklinik.Text == "ORTOPEDİ_VE_TRAVMATOLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(ORTOPEDİ_VE_TRAVMATOLOJİ)));
        }

        private void cmbHekim_SelectedIndexChanged(object sender, EventArgs e)  //Hekimin randevusu oldugu saatleri gösterme
        {
            
            pnlClocks.Visible = true;

           
            
            XDocument File = XDocument.Load(path5);

            foreach (var profile in File.Descendants("Randevu2"))
            {

                if (profile.Element("hekimler").Value == cmbHekim.Text && profile.Element("tarih").Value == dateTimePicker1.Value.ToLongDateString())
                {
                    if (profile.Element("saat").Value == button1.Text)
                        button1.BackColor = Color.Red;
                    else button1.BackColor = Color.LightSeaGreen;

                    if (profile.Element("saat").Value == button2.Text)
                        button2.BackColor = Color.Red;
                    else button2.BackColor = Color.LightSeaGreen;

                    if (profile.Element("saat").Value == button3.Text)
                        button3.BackColor = Color.Red;
                    else button3.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button4.Text)
                        button4.BackColor = Color.Red;
                    else button4.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button5.Text)
                        button5.BackColor = Color.Red;
                    else button5.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button6.Text)
                        button6.BackColor = Color.Red;
                    else button6.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button7.Text)
                        button7.BackColor = Color.Red;
                    else button7.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button8.Text)
                        button8.BackColor = Color.Red;
                    else button8.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button9.Text)
                        button9.BackColor = Color.Red;
                    else button9.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button10.Text)
                        button10.BackColor = Color.Red;
                    else button10.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button11.Text)
                        button11.BackColor = Color.Red;
                    else button11.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button12.Text)
                        button12.BackColor = Color.Red;
                    else button12.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button13.Text)
                        button13.BackColor = Color.Red;
                    else button13.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button14.Text)
                        button14.BackColor = Color.Red;
                    else button14.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button15.Text)
                        button15.BackColor = Color.Red;
                    else button15.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button16.Text)
                        button16.BackColor = Color.Red;
                    else button16.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button17.Text)
                        button17.BackColor = Color.Red;
                    else button17.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button18.Text)
                        button18.BackColor = Color.Red;
                    else button18.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button19.Text)
                        button19.BackColor = Color.Red;
                    else button19.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button20.Text)
                        button20.BackColor = Color.Red;
                    else button20.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button21.Text)
                        button21.BackColor = Color.Red;
                    else button21.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button22.Text)
                        button22.BackColor = Color.Red;
                    else button22.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button23.Text)
                        button23.BackColor = Color.Red;
                    else button23.BackColor = Color.LightSeaGreen;
                    if (profile.Element("saat").Value == button24.Text)
                        button24.BackColor = Color.Red;
                    else button24.BackColor = Color.LightSeaGreen;

                    break;
                }
               else
                {
                    button1.BackColor = Color.LightSeaGreen;
                    button2.BackColor = Color.LightSeaGreen;
                    button3.BackColor = Color.LightSeaGreen;
                    button4.BackColor = Color.LightSeaGreen;
                    button5.BackColor = Color.LightSeaGreen;
                    button6.BackColor = Color.LightSeaGreen;
                    button7.BackColor = Color.LightSeaGreen;
                    button8.BackColor = Color.LightSeaGreen;
                    button9.BackColor = Color.LightSeaGreen;
                    button10.BackColor = Color.LightSeaGreen;
                    button11.BackColor = Color.LightSeaGreen;
                    button12.BackColor = Color.LightSeaGreen;
                    button13.BackColor = Color.LightSeaGreen;
                    button14.BackColor = Color.LightSeaGreen;
                    button15.BackColor = Color.LightSeaGreen;
                    button16.BackColor = Color.LightSeaGreen;
                    button17.BackColor = Color.LightSeaGreen;
                    button18.BackColor = Color.LightSeaGreen;
                    button19.BackColor = Color.LightSeaGreen;
                    button20.BackColor = Color.LightSeaGreen;
                    button21.BackColor = Color.LightSeaGreen;
                    button22.BackColor = Color.LightSeaGreen;
                    button23.BackColor = Color.LightSeaGreen;
                    button24.BackColor = Color.LightSeaGreen;
                }

            }
           
        }

        private void button25_Click(object sender, EventArgs e)
        {

            lstHastaRandevu.Items.Clear();
            var xml5 = new XmlSerializer(typeof(Randevu2));

            XmlSerializer cevirici5 = new XmlSerializer(typeof(List<Randevu2>));
            if (System.IO.File.Exists(path5))
            {
                FileStream gelenXML5 = System.IO.File.OpenRead(path5);
                eskiListe5 = (List<Randevu2>)cevirici5.Deserialize(gelenXML5);
                foreach (var item in eskiListe5)
                {
                    if (item.Ad == txtAd.Text && item.Soyad==txtSoyad.Text)
                    {
                        ListViewItem li2 = new ListViewItem();

                        li2.Text = item.Ad + " " + item.Soyad;
                        li2.SubItems.Add(item.poliklinikler.ToString());
                        li2.SubItems.Add(item.hekimler.ToString());
                        li2.SubItems.Add(item.tarih.ToString());
                        li2.SubItems.Add(item.saat);

                        li2.Tag = (Randevu2)item;



                        lstHastaRandevu.Items.Add(li2);
                    }
                }
                gelenXML5.Close();
            }
        }       //randevu geçmişini gösterme
    }

}


