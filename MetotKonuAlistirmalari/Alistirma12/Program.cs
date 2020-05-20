using System;

namespace Alistirma12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çarpma işlemini toplama kullanarak yapan metodu yazınız.
            Console.WriteLine("Alıştırma 12: Çarpma işlemini toplama kullanarak yapan metodu yazınız.");

            Console.Write("birinci sayıyı giriniz: ");
            string num1Str = Console.ReadLine();
            int num1 = int.Parse(num1Str);

            Console.Write("ikinci sayıyı giriniz: ");
            string num2Str = Console.ReadLine();
            int num2 = int.Parse(num2Str);

            int sonuc = Carp(num1, num2);

            Console.WriteLine($"iki sayinin toplama ile metod ile yapımı {sonuc}");

            Console.WriteLine("Program sonlandı.");
            Console.ReadKey();
        }
        static int Carp(int num1 , int num2)
        {
            int top = 0;

            for (int i = 1; i <= num2 ; i++)
            {
                top = top + num1;
            }

            return top;
        }
    }
}
