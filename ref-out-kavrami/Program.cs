using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_kavrami
{
    class Program
    {
        //Eğer değişkenimi main metodunun içinde tanımlayarak yukarıdaki metodun referansını kullanmak istiyorsam ref kullanıyorum.
        //Ama method içerisinde tanımlayacaksam out kullanıyorum.


       /* static void arttir(ref int s)
        {
            s++;
        }
        static void Main(string[] args)
        {
            int a = 9;
            arttir(ref a);
            Console.Write(a);
            Console.Read();

        }  */

        static void arttir(out int s)
        {
            s = 12;
            s++;
        }
        static void Main(string[] args)
        {
            int a;
            arttir(out a);
            Console.Write(a);
            Console.Read();
        }
    }


        
}

