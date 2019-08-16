using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            kutu kutu1 = new kutu();
            kutu kutu2 = new kutu();
            kutu1.color = "Kırmızı";
            kutu2.color = "Mavi";
            kutu1.height = 50;
            kutu1.length = UInt16.Parse(Console.ReadLine());
        }
    }
}
