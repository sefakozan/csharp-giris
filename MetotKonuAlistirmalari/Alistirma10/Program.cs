using System;

namespace Alistirma10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yarıçapı verilen bir çemberin alanını hesaplayan bir metot yazınız.
            Console.WriteLine("Alıştırma 10: Yarıçapı verilen bir çemberin alanını hesaplayan bir metot yazınız.");

            Console.Write("çemberin yarıçapını giriniz: ");
            string yarıcapStr = Console.ReadLine();
            double yarıcap = int.Parse(yarıcapStr);

            double alan = AlanHesapla(yarıcap);

            Console.WriteLine($"çemberin alanı = {alan}");

            Console.WriteLine("Program sonlandı. Çıkmak için bir tusa basınız.");
            Console.ReadKey();
        }
        static double AlanHesapla(double yarıcap)
        { 
            return Math.PI * yarıcap * yarıcap;
        }
    }
}
