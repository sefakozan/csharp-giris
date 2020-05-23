using System;

namespace Alistirma03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 ile N arasındaki cift sayıların toplamını bulunuz.

            Console.Write("n değerini giriniz : ");
            string satir1Str = Console.ReadLine();
            int satir1Int = int.Parse(satir1Str);

            int top = 0;
            for (int i = 0; i < satir1Int; i = i + 2)
                top = top + i;

            Console.WriteLine($"0'dan N'e kadar olan çift sayıların toplamı : {top}");

            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
