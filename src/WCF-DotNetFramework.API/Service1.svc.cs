using System.Collections.Generic;
using WCF_DotNetFramework.Domain.Entities;

namespace WCF_DotNetFramework.API
{
    public class Service1 : IService1
    {
        public List<User> ListUsers()
        {
            var users = new List<User>()
            {
                new User
                {
                    Name = "Teste01",
                    Email = "teste01@"
                },
                new User
                {
                    Name = "Teste02",
                    Email = "teste02@"
                }
            };

            return users;
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
