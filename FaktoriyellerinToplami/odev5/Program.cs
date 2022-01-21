using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, carpim1 = 1, carpim2 = 1;

            Console.Write("Faktöriyelini almak istediğiniz bi sayıyı giriniz: ");
            int a = int.Parse(Console.ReadLine()); 

            for (i=1; i<=a; i++)
            {
                carpim1 *= i;
            }
            Console.WriteLine(a + "! = " + carpim1);

            Console.Write("Faktöriyelini almak istediğiniz bi sayıyı giriniz: ");
            int b = int.Parse(Console.ReadLine());

            for (i=1; i<=b; i++)
            {
                carpim2 *= i;
            }
            Console.WriteLine(b + "! = " + carpim2);

            Console.WriteLine("a!+b! = " + (carpim1 + carpim2));
            Console.ReadKey();
        }
    }
}
