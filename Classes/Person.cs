using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastahaneRandevuSistemi.Classes;

namespace HastahaneRandevuSistemi
{
   public class Person
    {
        private string _tckn;

        public string TCKN
        {
            get { return _tckn; }
            set { _tckn =TCKNValid(value); }
        }

        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = AdSoyadValid(value); }
        }

        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = AdSoyadValid(value); }
        }

        private DateTime _dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        private Cinsiyet _cinsiyetler;

        public Cinsiyet Cinsiyetler

        {
            get { return _cinsiyetler; }
            set { _cinsiyetler = value; }
        }

        public enum Cinsiyet
        {
            Erkek,
            Kadın,
            Belirsiz
        }

        
        private string TCKNValid(string tckn)
        {
            if (string.IsNullOrEmpty(TCKN)) return "";
            if (tckn.Length != 11)
                throw new Exception("TCKN 11 haneli olmalıdır");
            if (tckn[0] == '0')
                throw new Exception("TCKN '0' ile başlayamaz");
            foreach (char harf in tckn)
                if (!char.IsDigit(harf))
                    throw new Exception("TCKN içerisinde sadece rakam bulunmalıdır");

            return tckn;
        }
        private string AdSoyadValid(string kelime)
        {
            foreach (char harf in kelime)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception("Ad veya Soyad içerisinde geçersiz karakter bulunmaktadır.");
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime);

        }

        public override string ToString()
        {
            return $"{TCKN} : {Ad}: {Soyad}: {DogumTarihi}: {Cinsiyetler} ";
        }


    }

}

