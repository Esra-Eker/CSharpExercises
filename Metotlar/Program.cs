using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        // f(x) = x + 5;
        static int f(int x) // static olmasının sebebi Main den çağırabilmek istemem.
        {
            return g(x) + 5;
        }
        static int g(int k)
        {
            return t(k+2);
        }
        // t(x) = x + t(x-1)
        static int t(int x)  //recursive metot. kendi cinsinden bi şeyle ifade edildi.
        {
            if (x == 0)
                return 0;
            return x + t(x - 1);
        }
        
        static int power (int taban,int us=1)
        {
            if (us == 0)
            {
                return 1;
            }
            return taban * power(taban, us - 1);
        }
        static void powerRef(ref int sonuc, ref int sonuc2, int taban, int us) //call by reference
        {
            sonuc = taban * power(taban, us - 1);
            sonuc2 = sonuc / 2;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(1, 7));
            }

            Console.WriteLine(9 + f(2) + 3);
            Console.WriteLine(power(2));
            Console.WriteLine(power(2, 10));

            int t = 2;
            int sonuc = 0;
            int sonuc2 = 0;
            powerRef(ref sonuc, ref sonuc2, t, 10);
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.ReadKey();
        }
        
    }
}
