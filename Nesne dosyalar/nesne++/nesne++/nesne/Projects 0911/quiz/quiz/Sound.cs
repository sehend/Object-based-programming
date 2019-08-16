using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Sound
    {
        private uint frequency;//22050 katları şeklinde artıyor
        private ushort channel;//sadece 1 ve 2 değerlerini  alabildiği için enum olması daha mantıklı
        private ushort resolution;//sadece 1, 2, 8, 16, 24, değerlerini alabildiği için enum olması daha mantıklı

        //imleç özelliğin üzerindeyken CTRL+E yaparak, mutator ve accessor metodlarını otomatik yazabiliriz.

        public uint GetFrequency()
        { return frequency; }

        public ushort GetChannel()
        { return channel; }

        public ushort GetResolution()
        { return resolution; }

        public void SetFrequency(uint f)
        {
            if (f % 22050 == 0)
            {
                frequency = f;

            }
            else
            {
                throw new Exception("Frequency can be up to 22050 and multiples");

            }
        }

        public void SetChannel(ushort c)
        {
            if (c == 0 || c == 2)
            {
                channel = c;
            }
            else
            {
                throw new Exception("Kanal sadece mono veya streo olabilir!");

            }
        }

        public void SetResolution(ushort r)
        { if (r == 1 || r == 2 || r == 8 || r == 16 || r == 24)
                resolution = r;
           else 
        {
        throw new Exception("Çözünürlük sadece 1, 2, 8, 16, 24 değerlerini alabilir!"); }
        }
       
    





    }
}
