using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayi, toplam=0;
            do
            {
                Console.Write("Sayı Gir : ");
                Sayi = int.Parse(Console.ReadLine());
                toplam += Sayi;
            } while (Sayi!=0);

            Console.WriteLine("Toplamlar = {0}", toplam);
            Console.ReadLine();
        }
    }
}
