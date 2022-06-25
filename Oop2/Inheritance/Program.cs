using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
           

            List<Person> person = new List<Person> { new Customer {FirstName = "Can",LastName="Ersan",Id=3,City = "Istanbul" }, new Student {FirstName="Huseyin",
                LastName="can",Id=2,Department="Yazilim" } };

            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName);
                
            }


        }
    }
}
