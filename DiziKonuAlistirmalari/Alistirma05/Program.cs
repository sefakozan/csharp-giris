using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir zar 100 defa atılmaktadır. 
            // Hangi değerlerin kaç defa geldiğini dizi kullanarak bir program yazınız.

            Random rnd = new Random();

            int[] zarDegerleri = new int[100];


            for (int i = 0; i < zarDegerleri.Length; i++)
            {
                int rndNum = rnd.Next(1, 7);
                zarDegerleri[i] = rndNum;
            }

            for (int i = 1; i <= 6; i++)
            {
                int kacTane = KacTaneVar(zarDegerleri, i);
                Console.WriteLine($"{i} sayisindan {kacTane} tane var");
            }

            Console.ReadKey();
        }

        //paremetre olarak aldığı dizi içinde kaç tane sayi oldugunu bulacak.
        static int KacTaneVar(int [] dizi, int sayi)
        {
            int sayac = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (sayi == dizi[i])
                {
                    sayac++;
                } 
            }                  

            return sayac;
        } 
    }
}
