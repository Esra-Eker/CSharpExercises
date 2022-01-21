using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1 , sayi, toplam=0;
            while (i<=5)
            {
                Console.Write(i + ". sayıyı gir: ");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
                i++;
            }
            Console.WriteLine("Ortalaması: " + (double) toplam / 5);
            Console.ReadKey();
        }
    }
}
