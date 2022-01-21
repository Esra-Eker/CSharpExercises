using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int[] EsraninElemanlari = new int[9];

             string[] EsraninElemanlari2 = { "esra1, esra2, esra3, esra4" };


             for(int i = 0; i <9; i++)
             {
                    EsraninElemanlari[i] = i;
                    //Console.WriteLine(EsraninElemanlari[i]);
             }


             Array.Sort(EsraninElemanlari); // Elemanları küçükten büyüğe sırala

             Console.WriteLine(EsraninElemanlari[0]);*/

            /* int[] Sayilar = new int[11];

             for (int i=0; i<=Sayilar.Length-1; i++)

             {
                 Console.Write("Sayı gir: ");
                 Sayilar[i] = int.Parse(Console.ReadLine());

             }
             Array.Sort(Sayilar);
             Console.WriteLine(Sayilar[0]);*/


            string[] Meyveler = { "Elma", "Armut", "Vişne", "EsranınMeyveleri" };

                       
            
            /*foreach(string meyve in Meyveler)
            {
                Console.WriteLine(meyve); // meyve indis, meyveleri ekrana yaz
                // Dizinin boyutunu bilmiyorsak, diziyle işlemler yapmak istediğimizde foreach kullanabiliriz

            }*/
            
           
            for(int i=0; i<Meyveler.Length; i++)
            {
                Console.WriteLine(Meyveler[i]);
            }



            Console.ReadKey();


        }
    }
}
