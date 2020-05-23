using System;

namespace Alistirma02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen iki sayının toplamını ve çarpımını dondüren metodu yazınız.

            Console.Write("sayi giriniz : ");
            string sayi1Str = Console.ReadLine();
            int sayi1Int = int.Parse(sayi1Str);

            Console.Write("sayi giriniz : ");
            string sayi2Str = Console.ReadLine();
            int sayi2Int = int.Parse(sayi2Str);

            string sonuc = ToplaCarp(sayi1Int, sayi2Int);

            Console.WriteLine(sonuc);
            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }
        static string ToplaCarp(int x, int y)
        {
            int top = x + y;
            int carpim = x * y;


            return $"toplam:{top} çarpım:{carpim}";
        }
    }
}
