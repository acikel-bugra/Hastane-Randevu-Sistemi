using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi.Classes
{
  public  class Randevu2
    {
        public string Id { get; set; }
        public string Ad{ get; set; }
        public string Soyad { get; set; }

        public Poliklinikler poliklinikler { get; set; }
        public Hekimler hekimler { get; set; }

        public string tarih { get; set; }
        public string saat { get; set; }


        public enum Poliklinikler
        {
            BEYİN_VE_SİNİR_CERRAHİSİ, DİYABET, KALP_DAMAR_CERRAHİSİ, KARDİYOLOJİ, KBB, NEFROLOJİ, NÖROLOJİ, ORTOPEDİ_VE_TRAVMATOLOJİ
        }
        public enum Hekimler
        {
            ProfDr_Abdullah_İĞCİ, ProfDr_Abdurrahman_ÖNEN, ProfDr_Adnan_SAYAR, ProfDr_Ahmet_SOYSAL,
            ProfDr_Ali_DEMİRCİ, ProfDr_Aydın_TÜRKMEN, ProfDr_Ayşe_SERTKAYA, UzmDr_Abdurrahman_YILDIRIM,
            UzmDr_Ahmet_ARPACI, OpDr_Arda_ÇINAR, OpDr_Asena_AYAR, Dr_Alper_ÖZBAŞ, Dt_Aslı_TAPAN,
            ProfDr_Esra_SAĞLAM, ProfDr_Engin_ÇAKAR, DoçDr_Ercan_TUTAK, UzmDr_Ebru_TÜRK, DoçDr_Gökhan_ERTAŞ,
            OpDr_Gönül_ÖZER, UzmPsi_Gizem_ÇÖLÜMLÜ, ProfDr_Sami_KATIRCIOĞLU, ProfDr_Sedat_ÖZKAN,
            OpDr_Melih_AYGÜN, OpDr_Miraç_TURAN, UzmFzt_Onur_KÖKSAL, UzmDyt_Merve_YÜKSEK, PedagogDr_Melda_ALANTAR, Dyt_Ezgi_MUMCU
        }
        public Randevu2()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
