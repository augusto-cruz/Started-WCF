using System.Collections.Generic;

namespace WCF_DotNetFramework.DAL
{
    public static class User
    {
        public static List<Domain.Entities.User> ListUsers()
        {
            // Fake get on DB
            var users = new List<Domain.Entities.User>()
            {
                new Domain.Entities.User
                {
                    Name = "Teste01",
                    Email = "teste01@"
                },
                new Domain.Entities.User
                {
                    Name = "Teste02",
                    Email = "teste02@"
                }
            };

            return users;
        }
    }
}
