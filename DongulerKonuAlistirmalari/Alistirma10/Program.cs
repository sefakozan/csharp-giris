using System;

namespace Alistirma10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alıştırma 10 : Çarpım tablosunu konsola yazdırınız.
            Console.WriteLine("Alıştırma 10 : Çarpım tablosunu konsola yazdırınız.");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}'ler Basamağı");
                // https://stackoverflow.com/questions/13456665/how-to-print-the-same-character-many-times-with-console-writeline
                Console.WriteLine(new String('-', 20));
                Console.WriteLine();

                for (int j = 1 ; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = { i * j}");
                }
                Console.WriteLine();
                Console.WriteLine(new String('*',20));
            }
            Console.ReadKey();
        }
    }
}
