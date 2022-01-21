using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "EKMEZ seda";

            /*if(isim.Contains("esra"))
            {
                Console.WriteLine("bu isimde esra var");
            }

            else
            {
                Console.WriteLine("Bu isimde esra yok");
            }*/

            //  Console.WriteLine(isim.Replace("seda", "esra"));


            int i = 1;

            do
            {

                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            


            Console.ReadKey();


        }
    }
}
