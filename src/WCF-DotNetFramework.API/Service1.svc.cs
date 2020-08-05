using System.Collections.Generic;
using WCF_DotNetFramework.Domain.Entities;

namespace WCF_DotNetFramework.API
{
    public class Service1 : IService1
    {
        public List<User> ListUsers()
        {
            return BLL.User.ListUsers();
        }

        public string AddUser(User user)
        {
            if (user.Name == null || user.Email == null)
            {
                return "Usuário Inválido!";
            }

            return $"Usuário Adicionado! Nome: {user.Name}";
        }
    }
}
