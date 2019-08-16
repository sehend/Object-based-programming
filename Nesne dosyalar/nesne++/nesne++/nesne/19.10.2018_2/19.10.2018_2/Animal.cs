using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._10._2018_2
{
    public class Animal
    {
        public enum gender { male,female,none,both};
        
        protected UInt32 mass;
        protected UInt32 eyecount;
        protected UInt32 legcount;
        protected gender cinsiyet;
        public lokasyon loc = new lokasyon(178,45,0);
        public string name;

      public Animal() { }
        public Animal(string n) { name = n; }
        public Animal(string n, UInt32 m, UInt32 ec, UInt32 lc, gender g) {
            name = n;
            mass = m;
            eyecount = ec;
            legcount = lc;
            cinsiyet = g;

        }


        public void Move()
        {

            
            loc.x += 100;
            loc.y += 78;
            loc.z += 96;

            
        }
       /* public void move2()
        {
            Move();
        }*/
        
        /*  Console.WriteLine("Hayvanın ;" );
Console.WriteLine("ismi :"+name);
Console.WriteLine("Ağırlığı :" +mass);
Console.WriteLine("Göz sayısı :" + eyecount);
Console.WriteLine(" leg sayısı :" + legcount);
Console.WriteLine("" + );
*/
    }
}
