using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
            
        }

        public void Delete(ICustomerDal customerDal)
        {
            
            customerDal.Delete();
            
        }

        public void Update(ICustomerDal customerDal)
        {
            
            customerDal.Update();
        }


    }
}
