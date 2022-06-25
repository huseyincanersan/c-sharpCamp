using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class OracleCustomerDaL : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
}
