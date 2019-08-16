using System;

namespace Ornek2
{
    public class Otomobil
    {
        public UInt16 maxspeed;
        public UInt16 speed;
        public bool hasaircondition;
        public bool hassunroof;

        public Otomobil()
        {
        }
        public Otomobil(bool air, bool sun)
        {
            maxspeed = 200;
            speed = 0;
            hasaircondition = air;
            hassunroof = sun;
        }

        public void Accelerate()
        {
            if (speed < maxspeed)
                speed += 5;
        }

        public void Decelerate()
        {
            if (speed > 0)
                speed -= 5;
        }

        public void HandBrake()
        {
            if (speed > 40)
                speed -= 40;
            else
                speed = 0;
        }
    }
}
