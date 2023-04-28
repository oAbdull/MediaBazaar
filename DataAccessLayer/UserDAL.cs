using BusinessLogic.Interfaces;
using BusinessLogic;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAL : IUserRepo
    {
        string connString = ("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");

        SqlConnection conn;
        int count = 0;

        public string CreateUser(User user)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "insert into User_info (name, password)" +
                        "values (@Name, @Password)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    conn.Close();
                    return "saved";
                }

            }
            catch (Exception)
            {
                return "error";
            }
        }

        public int GetLatestUserId()
        {
            throw new NotImplementedException();

        }  // user doesnt have an id?

        public User GetUserByName(string username)
        {
            User user = new User();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "select * from Employee_info where Name =@Name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User userbyname = new User
                            {
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"]
                                
                            };
                            user = userbyname;
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }
    }
}
