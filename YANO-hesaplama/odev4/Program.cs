using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            string harfnotu;
            int kredi;
            double toplam=0;
            int kreditoplam=0;

            Console.Write("Ders Sayısını giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                Console.Write("{0}. dersin harf notunu giriniz: ",i);
                harfnotu = Console.ReadLine();
                Console.Write("{0}. dersin kredisini giriniz: ",i);
                kredi = int.Parse(Console.ReadLine());

                kreditoplam += kredi;
            
                if(harfnotu =="AA")
                {
                    toplam += (kredi * 4.00);
                }
                if (harfnotu == "BA")
                {
                    toplam += (kredi * 3.50);
                }
                if (harfnotu == "BB")
                {
                    toplam += (kredi * 3.00);
                }
                if (harfnotu == "CB")
                {
                    toplam += (kredi * 2.50);
                }
                if (harfnotu == "CC")
                {
                    toplam += (kredi * 2.00);
                }
                if (harfnotu == "DC")
                {
                    toplam += (kredi * 1.50);
                }
                if (harfnotu == "DD")
                {
                    toplam += (kredi * 1.00);
                }
                if (harfnotu == "FD")
                {
                    toplam += (kredi * 0.50);
                }
                if (harfnotu == "FF")
                {
                    toplam += (kredi * 0);
                }
                
            }
            Console.WriteLine("AGNO: " + (toplam / (double) kreditoplam));  
            Console.ReadKey();



        }
    }
}
