using System;

namespace Alistirma02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 ile N arasındaki çift sayıları konsolda yan yana 1 sekme aralık (\t) vererek yazdırınız.
            Console.WriteLine("Soru 2 : 0 ile N arasındaki çift sayıları konsolda yan yana 1 sekme aralık (\\t) vererek yazdırınız.");
            Console.Write("n değerini giriniz : ");
            string satirStr = Console.ReadLine();
            int satirInt = int.Parse(satirStr);

            for (int i = 0; i < satirInt; i = i + 2)
            {
                Console.Write($"{i} \t");
            }

            Console.ReadKey();
        }
    }
}
