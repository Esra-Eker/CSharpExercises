using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //metin belgelerini tutmak için bu kütüphaneyi kullanıyoruz. 

namespace MetinBelgesiKayitUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            dosyakaydet();
        }
        static void dosyakaydet()
        {
            string dosyaadi;
            Console.Write("Dosya Adını Girin: ");
            dosyaadi = Console.ReadLine();
            StreamWriter dosya = new StreamWriter(@"C:\Users\EKER\Desktop\notlarım\" +dosyaadi+ ".txt");  //StreamWriter metin belgesi yazma işlemi yapmak için kullanacağımız sınıf.
            string veri;
            Console.Write("Buraya notunuzu yazın: ");
            veri = Console.ReadLine();
            dosya.WriteLine(veri);
            dosya.Close();
        }
    }
}
