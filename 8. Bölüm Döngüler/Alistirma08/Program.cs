using System;

namespace Alistirma08
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 ile 100 santigrat derece arasındaki derecelerin fahrenhayt karşılıklarını konsola
            // santigrat(sekme) fahrenhayt(sekme) şeklinde alt alta yazdırınız.
            // C = (F - 32 ) / 1.8

            int C;
            double F;

            for (C = 1;  C <= 100; C++)
            {
                F = (C * 1.8) + 32;
                // https://www.csharp-examples.net/string-format-double/
                Console.WriteLine($"santigrat : {C} \t Fahrenhayt : {F:0.##}");
            }
            Console.ReadKey();
        }
    }
}
