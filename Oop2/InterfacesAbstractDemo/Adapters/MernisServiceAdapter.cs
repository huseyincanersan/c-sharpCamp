using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Entities;
using InterfacesAbstractDemo.Adapters;
using InterfacesAbstractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;

namespace InterfacesAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;


        }
    }
}
