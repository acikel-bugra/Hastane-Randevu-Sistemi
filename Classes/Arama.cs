using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi
{
    public static class Arama<T> where T : Person
    {
        public static List<T> Ara(List<T> liste, string aranacak) => liste.Where(x => x.Ad.ToLower().Contains(aranacak.ToLower()) || x.Soyad.ToLower().Contains(aranacak.ToLower()) || x.TCKN == aranacak).ToList();
        
    }
}
 
