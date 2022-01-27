using System;

namespace Calismalarim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Bir sayı gir: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            /*if (sayi % 2 == 0)
                Console.WriteLine("Girilen sayı çifttir.");
            else
                Console.WriteLine("Girilen sayı tektir.");*/

            //Ternary if ile 
            /*string result = (sayi % 2 == 0) ? "Girilen sayı çifttir" : "Girilen sayı tektir";
            Console.WriteLine(result);*/

            //1.yol
            /*string kullaniciAdiG = "esrae";
            int sifreG = 123456;

            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullaniciAdi = Console.ReadLine();

            if (kullaniciAdi == kullaniciAdiG)
            {
                Console.Write("Şifrenizi giriniz: ");
                int sifre = Convert.ToInt32(Console.ReadLine());
                if (sifre == sifreG)
                    Console.WriteLine("Giriş Başarılı!");
                else
                    Console.WriteLine("Şifre yanlış. Lütfen şifrenizi tekrar giriniz.");
            }

            else
                Console.WriteLine("Kullanıcı adı yanlış. Lütfen kullanıcı adınızı tekrar giriniz.");*/


            //2.yol: ternary if ile
            string kullaniciAdiG = "esrae";
            int sifreG = 123456;

            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifrenizi giriniz: ");
            int sifre = Convert.ToInt32(Console.ReadLine());

            string result = (kullaniciAdiG == kullaniciAdi && sifreG == sifre) ? "Giriş Başarılı!" : "Kullanıcı adı veya şifre hatalı!";
            Console.WriteLine(result);    
            

            Console.ReadLine();

        }
    }
}
