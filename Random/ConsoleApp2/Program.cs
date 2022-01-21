using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random X = new Random();

            for (int i = 0; i < 1000; i++)
            {

                int UretilenRastgeleSayi = X.Next(9,20); // 10 dahil 20 dahil değil.
                Console.WriteLine(UretilenRastgeleSayi);
            }
                               

            
            Console.ReadKey();

        }
    }
}
