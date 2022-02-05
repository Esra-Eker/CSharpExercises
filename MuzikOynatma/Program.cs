using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MuzikOynatma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    SoundPlayer ses = new SoundPlayer();
                string yol;
                yol = "C:\\Users\\EKER\\Desktop\\mp3indirdur-Elley-Duhe-Middle-Of-The-Night.wav";  //Çift tırnağın başına @ de kullanabilirdik, \ nın okunabilmesi için.
                ses.SoundLocation = yol;
                ses.Play();
                Console.ReadLine();  */

            System.Diagnostics.Process.Start(@"C:\Users\EKER\Desktop\mp3indirdur-Elley-Duhe-Middle-Of-The-Night.mp3");
        }
    }
}
