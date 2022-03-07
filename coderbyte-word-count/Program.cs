using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderbyte_ornek_calisma
{
    //Coderbyte: Word Count 
    class Program
    {
        public static int WordCount(string str)
        {
            string[] kelimeler = str.Split(' ');
            int sayac = 0;
            for (int i = 0; i < kelimeler.Length; i++)
            {
                sayac++;
            }
            return sayac;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WordCount(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
