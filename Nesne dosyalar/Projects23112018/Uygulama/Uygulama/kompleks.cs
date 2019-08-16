using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    class kompleks
    {
        private double re;
        private double im;

        public double Re
        {
            get;
            set;

        }
        public double Im
        {
            get;
            set;
        }

        public kompleks()
        {
            re = 0;
            im = 0;
        }
        //public kompleks(double i)
        //{
        //    re = 0;
        //    im = i;
        //}
        //public kompleks(double r)
        //{
        //    re = r;
        //    im = 0;
        //}
        public kompleks(double i, double r)
        {
            re = r;
            im = i;
        }
        public override string ToString()
        {

            if (Im == 0)
            {
                return Re.ToString();
            }
            else if (Re == 0)
            {
                return Im.ToString();
            }
            else if (Im > 0)
            {
                return Re.ToString() + "+" + Im.ToString() + "i";
            }
            else if (Im < 0)
            {
                return Re.ToString() + Im.ToString() + "i";
            }
            else
            {
                return "0";
            }

        }
        // oparatör +
        public static kompleks operator +(kompleks k1, kompleks k2)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re + k2.Re;
            k3.Im = k1.Im + k2.Im;
            return k3;
        }
        // oparatör -
        public static kompleks operator -(kompleks k1, kompleks k2)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re - k2.Re;
            k3.Im = k1.Im - k2.Im;
            return k3;
        }
        // oparatör *
        public static kompleks operator *(kompleks k1, kompleks k2)
        {
            kompleks k3 = new kompleks();
            k3.Re = (k1.Re * k2.Re)+(k1.Re * k2.Im);
            k3.Im =( k1.Im * k2.Im)+(k1.Re * k2.Re);
            return k3;
        }
        // oparatör /
        public static kompleks operator /(kompleks k1, kompleks k2)
        {
            double a = k1.Re, b = k1.Im, c = k2.Re, d = k2.Im;
            kompleks k3 = new kompleks();

            k3.Re = ((a * c) + (b * d)) / ((c * c) + (d * d));
            k3.Im = (((b * c) - (a * d)) / ((c * c) + (d * d)));          
            return k3;
        }

        //intle kompleks +
        public static kompleks operator +(kompleks k1, int sayi)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re + sayi;
            k3.Im = k1.Im + sayi;
            return k3;
        }

        //intle kompleks -
        public static kompleks operator -(kompleks k1, int sayi)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re - sayi;
            k3.Im = k1.Im - sayi;
            return k3;
        }

        //intle kompleks /
        public static kompleks operator /(kompleks k1, int sayi)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re / sayi;
            k3.Im = k1.Im / sayi;
            return k3;
        }


        

        // oparatör ++
        public static kompleks operator ++(kompleks k1)
        {
            kompleks k3 = new kompleks();     
            k3.Re = k1.Re + 1;
            return k3;
        }

        // oparatör --
        public static kompleks operator --(kompleks k1)
        {
            kompleks k3 = new kompleks();    
            k3.Re = k1.Re - 1;
            return k3;
        }


        
        //doublela kompleks +
        public static kompleks operator +(kompleks k1, double dsayi)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re + dsayi;
            k3.Im = k1.Im + dsayi;
            return k3;
        }

        //doublela kompleks -
        public static kompleks operator -(kompleks k1, double dsayi)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re - dsayi;
            k3.Im = k1.Im - dsayi;
            return k3;
        }
        //doublela kompleks *
        public static kompleks operator *(kompleks k1, double dsayi)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re * dsayi;
            k3.Im = k1.Im * dsayi;
            return k3;
        }

        //doublela kompleks /
        public static kompleks operator /(kompleks k1, double dsayi)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re / dsayi;
            k3.Im = k1.Im / dsayi;
            return k3;
        }
    }
}
