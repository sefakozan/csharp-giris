using System;

namespace Alistirma11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen bir kelimenin uzunluğunu bulan metodu yazınız.
            Console.WriteLine("Alistirma 11: Girilen bir kelimenin uzunluğunu bulan metodu yazınız.");

            Console.Write("bir şey yazınız : ");
            string metin = Console.ReadLine();

            // kelimenin başında ve sonundaki boslukları Trim fonksiyonu siler.
            metin = metin.Trim();

            int uzunluk = KelimeUzunluk(metin);

            Console.WriteLine($"{metin} kelimenin uzunlugu {uzunluk}");

            Console.WriteLine("Program sonlandı.");
            Console.ReadKey();
        }
        static int KelimeUzunluk(string kelime)
        {
            int uzunluk = kelime.Length;
            return uzunluk;
        }
    }
}
