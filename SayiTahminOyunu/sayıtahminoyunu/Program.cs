using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıtahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Etme Oyunu");
            Console.WriteLine("1 ile 10 arasında bir sayı giriniz.");
            Console.WriteLine("---------------------------------------");

            for (; ; )
            {

                Random X = new Random();
                int RastgeleSayi = X.Next(10);

                int sayi = 78, deneme = 0;
                while (sayi != RastgeleSayi)
                {
                    Console.Write("Sayıyı Tahmin Ediniz : ");
                    sayi = int.Parse(Console.ReadLine());
                    deneme++;
                }
                Console.WriteLine(deneme + ". deneme sonunda " + RastgeleSayi + " sayısını bildiniz.");               
                Console.WriteLine("Tekrar sayı girmek için bir tuşa basın.");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
