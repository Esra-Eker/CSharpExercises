using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cok_bicimlilik_ornek
{
    class insan
    {
        public virtual void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "Örnek Şubat 2022";
            Console.WriteLine("Merhaba soğuk kış günleri");
        }
    }

    class Türk:insan
    {
        public override void selamver()  //override selamver i geçersiz kılıyor.
        {
            //base.selamver();  temel selamver metodunun çıktısını yazar.
            Console.WriteLine("Merhabalar");
        }
    }


    class Fransız :insan
    {
        public override void selamver()
        {
            Console.WriteLine("Bonjour");
        }
    }

    class İngiliz:insan
    {
        public override void selamver()
        {
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Türk trk = new Türk();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write("Türklerin selam verme şekli: ");
            trk.selamver();

            Fransız frz = new Fransız();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Fransızların selam verme şekli: ");
            frz.selamver();

            İngiliz ing = new İngiliz();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write("İngilizlerin selam verme şekli: ");
            ing.selamver();
            
            Console.Read();
        }
    }
}
