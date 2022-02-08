using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastgeleLig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rastgele Lig Turnuvamıza Hoşgeldiniz...\n");
            Console.WriteLine("Katılan tüm takımlara başarılar dileriz.\n");
            Console.Title = "C# Turnuvası";

            int gs = 0, fb=0, bjk=0, ts = 0;
            int sayac = 1;

            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;

            Random rastgele = new Random();

            if (sayac == 1)
            {               
                a1 = rastgele.Next(0, 6);  //0,1,2,3,4,5 değerleri gelebilir 6 gelmez. 1.değer dahil, 2.değer dahil değil.
                b1 = rastgele.Next(0, 6);
                c1 = rastgele.Next(0, 6);
                d1 = rastgele.Next(0, 6);

                Console.WriteLine("1.Hafta Skorları");
                Console.WriteLine("---------------------------------------------");
               
                Console.WriteLine("Galatasaray " + a1 + " - " + b1 + " Fenerbahçe");
                if(a1>b1)
                {
                    gs = gs + 3;
                }
                if(b1>a1)
                {
                    fb = fb + 3;
                }
                if(a1==b1)
                {
                    gs = gs + 1;
                    fb = fb + 1;
                }
                Console.WriteLine("Beşiktaş " + c1 + " - " + d1 + " Trabzonspor\n");
                if(c1>d1)
                {
                    bjk = bjk + 3;
                }
                if(d1>c1)
                {
                    ts = ts + 3;
                }
                if(c1==d1)
                {
                    bjk = bjk + 1;
                    ts = ts + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if(sayac==2)
            {
                a2 = rastgele.Next(0, 6);
                b2 = rastgele.Next(0, 6);
                c2 = rastgele.Next(0, 6);
                d2 = rastgele.Next(0, 6);
                
                Console.WriteLine("2.Hafta Skorları");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Fenerbahçe " + b2 + " - " + c2 + " Beşiktaş");
                if(b2>c2)
                {
                    fb = fb + 3;
                }
                if (c2 > b2)
                {
                    bjk = bjk + 3;
                }
                if (b2 == c2)
                {
                    fb++;
                    bjk++;
                }
                Console.WriteLine("Trabzonspor " + d2 + " - " + a2 + " Galatasaray\n");
                if(d2>a2)
                {
                    ts = ts + 3;
                }
                if(a2>d2)
                {
                    gs = gs + 3;
                }
                if(a2==d2)
                {
                    ts++;
                    gs++;
                }
                sayac++;
                Console.ReadLine();
            }

            if(sayac==3)
            {
                a3 = rastgele.Next(0, 6);
                b3 = rastgele.Next(0, 6);
                c3 = rastgele.Next(0, 6);
                d3 = rastgele.Next(0, 6);

                Console.WriteLine("3.Hafta Skorları");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Trabzonspor " + d3 + " - " + b3 + " Fenerbahçe");
                if(d3>b3)
                {
                    ts = ts + 3;
                }
                if(b3>d3)
                {
                    fb = fb + 3;
                }
                if(b3==d3)
                {
                    ts++;
                    fb++;
                }
                Console.WriteLine("Beşiktaş " + c3 + " - " + a3 + " Galatasaray\n");
                if(c3>a3)
                {
                    bjk = bjk + 3;
                }
                if(a3>c3)
                {
                    gs = gs + 3;
                }
                if(a3==c3)
                {
                    bjk++;
                    gs++;
                }
                sayac++;
                Console.ReadLine();                   
            }

            if(sayac==4)
            {
                Console.WriteLine("Maçlar tamamlandı...\n");                
                Console.WriteLine("Puan Tablosu");
                Console.WriteLine("----------------------");
                Console.WriteLine("Galatasaray: " + gs);
                Console.WriteLine("Fenerbahçe: " + fb);
                Console.WriteLine("Beşiktaş: " + bjk);
                Console.WriteLine("Trabzonspor " + ts);
            }


            Console.ReadLine();

        }
    }
}
