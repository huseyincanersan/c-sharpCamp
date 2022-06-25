using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customer = new CustomerManager();
            //customer.Add(new SqlServerCustomerDal());
            //customer.Add(new OracleCustomerDaL());

            //customer.Delete(new SqlServerCustomerDal());


            List<ICustomerDal> customerDals = new List<ICustomerDal>();
            customerDals.Add(new SqlServerCustomerDal());
            customerDals.Add(new OracleCustomerDaL());
            customerDals.Add(new SmsCustomerDal());

            foreach (var item in customerDals)
            {

                item.Add();

            }




        }
    }
}
