using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalcarpanbulma
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi, bolen=2;
            Console.Write("Bi sayı gir: ");
            sayi = int.Parse(Console.ReadLine());

            while (bolen<=sayi)
            {
                if (sayi%bolen == 0)
                {
                    sayi /= bolen;
                }
                    
                        
                        
                        
            }















            /*int i = 2, j = 2, sayi;
            bool asalkontrol = false;

            for (; ; )
            {
                Console.Write("Bi sayı gir: ");
                sayi = int.Parse(Console.ReadLine());
                Console.Write("Asal çarpanları: ");

                while ((sayi % i) == 0)
                {
                    for (j = 2; j < sayi%i; j++)
                    {
                        if ((sayi/i) % j == 0)
                        {
                            asalkontrol = false;
                            break;
                        }
                        else
                        {
                            asalkontrol = true;
                        }
                    }
                    if (asalkontrol == true)
                    {
                        Console.WriteLine(sayi/j);
                    }
                }
                Console.ReadKey();
            }*/
        }
    }
}
