using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();  //class ı kullanabilmemiz için onun newlememiz gerek. Yani bir örneğini oluşturmalıyız.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Esra";
            customer.LastName = "Eker";

            //Aşağıda ve yukarda yaptığımız tanımlamalar aynı. 2 türlü de yapılabilir.
            Customer customer2 = new Customer
            {
                Id = 2, City ="İstanbul", FirstName ="Elif", LastName="Eker"
            };

            Console.WriteLine(customer2.FirstName); //customer2 nin FirstName ini ekrana yazdır demek.

            Console.ReadLine();
          
        }
    }

    //class oluşturulurken kelimelerin ilk harfi büyük olur (PascalCase), örneği oluştururken kelimelerin sadece ilk harfi küçük (camelCase) yazılır.
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}
