using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hayvan
    {

        public enum gender { male, female, none, both };
        //gram cinsinden ağırlık
        protected uint mass;
        protected uint eyecount;
        protected uint legcount;
        protected gender cinsiyet;
        public string name;
        public Lokasyon loc = new Lokasyon(170, 8, 0);

        public Hayvan() { }
        public Hayvan(string n) { name = n; }
        public Hayvan(string n, uint m, uint ec, uint lc, gender g)
        {
            name = n;
            mass = m;
            eyecount = ec;
            legcount = lc;
            cinsiyet = g;
        }

        protected Lokasyon Move(int xdir, int ydir, int zdir)
        {
            Lokasyon temp = new Lokasyon();
            loc.x += xdir;
            loc.y += ydir;
            loc.z += zdir;
            temp.x = loc.x;
            temp.y = loc.y;
            temp.z = loc.z;
            return temp;
        }
    }
}
