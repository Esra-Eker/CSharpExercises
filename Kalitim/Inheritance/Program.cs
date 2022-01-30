using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Esra" }, new Student{FirstName="Elif" }, new Person{FirstName="Deniz"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person   //class ların tek başına bir anlamı vardır ama interface lerin tek başına bir anlamı yoktur.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person   //Person ı Customer ın babası gibi düşünebiliriz. Bir kişinin bir babası olacağından Person2 diye yeni bi class açsak bile yanına yazamayız. Yani bir neseneye sadece 1 kere inheritance alabiliriz ama birden fazla implementasyon yapabiliriz.
    {
        public string City { get; set; }
    }

    class Student : Person  //Hem inheritance hem de interface yazılacağı zaman inheritance önce yazılır.
    {
        public string Department { get; set; }
    }
}
