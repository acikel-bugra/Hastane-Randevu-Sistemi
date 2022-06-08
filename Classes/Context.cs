using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi.Classes
{
    public class Context
    {
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
       
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();
       
        public List<RandevuBilgileri> Randevular { get; set; } = new List<RandevuBilgileri>();
    }
}
