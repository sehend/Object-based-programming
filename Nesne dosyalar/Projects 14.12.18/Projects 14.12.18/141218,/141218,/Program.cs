using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141218
{
    class Program
    {
        static void Main(string[] args)
        {

            int sec;
            for (;;) { 
            Console.Write("\n******Menu******\n1-Müşteri ekle\n2-Müşteri Sil\n3-Müşteri listele\n4-çıkış\nSecim..");
                sec = int.Parse(Console.ReadLine());

                switch (sec)
                {
                    case 1:

                        //müşteri ekle
                        break;
                    case 2:

                        //müşteri sil
                        break;
                    case 3:

                        //müşteri listele
                        break;
                    case 4:
                        Environment.Exit(0);
                        //çıkış
                        break;
                    
                    default:
                        break;
                }

            }

        }
    }
}
