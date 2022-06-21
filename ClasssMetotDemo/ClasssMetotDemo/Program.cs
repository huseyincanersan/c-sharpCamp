using System;

namespace ClasssMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.customerId = 53365;
            customer1.name = "Can";
            customer1.phoneNumber = "05444444444" ;
            customer1.surName = "Ersan" ;
            customer1.age = 22;

            Customer customer2 = new Customer();

            customer2.customerId = 13131;
            customer2.name = "Huseyin";
            customer2.phoneNumber = "05333333333";
            customer2.surName = "Arsan";
            customer2.age = 25;

         
            Customer[] customers = new Customer[] {customer1,customer2 };








            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            Console.WriteLine("---------------Musteriler--------------");
            customerManager.ListCustomer(customers);
            Console.WriteLine("---------------Musteriler--------------");
            customerManager.DeleteCustomer(customer2);




        }
    }
}
