using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231120182
{
    class Program
    {
        static void Main(string[] args)
        {
           
            kompleks k1 = new kompleks();
            kompleks k2 = new kompleks();
            kompleks k3 = new kompleks();
            kompleks k4 = new kompleks();

            Console.Write("Birinci Sayının RE Gir :");
            k1.Re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Birinci Sayının IM gir :");
            k1.Im = Convert.ToDouble(Console.ReadLine());

            Console.Write("ikinci Sayının RE Gir :");
            k2.Re = Convert.ToDouble(Console.ReadLine());
            Console.Write("ikinci Sayının IM gir :");
            k2.Im = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçüncü Sayının RE Gir :");
            k3.Re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü Sayının IM gir :");
            k3.Im = Convert.ToDouble(Console.ReadLine());

            //k3.Re = k1.Re + k2.Re;
            //k3.Im = k1.Im + k2.Im;
            k4 = k1 + k2 + k3;
            // k3 = k1 + k2;
            //k3.ToString();

            // Console.WriteLine("{0}+{1}i+{2}+{3}i={4}+{5}i", k1.Re, k1.Im, k2.Re, k2.Im, k3.Re, k3.Im);
            // Console.WriteLine("({0})+({1})={2}", k1.ToString(), k2.ToString(),k3.ToString());
            Console.WriteLine("({0})+({1})+({2})={3}", k1.ToString(), k2.ToString(), k3.ToString(),k4.ToString());


            Console.ReadKey();

        }
    }
}
