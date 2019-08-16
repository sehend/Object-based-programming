using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class otomobil
    {
        public UInt16 maxspeed;
        public UInt16 speed;

        public bool hasaircondition;
        public bool hassunroof;
        public UInt16 modelyil;
        public string marka;

        public otomobil(bool air,bool sun)
        {
            maxspeed = 200;
            speed = 0;
            hasaircondition = air;
            hassunroof = sun;
            
        }
        public otomobil()
        {
           
        }
        public otomobil(bool sun)
        {
            hassunroof = sun;
        }
        public void Accelerate()
        {
            if(speed<maxspeed)
            {
                speed += 5;
            }

        }

        public void Handbrake()
        {
            if (speed > 0)
            {
                speed -= 5;
                
                
            }

        }


    }
}
