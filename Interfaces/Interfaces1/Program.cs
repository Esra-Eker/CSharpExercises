using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
             PersonManager manager = new PersonManager();
            /* manager.Add(new Customer { Id = 1, FirstName = "Esra", LastName = "Eker", Address = "İstanbul" });*/

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Esra",
                LastName = "Eker",
                Address = "İstanbul"
            };
            manager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Elif",
                LastName = "Eker",
                Departmant = "Maths"
            };
            manager.Add(student);

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)  
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
