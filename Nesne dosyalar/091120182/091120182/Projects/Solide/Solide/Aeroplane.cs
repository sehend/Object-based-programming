using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solide
{
    public enum EnginrType { Diesel,Turbine,Jet,Rocket}
    class Aeroplane:Vehicle 
    {
        private EnginrType _engine;
        private bool _isflying;

        public EnginrType Engine
        {
            get
            {
                return _engine;
            }

            set
            {
                _engine = value;
            }
        }

        public bool Isflying
        {
            get
            {
                return _isflying;
            }

            set
            {
                _isflying = value;
            }
        }

        public void TakeOff()
        {
            Isflying = true;
          
        }
        public void Land()
        {
            Isflying = false;
        }
    }
}
