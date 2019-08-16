using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Canavar:Karakter
    {
        public Canavar(string a,int lvl)
        {
            Guc = Level+5;
            Cevik = Level+6;
            Zeka = Level+1;
            Yasam = Level+10;
            Enerji = Level;
            Level = lvl;
            Deneyim = 100;
            Ad = a;
        }
    }
}
