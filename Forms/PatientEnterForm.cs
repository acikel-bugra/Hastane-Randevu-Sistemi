using HastahaneRandevuSistemi;
using HastahaneRandevuSistemi.Classes;
using HastahaneRandevuSistemi.Forms;
using System;
using System.Collections;
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

namespace mhrs
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        

        Hashtable kayitlar = new Hashtable();
        int kayitSayisi = 0;
     
        int sure = 0;

        public string TcAl()
        {
            return txtTC.Text;
        }

        public void kayitlariOku()      //kullanıcı listesi okunuyor
        {
            kayitSayisi = 0;
            kayitlar.Clear();
            StreamReader sr = new StreamReader("kullaniciListesi.txt");
            string metin = sr.ReadLine();
            while (metin != null)
            {
                kayitlar.Add(kayitSayisi, metin);
                metin = sr.ReadLine();
                kayitSayisi++;
            }
            sr.Close();

        }

        private void hangiForm(int formNo)      //yetkiye göre formlar açılıyor
        { 
            BashekimForm BashekimForm = new BashekimForm();
            DoktorEkranForm DoktorEkranForm = new DoktorEkranForm();
 
            HastaRandevuForm HastaRandevuForm = new HastaRandevuForm();
         

            kayitlariOku();
            for (int i = 0; i < kayitlar.Count; i++)
            {
                if (i == 7) { 
                string[] dizi = kayitlar[i].ToString().Split(';');
                
                if (dizi[0] == txtTC.Text && dizi[1] == txtSifre.Text)
                {
                    HastaRandevuForm.kullaniciAdi = dizi[3];
                    HastaRandevuForm.kullaniciSoyadi = dizi[4];
                }
            }}
            progressBar1.Value = progressBar1.Maximum;

            if (formNo == 1)
                BashekimForm.Show();
            else if (formNo == 2)
                DoktorEkranForm.Show();
           
            else if (formNo == 4)
                HastaRandevuForm.Show();
            
               
        }
        
        private void PatientEnterForm_Load(object sender, EventArgs e)
        {
            kayitlariOku();
            progressBar1.Maximum = kayitlar.Count;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)  //kullanıcının bilgilerine ve yetkisine göre yönlendirme yapılıyor
        {
            if (txtTC.Text == "bashekim") //Daha sonra kaldırılacak
            {
                new BashekimForm().Show();
                label4.Text = "Giriş Başarılı";
                label4.ForeColor = Color.Green;
                timer1.Stop();
            }
            kayitlariOku();
            progressBar1.Value = 0;
            progressBar1.Maximum = kayitSayisi;

            for (int i = 0; i < kayitlar.Count; i++)
            {
                progressBar1.Value = i + 1;
                string[] dizi = kayitlar[i].ToString().Split(';');
                if (dizi[0] == txtTC.Text && dizi[1] == txtSifre.Text)
                {
                   label4.Text = "Giriş Başarılı";
                  label4.ForeColor = Color.Green;
                    timer1.Stop();
                    sure = 0;

                    string yetki = "";
                    if (dizi[2] == "1")
                        yetki = "Bashekim";
                    else if (dizi[2] == "2")
                        yetki = "Doktor";
                    
                    else if (dizi[2] == "4")
                        yetki = "Hasta";
                    
                    if (dizi[2] != "4")

                        notifyIcon1.ShowBalloonTip(250, "Hoşgeldiniz", " \"" + yetki + "\" olarak giriş yapıldı..", ToolTipIcon.Info);

                    else
                         notifyIcon1.ShowBalloonTip(250, "Giriş Başarılı Hoşgeldiniz", dizi[3] + " " + dizi[4], ToolTipIcon.Info);
                    
                    hangiForm(Convert.ToInt16(dizi[2]));
                    break;
                }    
            }
        }
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure == 300)
            {
                timer1.Stop();
                sure = 0;
            }
        }

        private void PatientEnterForm_Activated(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)   //üye olma sayfasına yönlendiriyor
        {
            SignUpForm SignUpForm = new SignUpForm();
            SignUpForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
