using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            int hafiza;
            int sayac = 0;

            Random rastgele = new Random();
            hafiza = rastgele.Next(1,100);

            while(tahmin != hafiza)
            {
                sayac++;
                Console.Write("Sayıyı tahmin edin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin>hafiza)
                {
                    Console.WriteLine("Daha küçük bir sayi girin.");
                }
                else if (hafiza > tahmin)
                {
                    Console.WriteLine("Daha büyük bir sayi girin.");
                }
                
            }
            Console.WriteLine("Tebrikler doğru bildiniz :)");
            Console.WriteLine("{0}. denemede buldunuz.", sayac);
            
            Console.ReadKey();

        }
    }
}
