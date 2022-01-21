using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int max = 0;
            Console.Write("Sayı gir: ");
            sayi = int.Parse(Console.ReadLine());
            int min = sayi;
            for (; ; )
            {
                Console.Write("Sayı gir: ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi !=0)
                {
                    if (sayi > max)
                    {
                        max = sayi;
                    }
                    if (min > sayi)
                    {
                        min = sayi;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(max + " en büyük sayıdır.");
            Console.WriteLine(min + " en küçük sayıdır.");
            Console.ReadKey();
        }
    }
}
