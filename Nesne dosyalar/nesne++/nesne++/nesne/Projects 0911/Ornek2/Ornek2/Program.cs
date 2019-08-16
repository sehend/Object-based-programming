using System;

namespace Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil o1 = new Otomobil(false, false);
            Otomobil o2 = new Otomobil(true, true);

            for (;;)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(o2.speed + " ");

                ConsoleKeyInfo tus = new ConsoleKeyInfo();
                tus = Console.ReadKey(true);
                if (tus.Key == ConsoleKey.Q)
                    break;
                else if (tus.Key == ConsoleKey.W)
                    o2.Accelerate();
                else if (tus.Key == ConsoleKey.S)
                    o2.Decelerate();
                else if (tus.Key == ConsoleKey.Spacebar)
                    o2.HandBrake();
            }
            Console.WriteLine("Arabanın kontrolünü kaybettiniz.");
            Console.ReadLine();
        }
    }
}
