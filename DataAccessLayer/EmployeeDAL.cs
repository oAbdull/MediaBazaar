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
    public class EmployeeDAL : IEmployeeRepo
    {
        string connString = ("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");

        SqlConnection conn;
        int count = 0;


        public void AddShiftToEmployee(int departmentId, int employeeId, int shiftId)
        {
            throw new NotImplementedException();
        }  //Not done 

        public void AddToDepartment(int departmentId, Employee employee)
        {
            throw new NotImplementedException();
        } //Not done

        public void CreateEmployee(Employee employee)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "insert into Employee_info (id, firstname, lastname, email, phone_number, username, password, department_id)" +
                        "values (@ID, @Firstname, @Lastname, @Email, @Phone_number, @Username, @Password, @Department_ID)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", employee.EmployeeId);
                    cmd.Parameters.AddWithValue("@Firstname", employee.FirstName);
                    cmd.Parameters.AddWithValue("@Lastname", employee.LastName);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Phone_number", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Username", employee.Username);
                    cmd.Parameters.AddWithValue("@Password", employee.Password);
                    cmd.Parameters.AddWithValue("@Department_ID", employee.DepartmentId);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    conn.Close();

                }

            }
            catch (Exception)
            {

            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "UPDATE Employee_info set Firstname = @Firstname, Lastname = @Lastname, Email = @Email, Phone_number = @Phone_number, Username = @Username, Password = @Password WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", employee.EmployeeId);
                    cmd.Parameters.AddWithValue("@Firstname", employee.FirstName);
                    cmd.Parameters.AddWithValue("@Lastname", employee.LastName);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Phone_number", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Username", employee.Username);
                    cmd.Parameters.AddWithValue("@Password", employee.Password);
                    cmd.Parameters.AddWithValue("@Department_ID", employee.DepartmentId);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    //return "value has been updated";
                }

            }
            catch (Exception)
            {
                //return "error";
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Employee_info WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", employee.EmployeeId);
                    cmd.ExecuteNonQuery();


                    conn.Close();

                    //return "Deleted";
                }
            }
            catch (Exception)
            {
                //return "error";
            }
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "select * from Employee_info";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee //no idea what the problem here is.
                            {
                                EmployeeId = (int)reader["Id"],
                                FirstName = (string)reader["Firstname"],
                                LastName = (string)reader["Lastname"],
                                Email = (string)reader["Email"],
                                PhoneNumber = (int)reader["Phone_number"],
                                DepartmentId = (int)reader["Department_ID"]
                            };
                            employees.Add(employee);
                        }
                    }

                }
                conn.Close();
            }
            return employees;
        }

        public List<Employee> GetEmployees(int departmentId)
        {
            throw new NotImplementedException();
        }

        public int GetLatestEmployeeId()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromDepartment(Employee employee)
        {
            throw new NotImplementedException();
        }

       
    }
}
