using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _141218
{
    class Musteri
    {
        string _ad;
        string _soyad;
        string _musteriNo;
        public List<Hesap> Hesaplar = new List<Hesap>();
        Hesap yeniHesap = new Hesap("TR001 0070 0045",2,3,false,0);

        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }

        public string MusteriNo
        {
            get
            {
                return _musteriNo;
            }

            set
            {
                _musteriNo = value;
            }
        }
    }
}
