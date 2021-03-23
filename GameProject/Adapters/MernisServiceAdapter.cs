using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Adapters;
using MernisServiceReference;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(user.NationalityId, user.FirstName.ToUpper(),
            user.LastName.ToUpper(), user.DateBirth.Year);
        }
    }
}
