using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Sayın " + customer.FirstName + " " + customer.LastName + " Tebrikler Kaydınız Oluşturuldu. ");
        }

        public void Add2(Customer customer)
        {
            Console.WriteLine(customer.Id + "." + customer.FirstName + " " + customer.LastName + ", "
                + customer.Age + ", " + customer.Email + " ");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Sayın " + customer.FirstName + " " + customer.LastName + " Müşteri Bilgileri Güncellendi.");
        }

        public void Deletion(Customer customer)
        {
            Console.WriteLine("Sayın " + customer.FirstName + " " + customer.LastName + " Kaydınız Silinmiştir.");
        }


    }
}
