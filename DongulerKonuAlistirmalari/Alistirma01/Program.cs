using System;

namespace Alistirma01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 ile 10 arasındaki çift sayıları konsolda alt alta yazdırınız.
            Console.WriteLine("Soru 1 : 0 ile 10 arasındaki çift sayıları konsolda alt alta yazdır.");


            for (int i = 0; i < 10; i = i + 2) // i += 2 şeklinde de yazılabilir.
            {
                Console.WriteLine(i);
            }

            // sayaç birer birer de artırılabilir.
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i%2 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            Console.ReadKey();
        }
    }
}
