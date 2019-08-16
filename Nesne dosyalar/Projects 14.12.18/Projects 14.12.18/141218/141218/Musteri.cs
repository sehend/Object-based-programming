using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141218
{
    class Musteri
    {
        //ip4 172.17.3.16
        string _ad;
        string _soyad;
        string _musteriNo;
        public List<Hesap> Hesaplar = new List<Hesap>();
      //  Hesap yeniHesap = new Hesap("TR001 0070 0045", 2, 3, false, 0);

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

        public Musteri(string ad,string soyad,string musteriNo)
        {
            _ad = ad;
            _soyad = soyad;
            _musteriNo = musteriNo;
        }

        public override string ToString()
        {
            Console.WriteLine("Müşteri No    : {0}",_musteriNo);
            Console.WriteLine("Müşteri Adı   : {0}",_ad);
            Console.WriteLine("Müşteri Soyadı: {0}",_soyad);
            return base.ToString();
        }
    }
}
