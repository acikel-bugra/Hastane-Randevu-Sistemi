using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi.Classes
{
   public class Doktor : Person, IMaas
    {
        
        private Branslar _brans;
        private decimal _maas;
        public Branslar Brans
        {
            get
            {
                return _brans;
            }

            set
            {
                _brans = value;
            }
        }

        public decimal Maas
        {
            get
            {
                return _maas;
            }

            set
            {
                _maas = value;
            }
        }
        public enum Branslar
        {
            
            Dahiliye,
            Nöroloji,
            Kardiyoloji,
            Gastroloji,
            Ortopedi,
            KBB,
            
        }
        public override string ToString()
        {
            return $"{Ad} {Soyad} ";
        }
    }
}
