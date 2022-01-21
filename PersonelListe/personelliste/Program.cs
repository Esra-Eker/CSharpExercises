using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelliste
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Personel " + i);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ad Soyad: ");
                string adsoyad = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Yaş: ");
                int yas = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Pozisyon: ");
                string poz = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
