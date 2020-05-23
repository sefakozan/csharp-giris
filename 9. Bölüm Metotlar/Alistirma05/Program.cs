using System;

namespace Alistirma05
{
    class Program
    {
        static void Main(string[] args)
        {
            // X'in karekökünü hesaplayan metodu oluşturunuz.

            Console.Write("sayi giriniz : ");
            string sayiStr = Console.ReadLine();
            int sayiInt = int.Parse(sayiStr);

            double karekokMath = KarekokMath(sayiInt);
            Console.WriteLine($"{sayiInt} sayisinin karekökü math {karekokMath}");


            double karekok = Karekok(sayiInt);
            Console.WriteLine($"{sayiInt} sayisinin karekökü {karekok}");

            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
        }
        static double KarekokMath(int x)
        {
            double karekok = Math.Sqrt(x);
            return karekok;
        }

        static double Karekok(int x) 
        {
            //https://bit.ly/2LPtU8u

            int number = x;
            double root = 1;
            int i = 0;
            //The Babylonian Method for Computing Square Roots
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1) { break; }
            }

            return root;
        }
    }
}
