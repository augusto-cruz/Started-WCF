using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WCF_DotNetFramework.Domain.Entities;

namespace WCF_DotNetFramework.API
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<User> ListUsers();

        [WebInvoke(Method = "POST")]
        string AddUser(User user);
    }
}
