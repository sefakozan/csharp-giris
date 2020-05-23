using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma01
{
    class Program
    {
        static void Main(string[] args)
        {
            // FB ve GS isimli 11 elemanlı iki string dizi oluşturun. 
            // Daha sonra, her iki dizinin elemanlarını konsoldan alın. 
            // Fenerbahce ve Galatasaray takımlarının ilk 11'ini öğrenin ve gerçek isimlerini girin. 
            // Son olarak, her iki dizinin elemanlarını yani yan yan yazdırın.

            // https://bit.ly/368hRfK
            Console.WriteLine("Galatasaray futbol takımı isim giriniz!..");
            string[] galatasaray = new string[11];

            for (int i = 0; i < galatasaray.Length; i++)
            {
                Console.Write($"{i+1:D2}. ismi giriniz: ");
                galatasaray[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Fenerbahce futbol takımı isim giriniz!..");
            string[] fenerbahce = new string[11];
            for (int i = 0; i < fenerbahce.Length; i++)
            {
                Console.Write($"{i + 1:D2}. ismi giriniz: ");
                fenerbahce[i] = Console.ReadLine();
            }
            Console.WriteLine("{0,-20} {1,-20} {2,-20}","Numarası","Galatasaray","Fenerbahce");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-21}", $"{i+1:D2}. futbolcu" , galatasaray[i], fenerbahce[i]);
            }

            Console.ReadKey();
        }
    }
}
