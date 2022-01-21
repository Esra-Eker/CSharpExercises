using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, carpim=1;
            Console.WriteLine("Bi sayı gir: ");
            int sayi = int.Parse(Console.ReadLine());

            while(sayi>=1)
            {

                Console.Write(sayi);

                if (sayi != 1)
                {
                    Console.Write(".");
                }
                carpim *= sayi;
                
                sayi--;
            }

            Console.WriteLine(" = " + carpim);

           
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /* Console.Write(sayi + "! = ");

            for(int z = sayi; z>=1; z--)

            {
                Console.Write(z);
                
                if (z != 1)
                {
                    Console.Write(".");
                }




            }
            Console.Write("= {0}", carpim);*/


            Console.ReadLine();
        }

    }
}
