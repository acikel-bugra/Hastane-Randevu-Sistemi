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
namespace HastahaneRandevuSistemi.Forms
{
    public partial class IstatistikForm : Form
    {
        public IstatistikForm()
        {
            InitializeComponent();
        }
       
        List<Doktor> eskiListe2 = new List<Doktor>();


        private void PersonellerimizForm_Load(object sender, EventArgs e)
        {

            string path2 = Application.StartupPath + "\\Doktor.xml";
            

#region Doktor Sayısı
            var xml2 = new XmlSerializer(typeof(Doktor));

            XmlSerializer cevirici2 = new XmlSerializer(typeof(List<Doktor>));
            if (System.IO.File.Exists(path2))
            {
                FileStream gelenXML2 = System.IO.File.OpenRead(path2);
                eskiListe2 = (List<Doktor>)cevirici2.Deserialize(gelenXML2);
                foreach (var item2 in eskiListe2)
                {
                    ListViewItem li2 = new ListViewItem();


                    li2.Text = item2.Ad + "" + item2.Soyad;

                    li2.SubItems.Add(item2.Brans.ToString());


                    lstdoktorlarımız.Items.Add(li2);
                    lbldoktorsayisi.Text = lstdoktorlarımız.Items.Count.ToString();
                }
                gelenXML2.Close();

                #endregion

                int toplam=lstdoktorlarımız.Items.Count ;
                lblToplamCalisanSayisi.Text = toplam.ToString();
            }
        }
    }
}
