using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141218
{
    class Hesap
    {
        string _IBAN;
        UInt16 _bankaNo;
        UInt16 _subeNo;
        bool _vade;
        double _faiz;
        double _nakit;

        public string IBAN
        {
            get
            {
                return _IBAN;
            }

            set
            {
                _IBAN = value;
            }
        }

        public ushort BankaNo
        {
            get
            {
                return _bankaNo;
            }

            set
            {
                _bankaNo = value;
            }
        }

        public ushort SubeNo
        {
            get
            {
                return _subeNo;
            }

            set
            {
                _subeNo = value;
            }
        }

        public bool Vade
        {
            get
            {
                return _vade;
            }

            set
            {
                _vade = value;
            }
        }

        public double Faiz
        {
            get
            {
                return _faiz;
            }

            set
            {
                _faiz = value;
            }
        }

        public double Nakit
        {
            get
            {
                return _nakit;
            }

            set
            {
                _nakit = value;
            }
        }

        public Hesap(string IBAN, UInt16 bankaNo, UInt16 subeNo, bool vade, double faiz)
        {
            _IBAN = IBAN;

            _bankaNo = bankaNo;
            _subeNo = subeNo;
            _vade = vade;
            _faiz = faiz;
            _nakit = 0;
        }

        public void ParaYatir(double miktar)
        {

            _nakit += miktar;
        }

        public void ParaCek(double miktar)
        {
            if (miktar <= _nakit)
            {
                _nakit -= miktar;
            }
            else
            {
                throw new Exception("Yetersiz bakiye");
            }

        }
        public override string ToString()
        {
            Console.WriteLine("IBAN     :{0}", _IBAN);
            Console.WriteLine("Banka No :{0}", _bankaNo);
            Console.WriteLine("Hesap No :{0}", _subeNo);
            Console.WriteLine("Vade     :{0}", _vade ? "vadeli" : "Vadesiz");
            Console.WriteLine("Miktar   :{0}", _nakit);
            Console.WriteLine("Faiz     :{0}", _faiz);
            return base.ToString();
        }
    }
}
