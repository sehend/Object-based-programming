
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23112018
{
    class Tarih
    {
        private int gun;
        private int ay;
        private int yil;

        public int GetGun() { return gun; }
        public int GetAy() { return ay; }
        public int GetYil() { return yil; }

        public void SetGun(int g)
        {
             
            
                if((ay==1||ay==3||ay==5||ay==7||ay==8||ay==10||ay==12)&& (g > 0 && g < 32))
            {
                gun = g;
            }
                else if(ay==2 && g>0 && g<29)
            {
                gun = g;
            }
                else if((ay==4||ay==6||ay==9||ay==11)&& g>0 && g < 31)
            {
                gun = g;
            }
            else
            {
                throw new Exception("Gün değeri hatalı !");
            }  
        }

        public void SetAy(int a)
        {
            if (a > 0 && a < 13)
            {
                ay = a;
            }
            else
            {
                throw new Exception("Ay değeri hatalı !");
            }
        }

        public void SetYil(int y)
        {
            if (y > 0)
            {
                yil = y;
            }
            else
            {
                throw new Exception("Yıl değeri hatalı !");
            }
        }
        
        public Tarih()
        {
            DateTime bugun = new DateTime();
            
            int yil = bugun.Year;
            int ay = bugun.Month;
            int gun = bugun.Day;
        }

        public void Ilerle()
        {
            if(ay==12 && gun == 31)
            {
                gun = 1;
                ay = 1;
                yil++;
            }
            else if ((ay == 1 || ay == 3 || ay == 5 || ay == 7 || ay == 8 || ay == 10) && (gun == 31))
            {
                gun = 1;
                ay++;
            }
            else if(ay==2 && gun == 28)
            {
                gun = 1;
                ay++;
            }
            else
            {
                throw new Exception("Acayip bir hata oluştu");
            }
        }

    }
}
