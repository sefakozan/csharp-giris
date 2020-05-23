using System;

namespace Alistirma05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsoldan okunan 5 adet sayının ortalamasını bulunuz.

            int toplananlar = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}. sayıyı giriniz : ");
                string okunanStr = Console.ReadLine();
                int okunanInt = Convert.ToInt32(okunanStr);

                toplananlar = toplananlar + okunanInt;
                //toplananlar += okunanInt;
            }

            int ort = toplananlar / 5;
            Console.WriteLine($"beş sayının ortalaması : {ort}");

            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
