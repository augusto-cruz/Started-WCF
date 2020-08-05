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
                    Nome = "Teste01",
                    Email = "teste01@"
                },
                new User
                {
                    Nome = "Teste02",
                    Email = "teste02@"
                }
            };

            return users;
        }
    }
}
