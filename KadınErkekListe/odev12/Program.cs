using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev12
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, cinsiyet;
            int yas;
            int toplamkadın=0, toplamerkek=0, yastoplam=0;

            for (int i=1; i<=3; i++)
            {
                Console.Write("Ad: ");
                ad = Console.ReadLine();
                Console.Write("Soyad: ");
                soyad = Console.ReadLine();
                Console.Write("Cinsiyet: ");
                cinsiyet = Console.ReadLine();
                Console.Write("Yaş: ");
                yas = int.Parse(Console.ReadLine());

                if(cinsiyet == "Kadın")
                {
                    toplamkadın++;
                }
                else if (cinsiyet == "Erkek")
                {
                    toplamerkek++;
                }
                else
                {
                    Console.WriteLine("Lütfen Kadın veya Erkek olarak giriniz!");
                }
                yastoplam += yas;
                Console.WriteLine();
            }
            Console.WriteLine("Toplam kadın sayısı: " + toplamkadın);
            Console.WriteLine("Toplam erkek sayısı: " + toplamerkek);
            Console.WriteLine("Yaşların ortalaması: " + yastoplam /(double) (toplamkadın + toplamerkek));
            Console.ReadLine();

        }
    }
}
