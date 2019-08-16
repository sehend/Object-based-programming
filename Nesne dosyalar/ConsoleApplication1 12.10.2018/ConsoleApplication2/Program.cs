using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;

            otomobil o1 = new otomobil();
            otomobil o2 = new otomobil(true, false);

         //   Console.WriteLine("model :"+o2.modelyil+"\nMarka :"+o2.marka+"\nMax hız :"+o2.maxspeed+"\nSpeed :"+o2.speed);
         //   don:
         //   Console.Write("1.Hızlan\n2.yavasla\nseç:");
           // sec = Convert.ToInt32(Console.ReadLine());
            

ConsoleKeyInfo tus = new ConsoleKeyInfo();

            for (;;) { 

                tus = Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("hızınız '{0}'", o2.speed);
                if (tus.Key == ConsoleKey.S)
                {
                    o2.Handbrake();
                }
                if (tus.Key == ConsoleKey.W)
                {
                    o2.Accelerate();
                }
                if (tus.Key == ConsoleKey.Escape)
                {
                    break;
                }

            }
            Console.Write("Arabanın kontrolünü kaybettin");
            /*do
            {
                
                tus = Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("hızınız '{0}'", o2.speed);
                if(tus.Key == ConsoleKey.S)
                {
                    o2.Handbrake();
                }
                if (tus.Key == ConsoleKey.W)
                {
                    o2.Accelerate();
                }
            } while (tus.Key != ConsoleKey.Escape);*/

            /*   switch(sec)
               {
                   case 1:
                      
                       goto don;
                       break;
                   case 2:
                       o2.Handbrake();
                       goto don;
                       break;
                   case 3:

                       break;
               }
               */

            //  Console.WriteLine("model :" + o2.modelyil + "\nMarka :" + o2.marka + "\nMax hız :" + o2.maxspeed + "\nSpeed :" + o2.speed);
            Console.ReadKey();

        }
    }
}
