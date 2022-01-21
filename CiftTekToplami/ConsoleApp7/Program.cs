using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, cifttoplam=0, tektoplam=0;
            Console.Write("Bi sayı gir: ");
            sayi = int.Parse(Console.ReadLine());

            while (sayi != 0)
            {
                Console.Write("Bi sayı gir: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi%2 == 0)
                {
                    cifttoplam += sayi;
                }
                else
                {
                    tektoplam += sayi;
                }
            }
            Console.WriteLine("Girilen çift sayıların toplamı: " + cifttoplam);
            Console.WriteLine("Girilen tek sayıların toplamı: " + tektoplam);

            Console.ReadKey();
        }
    }
}
