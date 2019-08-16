using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19yeni
{
    public class tasit
    {
        private UInt16 speed;
        private UInt16 maxspeed;

        #region Kapsüller
        public UInt16 GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(UInt16 s)
        {
            speed = s;

        }
        public UInt16 GetMaxSpeed()
        {
            return maxspeed;
        }
        #endregion

        public tasit() { }

    }
}
