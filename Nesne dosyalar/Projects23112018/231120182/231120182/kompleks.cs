using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231120182
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
        public kompleks(double i,double r)
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
            else if(Im > 0)
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
        public static kompleks operator +(kompleks k1, kompleks k2)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re + k2.Re;
            k3.Im = k1.Im + k2.Im;
            return k3;
        }

        public static kompleks operator -(kompleks k1, kompleks k2)
        {
            kompleks k3 = new kompleks();
            k3.Re = k1.Re - k2.Re;
            k3.Im = k1.Im - k2.Im;
            return k3;
        }


    }
}
