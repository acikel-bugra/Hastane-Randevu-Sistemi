using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi.Classes
{
    public class Hasta : Person
    {
        public string telefon { get; set; }

        public string kanGrubu { get; set; }

        public enum KanGrubu
        {
            AB_RHpozitif,
            AB_RHnegatif,
            A_RHpozitif,
            A_RHnegatif,
            B_RHpozitif,
            B_RHnegatif,
            O_RHpozitif,
            O_RHnegatif
        }
    }
}
