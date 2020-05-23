using System;

namespace Alistirma06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsoldan girilen bir metni konsola alt alta 10 defa yazdıran metodu yazınız.

            Console.Write("bir sey yazınız : ");
            string metin = Console.ReadLine();

            yaz(metin);

            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();

        }
        static void yaz(string x)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}. {x}");
            }
        }
    }
}
