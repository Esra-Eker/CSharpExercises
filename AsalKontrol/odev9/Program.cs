using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bi sayı gir: ");
            int sayi = int.Parse(Console.ReadLine());
            bool asalkontrol = false;

            for (int i=2; i<sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalkontrol = false;
                    Console.WriteLine(sayi + " asal sayı değildir.");
                    break;
                }
                else 
                {
                    asalkontrol = true;
                }
            }
            if (asalkontrol == true)
            {
                Console.WriteLine(sayi + " asal sayıdır.");
            }
            Console.ReadKey();
        }
    }
}
