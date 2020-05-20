using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Milli Piyango çekilişi için, 
            // 0 ile 9 arasında rastgele 6 rakam gerekmektedir. 
            // Rastgele 6 adet rakam elde edin ve 6 elemanlı diziye aktarın. 
            // Son olarak da dizi elemanlarını konsola yazdırın.

            Random rnd = new Random();         
            int[] sayilar = new int[6];

            for (int i = 0; i < sayilar.Length; i++)
            {
                int rndNum = rnd.Next(0, 9);
                sayilar[i] = rndNum;           
            }

            Console.Write("6 rakamlı rastgele piyango: ");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i]);
            }           
            Console.ReadKey();
        }
    }
}