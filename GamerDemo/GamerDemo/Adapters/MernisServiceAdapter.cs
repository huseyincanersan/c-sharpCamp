using GamerDemo.Abstract;
using GamerDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
