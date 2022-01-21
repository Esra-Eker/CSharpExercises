using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Girebileceğiniz İşlem Türleri : +, -, *, /");
            Console.WriteLine("----------------------------------------------");

            string islem;
            double sayi1, sayi2;

            Console.Write("İşlem Türünü Giriniz: ");
            islem = Console.ReadLine();

            Console.Write("Birinci Sayıyı Giriniz: ");
            sayi1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            sayi2 = double.Parse(Console.ReadLine());

            if(islem == "+")
            {
                Console.WriteLine(sayi1 + " + " + sayi2 + " = " + (sayi1 + sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine(sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine(sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));
            }
            else if (islem == "/")
            {
                Console.WriteLine(sayi1 + " : " + sayi2 + " = " + (sayi1 / sayi2));
            }
            else
            {
                Console.WriteLine("Geçerli bir işlem türü girmediniz!");
            }
            Console.ReadLine();
        }
    }
}
