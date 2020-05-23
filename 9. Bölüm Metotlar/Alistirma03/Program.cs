using System;

namespace Alistirma03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsoldan okunan iki sayıdan büyük olanı konsola yazan metodu yazınız.

            Console.Write("bir sayi giriniz : ");
            string sayi1Str = Console.ReadLine();
            int sayi1Int = Convert.ToInt32(sayi1Str);

            Console.Write("bir sayi giriniz : ");
            string sayi2Str = Console.ReadLine();
            int sayi2Int = Convert.ToInt32(sayi2Str);


             isBuyuk(sayi1Int, sayi2Int);

            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız...");

            Console.ReadKey();
        }
        static void isBuyuk(int x , int y)
        {
            if (x > y)
                Console.WriteLine($"büyük sayi {x} , küçük sayi {y}");
            else
                Console.WriteLine($"büyük sayi {y} , küçük sayi {x}");
        }
    }
}
