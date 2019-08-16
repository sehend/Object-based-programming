using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student:Person
    {
        private UInt64 sNumber;

        public ulong SNumber
        {
            get
            {
                return sNumber;
            }

            set
            {
                sNumber = value;
            }
        }
    }
}
