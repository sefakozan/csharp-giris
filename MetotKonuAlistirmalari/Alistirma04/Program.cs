using System;

namespace Alistirma04
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir sayının (x) y. kuvvetini alan metodu yazınız.
            Console.WriteLine("Alistirma 4:  Bir sayının (x) y. kuvvetini alan metodu yazınız.");

            Console.Write("sayi giriniz : ");
            string sayiStr = Console.ReadLine();
            int sayi = Convert.ToInt32(sayiStr);

            Console.Write("sayi giriniz : ");
            string kuvvetStr = Console.ReadLine();
            int kuvvet = Convert.ToInt32(kuvvetStr);

            int sayininKuvveti = KuvvetAl(sayi, kuvvet);

            Console.WriteLine($"{sayi} sayisinn {kuvvet}. kuvveti = {sayininKuvveti}");

            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
        static int KuvvetAl(int sayi , int kuvvet)
        {
            int sayininKuvveti = 1;

            for (int i = 1; i <= kuvvet; i++)
            {
                sayininKuvveti = sayininKuvveti * sayi;
            }

            return sayininKuvveti;
        }
    }
}
