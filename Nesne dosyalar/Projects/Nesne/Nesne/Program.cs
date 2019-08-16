using System;
using System.Collections.Generic;

namespace Nesne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            for (;;)
            {
                Console.WriteLine("1=> Kayıt Ekle\n2=> Kayıt Sil\n3=> Ders Ekle\n4=> Not Gir\n5=> Öğrenci Listele\n6=> Çıkış ");
                UInt16 secenek;
                secenek = UInt16.Parse(Console.ReadLine());
                switch (secenek)
                {
                    case 1:
                        Console.Write("Öğrencinin adını giriniz: ");
                        string ad = Console.ReadLine();
                        Console.Write("Öğrencinin soyadını giriniz: ");
                        string soyad = Console.ReadLine();
                        Console.Write("Öğrencinin numarasını giriniz: ");
                        string no = Console.ReadLine();
                        ogrenciler.Add(new Ogrenci(ad, soyad, no));
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Silmek istediğiniz öğrenci numarasını giriniz: ");
                        // Öğrenci Sil    
                    
                        break;
                    case 3:
                        // Ders Ekleme
                        Console.Clear();
                        break;
                    case 4:
                        //Not Gir
                        Console.Clear();
                        break;
                    case 5:
                        // Öğrencileri Listele
                        Console.Clear();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlış Bir tercih yaptınız!");
                        break;
                }
            }
        }
    }
}
