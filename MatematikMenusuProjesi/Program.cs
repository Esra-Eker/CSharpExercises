using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikMenusuProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.Title = "Matematik İşlem Menüsü";
            Console.WriteLine("Aritmetik İşlemler Menüsüne Hoşgeldiniz!\n");
            Console.WriteLine("***************** Menü *****************\n");

            Console.WriteLine("1- Aritmetik Dört İşlem");
            Console.WriteLine("2- Üs Alma");
            Console.WriteLine("3- Kök Alma");
            Console.WriteLine("4- Karenin Çevre ve Alan Hesabı");
            Console.WriteLine("5- Dikdörtgenin Çevre ve Alan Hesabı");
            Console.WriteLine("6- Eşkenar Üçgende Çevre Hesabı\n");

            Console.WriteLine("****************************************\n");

            Console.Write("İşlem yapmak istediğiniz alan: ");
            islem = Convert.ToInt32(Console.ReadLine());

            switch(islem)
            {
                case 1:
                    int a, b, toplam, fark, carpim, bolum;
                    Console.Write("1.sayıyı girin: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2.sayıyı girin: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    toplam = a + b;
                    fark = a - b;
                    carpim = a * b;
                    bolum = a / b;

                    Console.WriteLine("Toplam: " + toplam);
                    Console.WriteLine("Fark: " + fark);
                    Console.WriteLine("Çarpım: " + carpim);
                    Console.WriteLine("Bölüm: " + bolum);
                    break;

                case 2:
                    double sayi, us, sonuc;
                    Console.Write("Sayıyı girin: ");
                    sayi = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Üssü girin: ");
                    us = Convert.ToDouble(Console.ReadLine());

                    sonuc = Math.Pow(sayi, us);
                    Console.WriteLine("Üs işleminin sonucu: " + sonuc);
                    break;

                case 3:
                    double sayi2, sonuc2;
                    Console.Write("Sayıyı girin: ");
                    sayi2 = Convert.ToDouble(Console.ReadLine());

                    sonuc2 = Math.Sqrt(sayi2);
                    Console.WriteLine("Karekök alma işleminin sonucu: " + sonuc2);
                    break;

                case 4:
                    int kenar, cevre, alan;
                    Console.Write("Kenar uzunluğunu girin:");
                    kenar = Convert.ToInt32(Console.ReadLine());

                    cevre = 4 * kenar;
                    alan = kenar * kenar;
                    Console.WriteLine("Çevre: " + cevre);
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 5:
                    int kisakenar, uzunkenar, cevredik, alandik;
                    Console.Write("Kısa kenarı girin: ");
                    kisakenar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Uzun kenarı giirn: ");
                    uzunkenar = Convert.ToInt32(Console.ReadLine());

                    cevredik = uzunkenar * 2 + kisakenar * 2;
                    alandik = kisakenar * uzunkenar;
                    Console.WriteLine("Çevre: " + cevredik);
                    Console.WriteLine("Alan: " + alandik);
                    break;

                case 6:
                    double kenares, cevrees, alanes;
                    Console.Write("Üçgenin kenarını girin: ");
                    kenares = Convert.ToInt32(Console.ReadLine());

                    cevrees = kenares * 3;
                    alanes = kenares * kenares * Math.Sqrt(3) / 4;
                    Console.WriteLine("Çevre: " + cevrees);
                    Console.WriteLine("Alan: " + alanes);
                    break;        


            }

            Console.ReadLine();
            
        }
    }
}
