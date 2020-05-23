using System;

namespace Alistirma01
{
    class Program
    {
        static void Main(string[] args)
        {
            // iki sayinin çarpımı yapan metodu yazınız.

            Console.Write("bir sayi giriniz : ");
            string sayiStr = Console.ReadLine();
            int sayiInt = int.Parse(sayiStr);

            Console.Write("bir sayi giriniz : ");
            string sayi1Str = Console.ReadLine();
            int sayi1Int = int.Parse(sayi1Str);

            int carpilanSayilar = Carp(sayiInt, sayi1Int);

            Console.WriteLine($"{sayiInt} x {sayi1Int} = {carpilanSayilar}");

            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız...");
            Console.ReadKey();

        }

        static int Carp(int x , int y)
        {
            int kare = x * y;
            return kare;
        }
    }
}
