using System;

namespace Alistirma04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 hariç 1 ile 10 arasındaki sayıların toplamını bulunuz.
            Console.WriteLine("Alıştırma 4 : 5 hariç 1 ile 10 arasındaki sayıların toplamını bulunuz.");

            int toplam = 0;
            for (int i= 2; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                toplam = toplam + i;
            }
            Console.WriteLine($"toplanan sayilar : {toplam}");

            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
