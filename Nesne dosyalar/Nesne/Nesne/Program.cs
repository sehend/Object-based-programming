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
                Console.WriteLine("1=> Kayıt Ekle\n2=> Kayıt Sil\n3=> Ders Ekle\n4=> Not Gir\n5=> Öğrenci Listele\n6=> ortalama goster\n7=> çıkış ");
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
                        int ct = 0;
                        Console.WriteLine("Silmek istediğiniz öğrenci numarasını giriniz: ");
                        string no3 = Console.ReadLine();

                        //for (int j = 0; j < ogrenciler.Capacity-1; j++)
                        //{
                        //    if (no3 == ogrenciler[j].No)
                        //    {
                        //        ogrenciler.Remove(ogrenciler[j]);
                        //      //  ct = 1;
                        //    }
                        //}

                        foreach (Ogrenci itemcik in ogrenciler)
                        {
                            if (no3 == itemcik.No)
                            {
                                ogrenciler.Remove(itemcik);
                                ct = 1;
                            }

                        }
                        if (ct != 1)
                        {
                            Console.WriteLine("Böyle bir öğrenci yok !");
                        }
                        else
                        {
                            ct = 0;
                        }



                        // Öğrenci Sil    

                        break;
                    case 3:
                        Console.WriteLine("öğrencinin numarasını girin..");
                        string no2 = Console.ReadLine();

                        foreach (Ogrenci item in ogrenciler)
                        {
                            if (item.No == no2)
                            {
                                Console.Write("Dersin kodu :");
                                string kod = Console.ReadLine();
                                Console.Write("Dersin Adı :");
                                string ad2 = Console.ReadLine();
                                Console.Write("dersin kredisi :");
                                UInt16 kredi = UInt16.Parse(Console.ReadLine());
                                Console.Write("ders saati :");
                                UInt16 saat = UInt16.Parse(Console.ReadLine());
 
                                Ders d = new Ders(kod, ad2, kredi, saat);

                                item.Dersler.Add(d);
                                
                            }
                            //else
                            //{
                            //    Console.WriteLine("Böyle bir öğrenci yok!");
                            //}
                        }
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        int ct2 = 0;
                        Console.WriteLine("Notunu Girmek istediğiniz öğrenci numarasını giriniz: ");
                        string no4 = Console.ReadLine();

                        foreach (Ogrenci item in ogrenciler)
                        {
                            if (no4 == item.No)
                            {
                                //int i=1;

                                foreach (Ders item2 in item.Dersler)
                                {
                                    Console.WriteLine("{0} kodlu dersin notunu giriniz..",item2.Kod);
                                    item2.Not = Int16.Parse(Console.ReadLine());

                                }
                                ct2 = 1;
                            }
                           

                        }
                        if (ct2 != 1)
                        {
                            Console.WriteLine("Böyle bir öğrenci yok !");
                        }
                        else
                        {
                            ct2 = 0;
                        }

                        //Not Gir
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        int on = 1;
                        foreach (Ogrenci item in ogrenciler)
                        {
                            Console.WriteLine("{0}.öğrenci\nAd :{1}\nSoyad :{2}\n No: {3}\n", on, item.Ad, item.Soyad,item.No);
                            on++;
                        }


                        // Öğrencileri Listele
                     //   Console.Clear();
                        break;
                    case 6:

                        Console.Clear();
                        int onn = 1;                   
                        foreach (Ogrenci item in ogrenciler)
                        {
                            Console.WriteLine("{0}.öğrenci\n{1} {2}\n öğrencinin ortalaması : {3}\n", onn,item.Ad,item.Soyad, item.Ortalama());
                            onn++;
                        }
                       


                        //ortalama göster
                        break;
                    case 7:
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
