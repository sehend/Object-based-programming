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
            int sec, kac;
            List<Musteri> Musteriler = new List<Musteri>();
            string ad, soyad, musterino;

            string IBAN;
            UInt16 bankaNo, subeNo;
            bool vade;
            double faiz,nakit;
            
            for (;;)
            {
                Console.Write("******Menu******\n1-Müşteri Ekle\n2-Müşteri Sil\n3-Müşteri Listele\n4-Hesap Ekle\n5-Hesap Sil\n6-Ekran Temizle\n4-Çıkış\nSecim..");
                sec = int.Parse(Console.ReadLine());

                switch (sec)
                {
                    case 1:
                        Console.Write("Müşteri Adı   :");
                        ad = Console.ReadLine();
                        Console.Write("Müşteri Soyad :");
                        soyad = Console.ReadLine();
                        Console.Write("Müşteri No    :");
                        musterino = Console.ReadLine();
                        Musteri m = new Musteri(ad, soyad, musterino);
                        Musteriler.Add(m);
                        //müşteri ekle
                        break;
                    case 2:
                        Console.Write("silinecek müşterinin müşteri numarası :");
                        musterino = Console.ReadLine();
                        bool silindimi = false;
                        foreach (Musteri item in Musteriler)
                        {
                            if (item.MusteriNo == musterino)
                            {
                                Musteriler.Remove(item);
                                Console.WriteLine("müşteri silindi!");
                                silindimi = true;
                                break;
                            }                           
                        }
                        if (silindimi==false)
                        {
                            Console.WriteLine("Yazdığınız Müşteri Bulunamadı!!");
                        }

                        //müşteri sil
                        break;
                    case 3:
                        kac = 1;
                        Console.WriteLine("***Müşteriler***");
                        foreach (Musteri item in Musteriler)
                        {

                            //Console.WriteLine("{0}.Müşteri\nMüşteri No    : {1}",kac, item.MusteriNo);
                            //Console.WriteLine("Müşteri Adı   : {0}", item.Ad);
                            //Console.WriteLine("Müşteri Soyadı: {0}", item.Soyad);

                            Console.WriteLine("{0}.Müşteri", kac);
                            item.ToString();
                            foreach (Hesap item2 in item.Hesaplar)
                            {
                                //Console.WriteLine("IBAN     :{0}", item2.IBAN);
                                //Console.WriteLine("Banka No :{0}", item2.BankaNo);
                                //Console.WriteLine("Hesap No :{0}", item2.SubeNo);
                                //Console.WriteLine("Vade     :{0}", item2.Vade ? "vadeli" : "Vadesiz");
                                //Console.WriteLine("Miktar   :{0}", item2.Nakit);
                                //Console.WriteLine("Faiz     :{0}", item2.Faiz);
                                item2.ToString();
                            }
                            kac++;
                        }
                            //müşteri listele
                            break;
                    case 4:
                        Console.Write("Hesap Eklenecek Müşterinin Müşteri Numarası :");
                        musterino = Console.ReadLine();
                        foreach (Musteri item in Musteriler)
                        {
                            if (item.MusteriNo == musterino)
                            {
                                Console.Write("IBAN          :");
                                IBAN = Console.ReadLine();
                                Console.Write("Banka No      :");
                                bankaNo = UInt16.Parse(Console.ReadLine());
                                Console.Write("Şube No       :");
                                subeNo  = UInt16.Parse(Console.ReadLine());
                                Console.Write("Vadelimi(false,true) :");
                                vade = bool.Parse(Console.ReadLine());
                                Console.Write("Faiz :");
                                faiz = double.Parse(Console.ReadLine());
                                //Hesap h = new Hesap(IBAN, bankaNo, subeNo, vade, faiz);
                                //item.Hesaplar.Add(h); hocanın yaptığı

                                item.Hesaplar.Add(new Hesap(IBAN, bankaNo, subeNo, vade, faiz));
                            }
                        }

                        break;
                    case 5:
                        Console.Write("Hesap Silinecek necek Müşterinin Müşteri Numarası :");
                        musterino = Console.ReadLine();
                        bool silindimi3 = false;
                        foreach (Musteri item in Musteriler)
                        {
                            if (item.MusteriNo == musterino)
                            {
                                silindimi3 = true;
                                bool silindimi2 = false;
                                Console.WriteLine("Silinecek Hesabın IBAN :");
                                IBAN = Console.ReadLine();
                                foreach (Hesap item2 in item.Hesaplar)
                                {
                                    if (item2.IBAN == IBAN)
                                    {
                                        item.Hesaplar.Remove(item2);
                                        Console.WriteLine("müşteri silindi!");
                                        silindimi2 = true;
                                        break;
                                    }
                                }
                                if (silindimi2 == false)
                                {
                                    Console.WriteLine("Yazdığınız Hesap Bulunamadı!!");
                                }
                            }
                        }
                        if (silindimi3 == false)
                        {
                            Console.WriteLine("Yazdığınız Hesap Bulunamadı!!");
                        }

                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Menüde Bulunmayan bir Seçim yaptınız!");
                        break;
                }

            }
        }
    }
}
