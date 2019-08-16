using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Teacher:Person
    {
        private string sube;

        public string Sube
        {
            get
            {
                return sube;
            }

            set
            {
                sube = value;
            }
        }
    }
}
