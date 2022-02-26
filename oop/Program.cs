using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class insan
    {
        public insan() //bu bir constructor. classla aynı isme sahip olmalı. insan da ilk kez bir object üretilirken çalıştırılan metot. yani ali ve veli ilk kez üretilirken çalıştırılıyor.
        {
            Console.WriteLine("Yeni bir insan objesi üretildi."); //sadece bu constructor u kullanığım yerlerde ekrana yazacak.
        }
        public insan(int kilo) //huseyin object inin kilosunu direkt atayabilmek için bu constructor yapısını kullandık.
        {
            this.kilo = kilo;
        }
        //yukarıda insan isminde 2 FARKLI constructor var.

         public string isim; //insan ın isim özelliği (property) olmuş oldu.
        // public int kilo;   //(Yol1) public olmalı ki erişebilelim. genelde bir değişkenin public olarak tutulmasını tercih etmiyoruz. bundan kurtulmak için encapsulation yöntemini kullanıyoruz. hadi bir de öyle bakalım

        // kilo tanımı için (Yol 2: Encapsulation) 
        private int kilo; //private demek sadece bu classtan erişilebilir demek. yani gidip Program class ında kilo değişkenini kullanamayız.
        public void setKilo (int kilo)
        {
            if (kilo < 0)
                this.kilo = kilo; //class ın kilosuna eriş demiş olduk.
            else
                this.kilo = kilo;
        }
        public int getKilo()   //yazdırırken işime yarayacak.
        {
            return kilo;  //this dememe gerek yok çünkü zaten bu alanda tek bir kilo geçerli.
        }

        //Yol3:  Yukarında yaptığımız 2.yola benzer olarak başka bir yola bakalım
        public int Kilo
        {
            get
            {
                return kilo;
            }
            set
            {
                if (value < 0)   // value burada parametre olarak gelen değer anlamına geliyor.
                    this.kilo = 0;
                else
                    this.kilo = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //insan class ını kullanarak object ler üretebiliriz. ali ve veliyi ürettik mesela.
            insan ali = new insan();  //new insan() bize constructor ı çağırmayı sağlıyo. yani constructor ile bi object üretiyoruz ve o object i ali değişkeninde tutuyoruz.
            ali.isim = "ali demir";
          //ali.kilo = 80;  Yol1 kullanarak tanımladık.
            ali.setKilo(80);  //Yol2 yi kullanarak tanımladık.
            ali.Kilo = 90;  //Yol3 ile tanımladık.

            insan veli = new insan();
            //veli.kilo = 70;
            insan huseyin = new insan(50); //insanı tanımlayıp insanın kilosunu atamak yerine (yani veli.kilo=80 gibi) kiloyu direkt atadık.
            Console.WriteLine("hüseyinin kilosu: " + huseyin.Kilo);

            Console.WriteLine("alinin kilosu: " + ali.getKilo()); //2.yol ile kilosunu yazdırdık.
            Console.WriteLine("alinin kilosu: " + ali.Kilo); //3.yol ile kilosunu yazdırdık
            ali.Kilo = -10;
            Console.WriteLine("alinin güncel kilosu: " + ali.Kilo);
            Console.ReadLine();
        
        }
        
    }
}
