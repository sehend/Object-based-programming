using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Manager:Person
    {
        private String pozisyon;

        public string Pozisyon
        {
            get
            {
                return pozisyon;
            }

            set
            {
                pozisyon = value;
            }
        }
    }
}
