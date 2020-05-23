using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 kişilik bir sınıfta okuyan öğrencilerin yılsonu notlarını konsoladan okuyun.
            // Notların ortalamasını bulun ve konsola yazdırın.

            int[] ogrencilernotu = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. öğrencinin yılsonu notu: ");
                string notlarStr = Console.ReadLine();
                ogrencilernotu[i] = Convert.ToInt32(notlarStr);
                
                if (ogrencilernotu[i] > 100 || ogrencilernotu[i] < 0)
                {
                    Console.WriteLine("Hatalı not girdiniz!!!!");
                    i--;
                    continue;
                }
            }

            double ort = OrtalamaBul(ogrencilernotu);
            Console.WriteLine($"10 öğrencinin yılsonu notu ortalaması: {ort}");

            Console.ReadKey();
        }
        static double OrtalamaBul(int[] dizi)
        {
            double top = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                top = top + dizi[i];
            }

            double ort = top / dizi.Length;
            return ort;
        }
    }
}
