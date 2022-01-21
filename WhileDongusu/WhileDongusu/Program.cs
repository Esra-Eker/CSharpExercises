using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 1, top=0;

            while(sayi != 0)
            {
                Console.WriteLine("Sayı Gir : ");
                sayi = int.Parse(Console.ReadLine());

                top += sayi;
            }


            Console.WriteLine("Girdiğiniz Sayıların Toplamları = {0}", top);

            Console.ReadLine();





        }
    }
}
