using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, toplam=0;

            Console.Write("Bi sayı gir: ");
            int sayi = int.Parse(Console.ReadLine());

            while (sayi%i ==0)
            {
                toplam += i;
                i++;
            }
            Console.WriteLine(toplam + sayi);
            Console.ReadLine();
        }

    }
}
