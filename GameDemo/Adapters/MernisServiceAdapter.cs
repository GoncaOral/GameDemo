using GameDemo.Abstract;
using GameDemo.Entities;
using MernisReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool ChechkIfRealUser(User user)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(user.NationalityId, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year);
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(user.NationalityId, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
