using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permütasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (; ; )
            {
                int n, r, carpim1 = 1, carpim2 = 1;
                Console.Write("n değerini gir: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("r değerini gir: ");
                r = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    carpim1 *= i;
                }

                for (int i = 1; i <= (n - r); i++)
                {
                    carpim2 *= i;
                }
                Console.WriteLine("P(n,r)= " + "P(" + n + "," + r + ")= " + (carpim1 / carpim2));
            }

            Console.ReadLine();*/

            for (; ; )
            {
                int n, r, i = 1, j = 1, carpim1 = 1, carpim2 = 1;
                Console.Write("n değerini gir: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("r değerini gir: ");
                r = int.Parse(Console.ReadLine());

                while (i <= n)
                {
                    carpim1 *= i;
                    i++;
                }
                while (j <= (n - r))
                {
                    carpim2 *= j;
                    j++;
                }
                Console.WriteLine("P(n,r)= " + "P(" + n + "," + r + ")= " + (carpim1 / carpim2));
            }
            Console.ReadLine();


        }
    }
}
