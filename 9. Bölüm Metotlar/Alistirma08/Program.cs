using System;

namespace Alistirma08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kilo ile boy arasındaki fark 10 yada küçükse 'normal' daha büyükse 'fazla'
            // değerlerini döndüren metodu yazınınız. Örneğin kişinin boyu 1.85m ve kilosu
            // 90 ise (85-90) hesabıyla işlem yapınız.
            Console.WriteLine("Alıştırma 8: Kilo ile boy arasındaki fark 10 yada küçükse 'normal' daha büyükse 'fazla'");
            Console.WriteLine("değerlerini döndüren metodu yazınınız. Örneğin kişinin boyu 1.85cm ve kilosu");
            Console.WriteLine("90 ise (85-90) hesabıyla işlem yapınız.");

            

            Console.Write("kilonuzu giriniz : ");
            string kiloStr = Console.ReadLine();
            double kilo = double.Parse(kiloStr);

            Console.Write("boyunuzu giriniz : ");
            string boyStr = Console.ReadLine();
            double boy = double.Parse(boyStr);

            double cm = boy * 100;
            boy = cm - 100;

            string oran = KiloBoyHesabi(kilo, boy);

            Console.WriteLine(oran);
            Console.ReadKey();
        }
        static string KiloBoyHesabi(double kilo , double boy)
        {
            if (kilo - boy <= 10 && kilo - boy > 0 || boy - kilo <= 10 && boy - kilo > 0)
            {
                return "normal";
            }
            else
            {
                return "fazla";
            }
        }
    }
}
