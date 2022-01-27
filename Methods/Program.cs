using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(2, 3);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2,4,8));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
            //ya da böyle yazılır:
            //return number1 + number2;
        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        //aynı isimle ikinci bi method kullandığımızda farklı parametreler kullanıyorsak bi sıkıntı olmaz. (method overloading)
        static int Multiply(int number1, int number2 , int number3)
        {
            return number1 * number2 * number3;
        }

        //int number 1 i aldı diğer girilen sayılar params a geçti. Ben de params ı hesaplattığım için girilen sayıların toplamları 21 değil 20 oldu.
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
