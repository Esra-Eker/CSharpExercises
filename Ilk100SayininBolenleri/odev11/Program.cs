using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=100; i++)
            {
                Console.Write(i + " sayısının bölenleri: ");
                for (int j=1; j<=i; j++)
                {
                    if (i%j == 0)
                    {
                        Console.Write(i / j + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
