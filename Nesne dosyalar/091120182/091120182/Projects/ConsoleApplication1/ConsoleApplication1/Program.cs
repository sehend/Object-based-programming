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
            int ogrencin = 0, ogretmenn = 0, yoneticin = 0;
            Student[] ogrenci = new Student[20];
            Teacher[] ogretmen = new Teacher[4];
            Manager[] yonetici = new Manager[2];
            Person bb = new Person();

            byte secim;
            baslangic:
            Console.WriteLine("1.Öğrenci Kaydet");
            Console.WriteLine("2.Öğretmen Kaydet");
            Console.WriteLine("3.Yönetici Kaydet");
            Console.WriteLine("4.Öğrenci Listele");
            Console.WriteLine("5.Öğretmen Listele");
            Console.WriteLine("6.Yönetici Listele");
            Console.WriteLine("7.Sınıf Listele");
            secim = Convert.ToByte(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    ogrenci[ogrencin] = new Student();
                    Console.WriteLine("Öğrencinin,");
                    Console.Write("Adı :");
                    ogrenci[ogrencin].Name = Console.ReadLine();
                    Console.Write("Soyadı :");
                    ogrenci[ogrencin].Surname = Console.ReadLine();
                    Console.Write("Okul Numarası:");
                    ogrenci[ogrencin].SNumber = Convert.ToUInt64(Console.ReadLine());
                    ogrencin++;
                    goto baslangic;
                    break;
                case 2:
                    ogretmen[ogretmenn] = new Teacher();
                    Console.WriteLine("Öğretmenin,");
                    Console.Write("Adı :");
                    ogretmen[ogretmenn].Name = Console.ReadLine();
                    Console.Write("Soyadı :");
                    ogretmen[ogretmenn].Surname = Console.ReadLine();
                    Console.Write("Şubesi (A,B,C,D) :");
                    ogretmen[ogretmenn].Sube = Console.ReadLine();
                    ogretmenn++;
                    goto baslangic;
                    break;
                case 3:
                    yonetici[yoneticin] = new Manager();
                    Console.WriteLine("Yöneticinin,");
                    Console.Write("Adı :");
                    yonetici[yoneticin].Name = Console.ReadLine();
                    Console.Write("Soyadı :");
                    yonetici[yoneticin].Surname = Console.ReadLine();
                    Console.Write("Pozisyon (Müdür/MüdürYdr) :");
                    yonetici[yoneticin].Pozisyon = Console.ReadLine();
                    yoneticin++;
                    goto baslangic;
                    break;
                case 4:
                    for (int i = 0; i < 20; i++)
                    {
                        ogrenci[i] = new Student();
                        Console.WriteLine(i+1+".Öğrenci");
                        Console.WriteLine("Adı :"+ ogrenci[i].Name);
                        Console.WriteLine("Soyadı :"+ ogrenci[i].Surname);
                    }
                    goto baslangic;
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                
            }

            Console.ReadKey();

        }
    }
}
