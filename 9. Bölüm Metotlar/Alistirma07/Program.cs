using System;

namespace Alistirma07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çalıştığında çarpım tablosunu konsola yazan metodu oluşturunuz.
            Console.WriteLine("Alıştırma 7: Çalıştığında çarpım tablosunu konsola yazan metodu oluşturunuz");

            CarpimTablosu();
            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız.");
            Console.ReadKey();
        }
        static void CarpimTablosu()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}'ler Basamağı");
                Console.WriteLine(new String('-',20));

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine(new String('*',20));
            }
        }
    }
}
