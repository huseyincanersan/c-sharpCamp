using System;
using System.Collections.Generic;
using System.Text;

namespace ClasssMetotDemo
{
    class CustomerManager
    {


        public void AddCustomer(Customer customer)
        {
            Customer cst = new Customer()
            {
                customerId = customer.customerId,
                name = customer.name,
            };

            Console.WriteLine("Musteri basariyla eklendi.");

            Console.WriteLine("Musteri adi: " + customer.name);
            Console.WriteLine("Musteri numarasi: " + customer.customerId);

        }

        public void ListCustomer(Customer[] customers)
        {
            foreach (var cst in customers)
            {
                Console.WriteLine("Musteri Numarasi: " + cst.customerId);
                Console.WriteLine("Musteri adi ve soy adi: " + cst.name + " " + cst.surName);
                Console.WriteLine("Musteri telefon numarasi: " + cst.phoneNumber);
                Console.WriteLine("Musteri Yasi: " + cst.age);
                Console.WriteLine("------------------------------");



            }
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Musteri silindi!!!!");
            Console.WriteLine("Musteri adi: " + customer.name);
            Console.WriteLine("Musteri numarasi: " + customer.customerId);

        }






    }
}
