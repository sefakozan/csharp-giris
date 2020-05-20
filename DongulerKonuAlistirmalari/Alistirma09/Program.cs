using System;

namespace Alistirma09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan başlangıç değerini,bitiş değerini ve artış değerini alarak, 
            // başlangıç ile bitiş arasındaki sayıları konsola yazdırınız.
            Console.WriteLine("Alıştırma 9 : Kullanıcıdan başlangıç değerini,bitiş değerini ve artış değerini alarak,");
            Console.WriteLine("başlangıç ile bitiş arasındaki sayıları konsola yazdırınız.");

            Console.Write("sayı kaçtan başlasın : ");
            string baslangicStr = Console.ReadLine();
            int baslangicInt = int.Parse(baslangicStr);

            Console.Write("sayı kaçla bitsin : ");
            string bitisStr = Console.ReadLine();
            int bitisInt = int.Parse(bitisStr);

            Console.Write("artış değerini giriniz : ");
            string artisStr = Console.ReadLine();
            int artisInt = int.Parse(artisStr);

            for (int i = baslangicInt; i <= bitisInt; i = i + artisInt)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();


        }
    }
}
