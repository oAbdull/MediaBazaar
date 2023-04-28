using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IUserRepo
    {
        public User GetUserByName(string username);
        public string CreateUser(User user);
        public int GetLatestUserId();
    }
}
