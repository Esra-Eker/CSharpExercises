using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bi sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi>0)
            {
                Console.WriteLine("Girilen sayı pozitiftir.");
            }
            else if (sayi<0)
            {
                Console.WriteLine("Girilen sayı negatiftir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı 0'dır");
            }
            Console.ReadLine();
        }
    }
}
