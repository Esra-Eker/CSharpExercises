using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanknotHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paranızı girin: ");
            int para = Convert.ToInt32(Console.ReadLine());
            
            int a=0, b=0, c=0, d=0, e=0, f=0;

            if (200 <= para)
            {
                a = para / 200;
                para = para % 200;
            }
            if (100 <= para)
            {
                b = para / 100;
                para = para % 100;
            }
            if (50 <= para)
            {
                c = para / 50;
                para = para % 50;
            }
            if (20 <= para)
            {
                d = para / 20;
                para = para % 20;
            }
            if (10 <= para)
            {
                e = para / 10;
                para = para % 10;
            }
            if(5 <= para)
            {
                f = para / 5;
                para = para % 5;
            }
                                                                  
            if (a != 0)            
                Console.WriteLine(a + " adet 200");
            if (b != 0)
                Console.WriteLine(b + " adet 100");
            if (c != 0)
                Console.WriteLine(c + " adet 50");
            if (d != 0)
                Console.WriteLine(d + " adet 20");
            if (e != 0)
                Console.WriteLine(e + " adet 10");
            if (f != 0)
                Console.WriteLine(f + " adet 5");

            Console.ReadLine();
        }
    }
}
