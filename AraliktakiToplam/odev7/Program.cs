using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bi sayı gir: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Bi sayı gir: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sayitoplam = 0;
            if (sayi1 <= sayi2)
            {
                for (int i = sayi1+1; sayi1+1 < sayi2; sayi1++)
                {
                    Console.WriteLine(sayi1+1);
                    sayitoplam += sayi1+1;
                }
            }
            else
            {
                for (int i = sayi2+1; sayi2+1 < sayi1; sayi2++)
                {
                    Console.WriteLine(sayi2+1);
                    sayitoplam += sayi2+1;
                }
            }
            Console.WriteLine("Girilen aralıktaki sayıların toplamı: " + sayitoplam);
            Console.ReadLine();
        }
    }
}
