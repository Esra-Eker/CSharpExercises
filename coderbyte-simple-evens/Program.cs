using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekcalisma
{
    class Program
    {
        //Coderbyte: Simple Evens
        public static string SimpleEvens(long num)
        {

            if (num % 2 == 0)
                return "true";
            else
                return "false";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleEvens(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
            
        }
        
    }
}
