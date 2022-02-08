using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSepeti
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;
            Console.WriteLine("***************************************************************");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**          Yemekler          **          İçecekler          **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   1)Lahmacun - 15.00 TL    **      7)Ayran - 4.50 TL      **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   2)Et döner - 25.00 TL    **      8)Cola - 6.00 TL       **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   3)Adana dürüm - 35 TL    **      9)Limonlu soda - 3 TL  **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   4)Urfa dürüm - 35 TL     **      10)Ice tea - 6 TL      **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   5)Salatalar - 15 TL      **      11)Şalgam - 5.50 TL    **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   6)Tatlılar - 15 TL       **      12)Su - 2 TL           **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("***************************************************************");

            for(int i = 1; i< 100; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Alacağınız ürünün numarası: ");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("Kaç tane lahmacun: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 15;
                    hesap = hesap + toplam;
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Kaç porsiyon et döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    hesap = hesap + toplam;
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Kaç porsiyon adana dürüm: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 35;
                    hesap = hesap + toplam;
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Kaç porsiyon urfa dürüm: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 35;
                    hesap = hesap + toplam;
                }
                else if (secim == 5)
                {
                    Console.WriteLine("Kaç porsiyon salata: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 15;
                    hesap = hesap + toplam;
                }
                else if (secim == 6)
                {
                    Console.WriteLine("Kaç porsiyon tatlı: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 15;
                    hesap = hesap + toplam;
                }
                else if (secim == 7)
                {
                    Console.WriteLine("Kaç tane ayran: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 4.50;
                    hesap = hesap + toplam;
                }
                else if (secim == 8)
                {
                    Console.WriteLine("Kaç tane cola: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap = hesap + toplam;
                }
                else if (secim == 9)
                {
                    Console.WriteLine("Kaç tane limonlu soda: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3;
                    hesap = hesap + toplam;
                }
                else if (secim == 10)
                {
                    Console.WriteLine("Kaç tane ice tea: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap = hesap + toplam;
                }
                else if (secim == 11)
                {
                    Console.WriteLine("Kaç tane şalgam: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5.50;
                    hesap = hesap + toplam;
                }
                else if (secim == 12)
                {
                    Console.WriteLine("Kaç tane su: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap = hesap + toplam;
                }
                else
                    Console.WriteLine("Böyle bir seçim yok.");
                Console.WriteLine();
                Console.Write("Başka isteğiniz var mı?");
                string cevap = Console.ReadLine();
                if(cevap=="h" || cevap=="H" || cevap=="Hayır" || cevap=="HAYIR" || cevap=="hayır")
                    break;
                
            }
            Console.WriteLine("Toplam tutar: " + hesap);
            Console.ReadLine();
            
        }
    }
}
