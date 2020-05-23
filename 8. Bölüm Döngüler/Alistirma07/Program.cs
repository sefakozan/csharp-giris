using System;

namespace Alistirma07
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir dairenin alanını ve çevresini, yarıçapı 1 ile 10 arasındaki değerler için hesaplayınız,
            // ve konsola yarıçap(sekme) alan(sekme) çevre(sekme) şeklinde yazdırınız.

            double r, cevre, alan;
            const double pi = 3.14;

            for (r = 2; r < 10; r++)
            {
                alan = pi * r * r;
                cevre = 2 * pi * r;
                // https://bit.ly/2WVZgk7
                Console.WriteLine($"yarıçap={r,-20} \t alan={alan,-20} \t çevre={cevre,-20}");
            }
            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
