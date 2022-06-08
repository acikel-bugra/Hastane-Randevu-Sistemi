using HastahaneRandevuSistemi.Classes;
using HastahaneRandevuSistemi.Forms;
using mhrs;
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
using static HastahaneRandevuSistemi.Person;




namespace HastahaneRandevuSistemi.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(Hasta.KanGrubu)));
        }

        private void button2_Click(object sender, EventArgs e)  //Temizle
        {
          
            txtTCKN.Text = String.Empty;
            mtbTelefon.Text = String.Empty;
            txtAd.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            cmbCinsiyet.Items.Clear();
            cmbKanGrubu.Items.Clear();
            dtpDogumTarihi.Value = DateTime.Now;


        } 
        
        string path4 = Application.StartupPath + "\\Hasta.xml";
  

        List <Hasta> eskiListe4 = new List<Hasta>();
        List<Hasta> hastalar = new List<Hasta>();

        
       

        private void SignUpForm_Load(object sender, EventArgs e)
        {
           cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
        
        }
        private void button1_Click(object sender, EventArgs e)   //Üye olma
        {
           

            Hasta yeniHasta = new Hasta
            {
                TCKN = txtTCKN.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarihi = dtpDogumTarihi.Value,

                Cinsiyetler = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                kanGrubu = cmbKanGrubu.Text,
                telefon = mtbTelefon.Text
            };
            hastalar.Add(yeniHasta);
            
           
            MessageBox.Show("Kayıt işleminiz başarıyla gerçekleşmiştir! ");

            string dosya_yolu = "kullaniciListesi.txt";
            
            StreamWriter sw = File.AppendText(dosya_yolu);    //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            
            sw.Write(txtTCKN.Text+";"+"123;4;"+txtAd.Text+";"+txtSoyad.Text);
            
            //Dosyaya ekleyeceğimiz yazıyı WriteLine() metodu ile yazacağız.
            
            sw.Close();
           

            XmlSerializer cevirici4 = new XmlSerializer(typeof(List<Hasta>));
            if (System.IO.File.Exists(path4))
            {
                FileStream gelenXML4 = System.IO.File.OpenRead(path4);
                eskiListe4 = (List<Hasta>)cevirici4.Deserialize(gelenXML4);
                gelenXML4.Close();

            }




            eskiListe4.Add(yeniHasta);
            FileStream yazici4 = new FileStream(path4, FileMode.Create);
            cevirici4.Serialize(yazici4, eskiListe4);
            yazici4.Close();
         
            
                       


           
             HastaRandevuForm hastaRandevuForm = new HastaRandevuForm();
            hastaRandevuForm.kullaniciAdi = txtAd.Text;
            hastaRandevuForm.kullaniciSoyadi = txtSoyad.Text;
            hastaRandevuForm.Show();
                           
            this.Close();
           

        }
  
    }
    
}
