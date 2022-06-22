using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id = 1 ,FirstName="Can",LastName="Ersan",City="istanbul" };

            Customer customer2 = new Customer(2,"huseyin","ersan","istanbul");

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Yapici Blok Calisti");
        }

        public Customer(int id, string firsName, string lastName,string city)
        {
            Id = id;
            FirstName = firsName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
