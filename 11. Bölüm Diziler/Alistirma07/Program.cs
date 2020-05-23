using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir önceki alıştırmadaki öğrencilerin,
            // aldığı en büyük notu bulun ve öğrencinin adını konsola yazdırın.

            string[,] sinif = new string[10, 2];
            int sira = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{sira++}. Öğrenci Adını Giriniz: ");
                string ad = Console.ReadLine();

                Console.Write("Öğrenci Notunu Giriniz: ");
                string not = Console.ReadLine();

                sinif[i, 0] = ad;
                sinif[i, 1] = not;
            }

            Console.WriteLine(new String('=', 65));
            Console.WriteLine("{0,30} {1,30}", "Öğrenci İsimleri", "Öğrenci Notları");

            for (int i = 0; i < 10; i++)
            {
                string ad = sinif[i, 0];
                string not = sinif[i, 1];
                int siraNo = i + 1; 
                Console.WriteLine("{0,-20} {1,-30} {2,-30}", $"{siraNo:D2}. öğrenci", ad, not);
            }

            int index = MaxValueIndex(sinif);
            string maxAd = sinif[index, 0];
            string maxNot = sinif[index, 1];

            Console.WriteLine($"En Yüksek Notu Alan Öğrenci: {maxAd}");
            Console.WriteLine($"Öğrencinin Notu: {maxNot}");
            Console.WriteLine("Tebrikler!!!!!!!");

            Console.ReadKey();
        }
        /// <summary>
        /// Fonkisyon en büyük değerin indeksini dönecek.
        /// En büyük puanı almış öğrenciyi bulacak.
        /// Bulunan öğrencinin satır indeksini dönecek.
        /// </summary>
        /// <param name="bilgiler"> iki boyutlu dizi alacak 0. indeks adı, 1. indeks öğrencinin notu</param>
        /// <returns></returns>
        static int MaxValueIndex(string[,] bilgiler)
        {
            int maxNot = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                string notStr = bilgiler[i, 1];
                int not = Convert.ToInt32(notStr);

                if (not > maxNot)
                {
                    maxNot = not;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
