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
            // 10 kişilik bir sınıfta,
            // her öğrencinin adını ve ders notunu okuyan iki boyutlu bir dizi oluşturun.
            // Daha sonra da, isim ve ders notlarını konsola yazdırın.

            // 10 satır, 2 sütun
            string[,] bilgiler = new string[10, 2];
            int sira = 1;

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{sira++}. Öğrenci Adını Giriniz: ");
                string ad = Console.ReadLine();

                Console.WriteLine("Öğrenci Notunu Giriniz: ");
                string not = Console.ReadLine();

                bilgiler[i, 0] = ad;
                bilgiler[i, 1] = not;

            }

            Console.WriteLine(new String('=', 65));
            Console.WriteLine("{0,30} {1,30}", "Öğrenci İsimleri", "Öğrenci Notları");

            for (int i = 0; i < 10; i++)
            {
                string ad = bilgiler[i, 0];
                string not = bilgiler[i, 1];
                int siraNo = i + 1;
                Console.WriteLine("{0,-20} {1,-30} {2,-30}", $"{siraNo:D2}. öğrenci", ad, not);
            }


            Console.ReadKey();
        }
    }
}
