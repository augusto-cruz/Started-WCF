using System.Collections.Generic;
using System.ServiceModel.Web;
using WCF_DotNetFramework.Domain.Entities;

namespace WCF_DotNetFramework.API
{
    public class UserService : IUserService
    {
        public List<User> ListUsers()
        {
            return BLL.User.ListUsers();
        }

        public string AddUser(User user)
        {
            return BLL.User.AddUser(user);
        }
    }
}
