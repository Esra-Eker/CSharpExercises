using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci(); //Ogrenci class ını ogr adındaki bir nesneyle çağırdık.
            ogr.ADI = "Esra";
            ogr.SOYADI = "Eker";
            ogr.ALANI = "Sayısal";
            ogr.YASI = 5;

            Console.WriteLine("Adı: " + ogr.ADI);
            Console.WriteLine("Soyadı: " + ogr.SOYADI);
            Console.WriteLine("Alanı: " + ogr.ALANI);
            Console.WriteLine("Yaşı: " + ogr.YASI);

            Console.ReadLine();
        }
    }
}
