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
                    Name = "Usuario Teste 01",
                    Email = "teste01@"
                },
                new Domain.Entities.User
                {
                    Name = "Usuario Teste 02",
                    Email = "teste02@"
                },
                new Domain.Entities.User
                {
                    Name = "Usuario Teste 03",
                    Email = "teste03@"
                }
            };

            return users;
        }

        public static string AddUser(Domain.Entities.User user)
        { 
            // Fake insert on DB
            if (user.Name == null || user.Email == null)
            {
                return "Usuário Inválido!";
            }

            return $"Usuário Adicionado! Nome: {user.Name}";
        }
    }
}
