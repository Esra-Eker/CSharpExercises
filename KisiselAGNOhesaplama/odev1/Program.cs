using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string soyutcebir1, difgeo1, lp1, sayısalanaliz1, fizik1, halkalar1, pozope1;
            double soyutcebir2=0, difgeo2=0, lp2=0, sayısalanaliz2=0, fizik2=0, halkalar2=0, pozope2=0;

            Console.Write("Soyut Cebir harf notunu giriniz: ");
            soyutcebir1 = Console.ReadLine();
            
            if (soyutcebir1 == "AA")
            {
                soyutcebir2 = 4.00 * 3;               
            }
            if (soyutcebir1 == "BA")
            {
                soyutcebir2 = 3.50 * 3;
            }
            if (soyutcebir1 == "BB")
            {
                soyutcebir2 = 3.00 * 3;
            }
            if (soyutcebir1 == "CB")
            {
                soyutcebir2 = 2.50 * 3;
            }
            if (soyutcebir1 == "CC")
            {
                soyutcebir2 = 2.00 * 3;
            }
            if (soyutcebir1 == "DC")
            {
                soyutcebir2 = 1.50 * 3;
            }
            if (soyutcebir1 == "DD")
            {
                soyutcebir2 = 1.00 * 3;
            }
            if (soyutcebir1 == "FD")
            {
                soyutcebir2 = 0.50 * 3;
            }
            if (soyutcebir1 == "FF")
            {
                soyutcebir2 = 0 * 3;
            }

            Console.Write("Diferansiyel Geometri harf notunu giriniz: ");
            difgeo1 = Console.ReadLine();

            if (difgeo1 == "AA")
            {
                difgeo2 = 4.00 * 3;
            }
            if (difgeo1 == "BA")
            {
                difgeo2 = 3.50 * 3;
            }
            if (difgeo1 == "BB")
            {
                difgeo2 = 3.00 * 3;
            }
            if (difgeo1 == "CB")
            {
                difgeo2 = 2.50 * 3;
            }
            if (difgeo1 == "CC")
            {
                difgeo2 = 2.00 * 3;
            }
            if (difgeo1 == "DC")
            {
                difgeo2 = 1.50 * 3;
            }
            if (difgeo1 == "DD")
            {
                difgeo2 = 1.00 * 3;
            }
            if (difgeo1 == "FD")
            {
                difgeo2 = 0.50 * 3;
            }
            if (difgeo1 == "FF")
            {
                difgeo2 = 0 * 3;
            }

            Console.Write("Lineer programlama harf notunu giriniz: ");
            lp1 = Console.ReadLine();

            if (lp1 == "AA")
            {
                lp2 = 4.00 * 3;
            }
            if (lp1 == "BA")
            {
                lp2 = 3.50 * 3;
            }
            if (lp1 == "BB")
            {
                lp2 = 3.00 * 3;
            }
            if (lp1 == "CB")
            {
                lp2 = 2.50 * 3;
            }
            if (lp1 == "CC")
            {
                lp2 = 2.00 * 3;
            }
            if (lp1 == "DC")
            {
                lp2 = 1.50 * 3;
            }
            if (lp1 == "DD")
            {
                lp2 = 1.00 * 3;
            }
            if (lp1 == "FD")
            {
                lp2 = 0.50 * 3;
            }
            if (lp1 == "FF")
            {
                lp2 = 0 * 3;
            }

            Console.Write("Sayısal Analiz harf notunu giriniz: ");
            sayısalanaliz1 = Console.ReadLine();

            if (sayısalanaliz1 == "AA")
            {
                sayısalanaliz2 = 4.00 * 4;
            }
            if (sayısalanaliz1 == "BA")
            {
                sayısalanaliz2 = 3.50 * 4;
            }
            if (sayısalanaliz1 == "BB")
            {
                sayısalanaliz2 = 3.00 * 4;
            }
            if (sayısalanaliz1 == "CB")
            {
                sayısalanaliz2 = 2.50 * 4;
            }
            if (sayısalanaliz1 == "CC")
            {
                sayısalanaliz2 = 2.00 * 4;
            }
            if (sayısalanaliz1 == "DC")
            {
                sayısalanaliz2 = 1.50 * 4;
            }
            if (sayısalanaliz1 == "DD")
            {
                sayısalanaliz2 = 1.00 * 4;
            }
            if (sayısalanaliz1 == "FD")
            {
                sayısalanaliz2 = 0.50 * 4;
            }
            if (sayısalanaliz1 == "FF")
            {
                sayısalanaliz2 = 0 * 4;
            }

            Console.Write("Fizik 1 harf notunu giriniz: ");
            fizik1 = Console.ReadLine();

            if (fizik1 == "AA")
            {
                fizik2 = 4.00 * 4;
            }
            if (fizik1 == "BA")
            {
                fizik2 = 3.50 * 4;
            }
            if (fizik1 == "BB")
            {
                fizik2 = 3.00 * 4;
            }
            if (fizik1 == "CB")
            {
                fizik2 = 2.50 * 4;
            }
            if (fizik1 == "CC")
            {
                fizik2 = 2.00 * 4;
            }
            if (fizik1 == "DC")
            {
                fizik2 = 1.50 * 4;
            }
            if (fizik1 == "DD")
            {
                fizik2 = 1.00 * 4;
            }
            if (fizik1 == "FD")
            {
                fizik2 = 0.50 * 4;
            }
            if (fizik1 == "FF")
            {
                fizik2 = 0 * 4;
            }

            Console.Write("Halkalar ve Modüller harf notunu giriniz: ");
            halkalar1 = Console.ReadLine();

            if (halkalar1 == "AA")
            {
                halkalar2 = 4.00 * 3;
            }
            if (halkalar1 == "BA")
            {
                halkalar2 = 3.50 * 3;
            }
            if (halkalar1 == "BB")
            {
                halkalar2 = 3.00 * 3;
            }
            if (halkalar1 == "CB")
            {
                halkalar2 = 2.50 * 3;
            }
            if (halkalar1 == "CC")
            {
                halkalar2 = 2.00 * 3;
            }
            if (halkalar1 == "DC")
            {
                halkalar2 = 1.50 * 3;
            }
            if (halkalar1 == "DD")
            {
                halkalar2 = 1.00 * 3;
            }
            if (halkalar1 == "FD")
            {
                halkalar2 = 0.50 * 3;
            }
            if (halkalar1 == "FF")
            {
                halkalar2 = 0 * 3;
            }

            Console.Write("Pozitif Operatörlere Giriş harf notunu giriniz: ");
            pozope1 = Console.ReadLine();

            if (pozope1 == "AA")
            {
                pozope2 = 4.00 * 3;
            }
            if (pozope1 == "BA")
            {
                pozope2 = 3.50 * 3;
            }
            if (pozope1 == "BB")
            {
                pozope2 = 3.00 * 3;
            }
            if (pozope1 == "CB")
            {
                pozope2 = 2.50 * 3;
            }
            if (pozope1 == "CC")
            {
                pozope2 = 2.00 * 3;
            }
            if (pozope1 == "DC")
            {
                pozope2 = 1.50 * 3;
            }
            if (pozope1 == "DD")
            {
                pozope2 = 1.00 * 3;
            }
            if (pozope1 == "FD")
            {
                pozope2 = 0.50 * 3;
            }
            if (pozope1 == "FF")
            {
                pozope2 = 0 * 3;
            }

            Console.Write("AGNO: " + (soyutcebir2 + difgeo2 + lp2 + sayısalanaliz2 + fizik2 + halkalar2 + pozope2)/23 );

            Console.ReadLine();

            


        }
    }
}
