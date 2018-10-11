using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC5FormsAuthentication.Models
{
    public static class UserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User(){Login="administrator@email.com", Password="admin@123", Roles="Admin"},
            new User(){Login="student@email.com", Password="student@123", Roles="Student"}
        };

        public static User GetUser(User user)
        {
            return users.Where(e => e.Login.ToLower() == user.Login.ToLower() && e.Password.ToLower() == user.Password.ToLower()).FirstOrDefault();
        }
    }
}