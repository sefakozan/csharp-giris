using System;

namespace Alistirma07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çalıştığında çarpım tablosunu konsola yazan metodu oluşturunuz.

            CarpimTablosu();
           
            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız.");
            Console.ReadKey();
        }
        static void CarpimTablosu()
        {
            for (int i = 1; i <= 10; i++)
            {
                XlerTablosunuYazdir(i);
            }
        }
        static void XlerTablosunuYazdir(int x)
        {
            Console.WriteLine(new String('*', 20));
            Console.WriteLine($"{x}'ler Tablosu");
            Console.WriteLine(new String('-', 20));

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x} x {i} = {x*i}");
            }
        }
    }
}
