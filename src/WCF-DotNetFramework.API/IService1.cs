using System.Collections.Generic;
using System.ServiceModel;
using WCF_DotNetFramework.Domain.Entities;

namespace WCF_DotNetFramework.API
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<User> ListUsers();
    }
}
