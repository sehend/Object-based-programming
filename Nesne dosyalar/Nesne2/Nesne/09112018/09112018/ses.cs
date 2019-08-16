using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09112018
{
    class ses
    {
        private uint frequency;
        private ushort channel;
        private ushort resolution;

        public uint GetFrequency()
        { return frequency; }

        public uint GetChannel()
        { return channel; }

        public uint GetResolution()
        { return resolution; }

        public void SetFrequency(uint _frequency)
        {
            if (_frequency % 22050 == 0)
            {
                frequency = _frequency;
            }
            else
            {
                throw new Exception("Sadece 22050 Ve Katlarında Değer Alabilir.");
                
            }
        }

        public void SetChannel(ushort _channel)
        {
            if(_channel==1|| _channel ==2)
            {
                channel = _channel;
            }
            else
            {
                throw new Exception("Kanal Sadece 1 (Mono) ve 2 (Stereo) Olabilir.");
            }
        }

        public void SetResolution(ushort _resolution)
        {
            if (_resolution == 1 || _resolution == 2 || _resolution == 8 || _resolution == 16 || _resolution == 24)
            {
                resolution = _resolution;
            }
            else
            {
                throw new Exception("Çözünürlük Sadece 1 , 2 , 8 , 16 , 24 Olabilir.");
            }
        }

        public ses()
        {
            this.frequency = 22050;
            this.channel = 1;
            this.resolution = 1;
        }
        ~ses() { }
        public bool IsStudioQuality()
        {
            if (channel == 2 && frequency == 88200 && resolution == 24)
            {
                return true;
            }
            else
            {
                return false;
            }
            return (channel == 2 && frequency == 88200 && resolution == 24) ? true : false;
        }
        public uint capacity(uint duration)
        {
            //b=dc(r/8)s
            return (uint)(duration * channel * (resolution / 8) * frequency);
        }
    }
}
