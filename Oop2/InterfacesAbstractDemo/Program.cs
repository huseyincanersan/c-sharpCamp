using System;
using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Adapters;
using InterfacesAbstractDemo.Concrete;
using InterfacesAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfacesAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000, 11, 8), FirstName = "Hüseyin Can", LastName = "Ersan", NationalityId = "10021894038" });
            Console.ReadLine();

        }
    }
}
