using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091120182
{
    public enum EngineType { Diesel, Turbine, Jet, Rocket }
    class Aeroplane:Vehicle
    {
        private EngineType _engine;
        private bool _isflying;

        public EngineType Engine
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

        protected void TakeOff()
        {
            _isflying = true;
        }
        protected void Land()
        {
            _isflying = true;
        }

    }
}
