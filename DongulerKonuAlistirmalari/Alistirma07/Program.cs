using System;

namespace Alistirma07
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir dairenin alanını ve çevresini, yarıçapı 1 ile 10 arasındaki değerler için hesaplayınız,
            // ve konsola yarıçap(sekme) alan(sekme) çevre(sekme) şeklinde yazdırınız.

            Console.WriteLine("Alıştırma 7 : Bir dairenin alanını ve çevresini, yarıçapı 1 ile 10 arasındaki değerler için hesaplayınız,");
            Console.WriteLine("ve konsola yarıçap(sekme) alan(sekme) çevre(sekme) şeklinde yazdırınız.");

            double r, cevre, alan;
            const double pi = 3.14;

            for (r = 2; r < 10; r++)
            {
                alan = pi * r * r;
                cevre = 2 * pi * r;
                // https://stackoverflow.com/questions/4449021/how-can-i-align-text-in-columns-using-console-writeline
                Console.WriteLine($"yarıçap={r,-20} \t alan={alan,-20} \t çevre={cevre,-20}");
            }
            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
