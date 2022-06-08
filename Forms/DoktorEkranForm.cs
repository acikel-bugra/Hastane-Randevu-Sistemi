using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using mhrs;
using System.Xml;
using HastahaneRandevuSistemi.Classes;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using static HastahaneRandevuSistemi.Classes.Randevu2;

namespace HastahaneRandevuSistemi
{
    public partial class DoktorEkranForm : Form
    {
        public HastaRandevuForm frm1;
        public DoktorEkranForm()
        {
            InitializeComponent();
        }

        public string Mesaj { get; set; }

        List<Randevu2> eskiListe5 = new List<Randevu2>();

       

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = Application.OpenForms["EnterForm"];
            if (f == null)
            {
                var form = new EnterForm();
                form.Show();
            }
            else
                f.Activate();

        }
      
        private void btnTariheGoreListe_Click(object sender, EventArgs e)
        {
             string path5 = Application.StartupPath + "\\Randevu.xml";

            var xml5 = new XmlSerializer(typeof(Randevu2));

            XmlSerializer cevirici5 = new XmlSerializer(typeof(List<Randevu2>));
            if (System.IO.File.Exists(path5))
            {
                FileStream gelenXML5 = System.IO.File.OpenRead(path5);
                eskiListe5 = (List<Randevu2>)cevirici5.Deserialize(gelenXML5);
                foreach (var item in eskiListe5)
                {
                    if (item.tarih == DateTime.Now.ToLongDateString())
                    {
                        ListViewItem li = new ListViewItem();

                        li.Text = item.Ad + " " + item.Soyad;
                        li.SubItems.Add(item.tarih.ToString());
                        li.SubItems.Add(item.saat);

                        li.Tag = (Randevu2)item;



                        lstHastaRandevu.Items.Add(li);
                    }
                }
                gelenXML5.Close();
            }

           
           
        }

      
        private void btnHastaCagir_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            string lblAd = "";
            string lblTarih = "";

            Image myimage =new Bitmap(Properties.Resources.icerigel);
            foreach (ListViewItem item in lstHastaRandevu.SelectedItems)
            {
                lblAd = item.SubItems[0].Text.ToString();
                lblTarih = item.SubItems[1].Text.ToString();
            }

                // Popup adında bir form oluştur
                Form Popup = new Form
            {
                
                Width = 978, // genişlik parametresini yaz
                Height = 575, // yükseklik parametresini yaz
                ShowInTaskbar = false, // Başlat çubuğunda görülmesin
                FormBorderStyle = FormBorderStyle.None, // Form kenarlıkları yok
                //BackColor = Color.Orange, // Arkaplan "Turuncu" rengi olsun
                StartPosition = FormStartPosition.CenterScreen, // Formu ekrana ortasında göster
                TopMost = true, // Her zaman üstte dursun
                Cursor = Cursors.Arrow, // Mouse şekli el şeklinde olsun
                BackgroundImage=myimage
                
            };


            Popup.Click += delegate // Form click olayı
            {
                this.Dispose(); // tıklanıldığında formu kapat 
            };


            Popup.Paint += delegate // Form içi grafik işlemleri
            {
                // Formun etrafına bir dörtgen çiz
                //Popup.CreateGraphics().DrawRectangle(Pens.Black, 0, 0, (500 - 1), (400 - 1));
            };

            // lbl_text adında bir label oluştur ve içine text i yaz
            Label lbl_text = new Label
            {
                Width =300,
                Height= 50,
                Left = 500, // sol tarafa uzaklık 30 pixel
                Top = 200, // yukarıya uzaklık 30 pixel
                //AutoSize = true, // label boyutunu text'e göre  ayarla
                Font = new Font("Verdana",25f,  FontStyle.Bold,GraphicsUnit.Pixel), // font kalın olsun
                Text = $"Lütfen İçeri Geliniz", // metin parametresini ata
                


        };

            Label lbl_text1 = new Label
            {
                Width=300,
                Height=40,
                Left = 500,
                Top = 100,
                Font = new Font("Verdana",20f, FontStyle.Bold),
                Text = lblAd,


            };

            Label lbl_text2 = new Label
            {
                Width = 290,
                Height = 20,
                Left = 280, 
                Top = 10, 
                //AutoSize = true, // label boyutunu text'e göre  ayarla
                Font = new Font("Verdana", 10f, FontStyle.Bold), // font kalın olsun
                Text = DateTime.Now.ToLongDateString()+$"( "+DateTime.Now.ToLongTimeString() +$" )", // metin parametresini ata



            };

            // Oluşturulan labeli forma ekle
            Popup.Controls.Add(lbl_text);
            Popup.Controls.Add(lbl_text1);
            Popup.Controls.Add(lbl_text2);


            // Pop-Up formu göster
            Popup.ShowDialog();
        }


    }
}
