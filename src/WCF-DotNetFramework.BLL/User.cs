using System.Collections.Generic;

namespace WCF_DotNetFramework.BLL
{
    public static class User
    {
        public static List<Domain.Entities.User> ListUsers()
        {
            return DAL.User.ListUsers();
        }

        public static string AddUser(Domain.Entities.User user)
        {
            return DAL.User.AddUser(user);
        }
    }
}
