using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi=1, sayitoplam=0, sayac=0;
            for (; ; )
            {
                if (sayi != 0)
                {
                    Console.Write("Bi sayi gir: ");
                    sayi = double.Parse(Console.ReadLine());

                    sayitoplam += sayi;
                }
                else
                {
                    Console.WriteLine("0 girdiğiniz için çıktınız!");
                    break;
                }
                sayac++;

            }
            Console.WriteLine("Girilen sayıların toplamı: " + sayitoplam);
            Console.WriteLine("Kaç sayı girildi? " + (sayac-1));
            Console.WriteLine("Girilen sayıların ortalaması: " + (sayitoplam/(sayac-1)));



            Console.ReadKey();
        }
    }
}
