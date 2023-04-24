using BusinessLogic;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class FakeUserRepo : IUserRepo
    {
        private List<User> users;
        public FakeUserRepo()
        {
            users = new List<User>()
            {
                new User("Jur", "Jur123"),
                new User("Okba", "Okba123"),
                new User("Metehan", "Metehan123"),
                new User("Niyazi", "Niyazi123")
            };
        }
        public void CreateUser(User user)
        {
            users.Add(user);
        }

        public int GetLatestUserId()
        {
            throw new NotImplementedException(); // dont know
        }

        public User GetUserByName(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }
    }
}
