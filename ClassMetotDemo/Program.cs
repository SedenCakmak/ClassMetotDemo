using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0001;
            customer1.FirstName = "Seden";
            customer1.LastName = "Çakmak";
            customer1.Email = "seden@gmail.com";
            customer1.Age = 20;

            Customer customer2 = new Customer();
            customer2.Id = 0002;
            customer2.FirstName = "Elif";
            customer2.LastName = "Sertdemir";
            customer2.Email = "sertdemir@gmail.com";
            customer2.Age = 21;

            Customer customer3 = new Customer();
            customer3.Id = 0003;
            customer3.FirstName = "Burak";
            customer3.LastName = "Ateş";
            customer3.Email = "tesekkurlerburakates@gmail.com";
            customer3.Age = 22;

            Customer customer4 = new Customer();
            customer4.Id = 0004;
            customer4.FirstName = "Emre";
            customer4.LastName = "Kahveci";
            customer4.Email = "kahveciemre@gmail.com";
            customer4.Age = 34;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + "." + customer.FirstName + "  " + customer.LastName + " , " + customer.Age + " , " + customer.Email);

            }
            Console.WriteLine("Müşteriler Listelendi.");
            Console.WriteLine("---------------------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer4);
            customerManager.Add2(customer4);
            Console.WriteLine("----------------------------------");

            customerManager.Update(customer4);
            customerManager.Deletion(customer4);
        }
    }
}
