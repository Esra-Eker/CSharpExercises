using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            for (; ; )
            {
                int sayi, toplam=0;
                double ort = 0;

                
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Bi sayı gir: ");
                    sayi = int.Parse(Console.ReadLine());

                    toplam += sayi;
                }
                ort = toplam / 10.0;
                Console.WriteLine("Ortalama: " + ort);

                Console.WriteLine("Devam Etmek İçin Herhangi Bir Tuşa Bas..");
                Console.ReadKey();

            }
            Console.ReadKey();
        }       
           
            
        
    }
}
