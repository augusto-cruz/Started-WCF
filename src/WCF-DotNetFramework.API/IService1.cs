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
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<User> ListUsers();

        [OperationContract]
        [WebInvoke(Method = "POST")]
        string AddUser(User user);
    }
}
