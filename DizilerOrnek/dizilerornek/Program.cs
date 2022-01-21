using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            for (int  i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayı Gir : ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }


            foreach(int sayi in sayilar)
            {
                if(sayi%2==0)
                {
                    Console.WriteLine(sayi);
                }
            }
            Console.ReadLine();

           

        }
    }
}
