using System;

namespace Alistirma06
{
    class Program
    {
        static void Main(string[] args)
        {
            // x = 2a-b formulunde, a ve b parametrelerinin değerlerini 1 ile 10 arasında değiştirerek,
            // x değişkeninin alacağı değerleri konsola, x(sekme) a(sekme) b şeklinde yazdırdınız.

            Console.WriteLine("Alıştırma 6 : x = 2a-b formulunde, a ve b parametrelerinin değerlerini 1 ile 10 arasında değiştirerek,");
            Console.WriteLine("x değişkeninin alacağı değerleri konsola, a(sekme) b(sekme) x(sekme) şeklinde yazdırdınız");
            double x;

            for (double a = 1; a <= 10; a++)
            {
                Console.WriteLine($"\na = {a} için");
                for (double b = 1; b <= 10 ; b++)
                {
                    x = 2 * a - b;
                    Console.WriteLine($"a={a} \t b={b} \t x={x}");
                }
            }
            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
