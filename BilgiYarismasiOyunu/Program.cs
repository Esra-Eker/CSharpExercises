using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasiOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("Yarışmaya Hoşgeldiniz!");
            Console.Title = "Bilgi Yarışması";
            string ad, soyad;
            Console.Write("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.WriteLine("Başlamak için enter tuşuna basın...");

            Console.WriteLine("Her yanıttan sonra enter tuşuna basmayı unutmayın.");

            Console.ReadLine();
            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;

            for(int i=0; i<10; i++)
            {
                switch(i)
                {
                    case 0: Console.WriteLine("Soru 1- Cumhuriyet kaç yılında ilan edilmiştir?\n A)1922 B)1923 C)1924 D)1926");
                        break;
                    case 1: Console.WriteLine("Soru 2- Türkiye'nin Başkenti hangi şehirdir?\n  A)İstanbul   B)Konya C)Ankara   D)İzmir");
                        break;
                    case 2:
                        Console.WriteLine("Soru 3- Maki hangi bölgenin bitki örtüsüdür?\n" + "A)Marmara   B)Akdeniz\nC)İç Anadolu   D)Karadeniz");
                        break;
                    case 3:
                        Console.WriteLine("Soru 4- Aşağıdakilerden hangisi İstanbul'da bulunan bir semt değildir?\n" + "A)Üsküdar   B)Avcılar\nC)Kağıthane   D)Urla");
                        break;
                    case 4:
                        Console.WriteLine("Soru 5- Aşağıdakilerden hangisi programlamada bulunan temel renklerden değildir?\n" + "A)Sarı   B)Mavi\nC)Yeşil   D)Kırmızı");
                        break;
                    case 5:
                        Console.WriteLine("Soru 6- Avrupanın kullandığı ortak para birimi nedir?\n" + "A)Dolar   B)Zloty\nC)Euro   D)Ruble;");
                        break;
                    case 6:
                        Console.WriteLine("Soru 7- Hangi ilimiz ege bölgesinde değildir?\n" + "A)İzmir   B)Muğla\nC)Edirne   D)Aydın");
                        break;
                    case 7:
                        Console.WriteLine("Soru 8- Sefiller kitabının yazarı kimdir?\n" + "A)Jules Verne   B)Gogol\nC)Tolstoy   D)Victor Hugo");
                        break;
                    case 8:
                        Console.WriteLine("Soru 9- Mustafa Kemal Atatürk'ün nüfusa kayıtlı olduğu il hangisidir?\n" + "A)İstanbul   B)Gaziantep\nC)Ankara   D)Samsun");
                        break;
                    case 9: Console.WriteLine("Soru 10- İstiklal Marşı şairimiz kimdir?\n" + "A)Ziya Gökalp   B)Orhan Veli\nC)Mehmet Akif Ersoy   D)Reşat Nuri Güntekin");
                        break;
                }
                Console.WriteLine();

                char[] cevap = { 'B', 'C', 'B', 'D', 'A', 'C', 'C', 'D', 'B', 'C' };
                char cvp = Convert.ToChar(Console.ReadLine().ToUpper());

                if(cevap[i]==cvp)
                {
                    para = para + 1000;
                    dogru++;
                    Console.WriteLine("Tebrikler cevabınız doğru :)");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Maalesef cevabınız yanlış :(");
                    yanlis++;
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Yarışmayı tamamladınız.\n Sonuçlar:\n Doğru cevap sayısı: {0}\n Yanlış cevap sayısı: {1}", dogru, yanlis);
            Console.WriteLine("Toplam kazandığınız para: " + para);

            Console.ReadKey();

            

            
        }
    }
}
