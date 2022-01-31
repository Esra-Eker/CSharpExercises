using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOrnek
{
    class Program
    {
        public static int Cıkar(int sayi1,int sayi2)
        {
            int c = sayi1 - sayi2;
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("İşlemin sonucu: " + Cıkar(7, 5));
            Console.ReadLine();
        }
    }
}
