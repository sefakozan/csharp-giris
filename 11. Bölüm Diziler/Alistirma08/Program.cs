using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma08
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 satırlı ve iki sütünlu a ve b matrisi
            int[,] aMatris = new int[3, 2];
            int[,] bMatris = new int[3, 2];

            // a matrisi doldur
            BaslikYaz("A Matrisi Değerlerini Giriniz");
            MatrisDoldur(aMatris);

            // b matrisi doldur
            BaslikYaz("B Matrisi Değerlerini Giriniz");
            MatrisDoldur(bMatris);

            // a ve b matrikslerini çarp
            int[,] sonuc = CarpMatris(aMatris, bMatris);

            // sonuçları ekrana yaz
            //// a matriksini yaz
            BaslikYaz("A Matrisi");
            MatrisYaz(aMatris);

            //// b matriksini yaz
            BaslikYaz("B Matrisi");
            MatrisYaz(bMatris);

            //// iki matriksin çarpımını yaz
            BaslikYaz("Sonuc Matrisi");
            MatrisYaz(sonuc);

            Console.WriteLine("Program sonlandı, çıkmak için herhangi bir tuşa basınız!..");
            Console.ReadKey();
        }
        static void MatrisDoldur(int[,] Matris)
        {
            for (int i = 0; i < 3; i++) // satir
            {
                for (int j = 0; j < 2; j++) // sütün
                {
                    Console.Write($"{i}. elemanın {j}. Değerini Giriniz: ");
                    string degerStr = Console.ReadLine();
                    int deger = Convert.ToInt32(degerStr);
                    Matris[i, j] = deger;
                }
            }
        }

        static int[,] CarpMatris(int[,] aMatris , int[,] bMatris)
        {
            int[,] sonuc = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sonuc[i, j] = aMatris[i, j] * bMatris[i, j];
                }
            }
            return sonuc;
        }

        static void MatrisYaz(int[,] Matris)
        {         
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int deger = Matris[i,j];

                    Console.Write($"{deger,-10} ");
                }
                Console.WriteLine();
            }
        }
        static void BaslikYaz(string yazı)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("# {0}", yazı);
            Console.WriteLine(new string('-', 50));
        }
    }
}
