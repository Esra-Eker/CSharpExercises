using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bi sayı gir: ");
            int sayi = int.Parse(Console.ReadLine());
            int bolen, toplam=0;

            for (int i=1; i<sayi; i++)
            {
               if(sayi%i==0)
                {
                    toplam += i;
                }
            }
            if (toplam == sayi)
            {
                Console.WriteLine("Mükemmek sayıdır.");
            }
            else
            {
                Console.WriteLine("Mükemmel sayı değildir.");
            }
            Console.ReadKey();
        }
    }
}
