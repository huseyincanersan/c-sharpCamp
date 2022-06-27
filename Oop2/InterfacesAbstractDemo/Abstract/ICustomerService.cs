using InterfacesAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
