using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bi sayı gir: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write("Bölenleri: ");
            for (int i=1; i<=sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.Write((sayi / i) + " ");
                }
                             
            }
            Console.ReadLine();
        }
    }
}
