using System;

namespace Alistirma09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taban uzunluğu ve yüksekliği verilen bir üçgenin alanını hesaplayan bir metot yazınız.
            Console.WriteLine("Alistirma 9: Taban uzunluğu ve yüksekliği verilen bir üçgenin alanını hesaplayan bir metot yazınız.");

            Console.Write("üçgenin tabanını giriniz : ");
            string tabanStr = Console.ReadLine();
            int taban = int.Parse(tabanStr);

            Console.Write("üçgenin yüksekliğini giriniz : ");
            string yukseklikStr = Console.ReadLine();
            int yukseklik = int.Parse(yukseklikStr);

            int alan = AlanHesapla(taban, yukseklik);

            Console.WriteLine($"taban = {taban} , yükseklik = {yukseklik} , üçgenin alanı = {alan}");

            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız...");
            Console.ReadKey();

        }
        static int AlanHesapla(int taban , int yukseklik)
        {
            int alan = (taban * yukseklik) / 2;
            return alan;
        }
    }
}
