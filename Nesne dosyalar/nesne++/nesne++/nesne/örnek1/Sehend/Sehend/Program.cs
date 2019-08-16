using System;

namespace Sehend
{
    class Program
    {
        static void Main(string[] args)
        {
            int d; //declaration
            Console.WriteLine("Lütfen Bir Değer Giriniz");
            d = Convert.ToInt32(Console.ReadLine());

            if (d < 0)
                Console.WriteLine("Negatif sayı girdiniz.");
            else if (d > 0)
                Console.WriteLine("Pozitif sayı girdiniz.");
            else
                Console.WriteLine("Sayı sıfıra eşittir.");

            Console.ReadLine();
        }
        
    }
}
