using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;
using SERVICE.Models;
using SERVICE.Dtos;

namespace SERVICE
{
    [ServiceContract]
    public interface IKTNService
    {
        [OperationContract]
        List<RegionDto> GetRegions(RegionsType type);

        [OperationContract]
        List<PersonDto> GetPersons();

        [OperationContract]
        UserDto GetUser(string username, string password);

        [OperationContract]
        UserDto GetUserByUsername(string username);
    }

    

}
