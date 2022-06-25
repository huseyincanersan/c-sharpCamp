using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SmsCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sms added");
        }

        public void Delete()
        {
            Console.WriteLine("Sms Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sms updated");
        }
    }
}
