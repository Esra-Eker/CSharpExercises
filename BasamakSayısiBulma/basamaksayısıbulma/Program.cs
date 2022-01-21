using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basamaksayısıbulma
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                //Benim düşündüğüm yol:
                //Büyük girilen değerler için int yerine long kullanınca ifin içinde hata veriyor!
                /*int sayi, sayac = 1;
                 bool kontrol = true;
                 Console.Write("Bi sayı gir: ");
                 sayi = int.Parse(Console.ReadLine());

                 for (int i = 10; i <= sayi; i = i * 10)
                 {
                     if (sayi % i >= 0 && sayi % i <= i)
                     {
                         kontrol = true;
                     }
                     sayac++;
                 }
                 if (kontrol == true)
                 {
                     Console.WriteLine("Girilen sayı " + sayac + " basamaklıdır.");
                 }*/

                //Barış'ın gösterdiği yol:
                long sayi, basamak = 0;
                Console.Write("Bi sayı gir: ");
                sayi = long.Parse(Console.ReadLine());

                while (sayi>=1)
                {
                    sayi /= 10;
                    basamak++;
                }
                Console.WriteLine(basamak);
            }
            Console.ReadKey();
        }
    }
}
