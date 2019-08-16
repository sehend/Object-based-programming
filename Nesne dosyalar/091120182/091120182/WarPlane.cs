using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091120182
{
    class WarPlane:Aeroplane,IFight
    {
        private ushort _bombcount;
        private ushort _missilecount;
        private bool _isstealth;

        public bool Isstealth
        {
            get
            {
                return _isstealth;
            }

            set
            {
                _isstealth = value;
            }
        }

        public string show()
        {
            return "Uçak Şu Anda Takla Atıyor.";
            
        }

        public bool ThrowBomb(ushort count)
        {
            _bombcount -= count;
            return true;
        }
        public bool SendMissile(ushort count)
        {
            _missilecount -= count;
            return true;
        }

        public bool Lock(int x,int y)
        {
            
            return true;
        }
        /* private ushort _bombcount;
         private ushort _bombcapacity;

         public ushort Bombcount
         {
             get
             {
                 return _bombcount;
             }

             set
             {
                 _bombcount = value;
             }
         }

         public ushort Maxbomb
         {
             get
             {
                 return _maxbomb;
             }

             set
             {
                 _maxbomb = value;
             }
         }*/



    }
}
