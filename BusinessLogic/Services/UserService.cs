using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class UserService
    {
        private IUserRepo userRepo;

        public UserService(IUserRepo _userRepo)
        {
            this.userRepo = _userRepo;
        }

        // validate login
        public bool IsValidUser(User user)
        {
            User validateUser = userRepo.GetUserByName(user.Username);

            if (user.Password == validateUser.Password) // change this so the hashes get compared;
            {
                return true;
            }
            else { return false; }
        }
        public bool CheckUsernameUsed(string username)
        {
            if (userRepo.GetUserByName(username) != null)
            {
                return true;
            }
            return false;
        }


        // questionable if it works. The company class needs to check for the latest id when making the User object if its meant to be an employee
        public void CreateUser(User userDataUser)
        {
            // only proceed if user does not exists
            if (userRepo.GetUserByName(userDataUser.Username) == null)
            {
                User newUser;
                if (userDataUser is Employee)
                {
                    Employee employee = (Employee)userDataUser;

                    userRepo.CreateUser(employee);
                }

            }
            else
            {
                throw new Exception("Username already exists");
            }
        }
    }
}
