using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091120182
{
    class Vehicle
    {
        private int _x;
        private int _y;
        private ushort _capacity;
        private uint _speed;
        private uint _maxspeed;

        public ushort Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = value;
            }
        }

        public uint Speed
        {
            get
            {
                return _speed;
               
            }

            set
            {
                _speed = value;
            }
        }

        public uint Maxspeed
        {
            get
            {
                return _maxspeed;
            }

            set
            {
                _maxspeed = value;
            }
        }

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        protected void Move(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
}
