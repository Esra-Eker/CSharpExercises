using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int onceki = 1, sonraki=1;
            Console.WriteLine(onceki);

            for (; ; )
            {
                Console.WriteLine(sonraki);
                sonraki = onceki + sonraki;
                onceki = sonraki - onceki;
                
            }
            Console.ReadLine();

        }
    }
}
