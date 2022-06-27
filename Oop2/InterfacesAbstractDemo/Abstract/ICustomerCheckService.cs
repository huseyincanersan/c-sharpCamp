using InterfacesAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
