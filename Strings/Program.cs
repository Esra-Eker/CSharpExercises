using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string city = "Ankara";
              //Console.WriteLine(city[1]);

              foreach (var item in city)
              {
                  Console.WriteLine(item);
              }

              string city2 = "İstanbul";

              Console.WriteLine(String.Format("{0}{1}", city,city2));  */

            string sentence = "My name is Esra Eker";

            Console.WriteLine("Karakter sayısı: {0}",sentence.Length);

            var result = sentence.Clone();
            sentence = "Benim adım Esra Eker";
            Console.WriteLine(result);
            Console.WriteLine(sentence);

            bool result2 = sentence.EndsWith("r");
            Console.WriteLine("sentence r ile bitiyor mu? {0}",result2);
            bool result3 = sentence.StartsWith("Benim adım");
            Console.WriteLine("sentence 'Benim adım' ile başlıyor mu? {0}", result3);

            var result4 = sentence.IndexOf("adım");
            var result5 = sentence.IndexOf(" ");
            Console.WriteLine(" 'adım' kaçıncı sırada? {0}", result4);
            Console.WriteLine(result5);
            var result6 = sentence.LastIndexOf(" ");
            Console.WriteLine("Son boşluk karakteri kaçıncı sırada? {0}",result6);

            var result7 = sentence.Insert(0, "Hello, "); //0.karakterden itibaren Hello, yazdır.
            Console.WriteLine(result7);

            var result8 = sentence.Substring(6); //6.karakterden itibaren al.
            Console.WriteLine(result8);

            var result9 = sentence.ToLower();  //Tüm karakterleri küçük harf yapar.
            var result10 = sentence.ToUpper();  //Tüm karakterleri büyük harf yapar.
            Console.WriteLine(result10);

            var result11 = sentence.Replace(" ", "-");  //Boşluk karakteri yerine - kullan.
            Console.WriteLine(result11);

            var result12 = sentence.Remove(5);  //5.karakterden itibarenkiler atılır.
            Console.WriteLine(result12);


            Console.ReadLine();
        }
    }
}
