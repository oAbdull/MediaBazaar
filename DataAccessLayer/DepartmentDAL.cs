using BusinessLogic;
using BusinessLogic.Interfaces;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class DepartmentDAL : IDepartmentRepo
    {
        string connString = ("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");

        SqlConnection conn;
        int count = 0;



        public string CreateDepartment(Department department)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "insert into Department_info (id, department_name, department_manager)" +
                        "values (@ID, @Department_Name, @Department_Manager)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", department.Id);
                    cmd.Parameters.AddWithValue("@Department_Name", department.Name);
                    cmd.Parameters.AddWithValue("@Department_Manager", department.DepartmentManager);
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

        string IDepartmentRepo.DeleteDepartment(Department department)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Department_info WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", department.Id);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return "Deleted";
                }
            }
            catch (Exception)
            {
                return "error";
            }
        }

        
        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
            // we dont have update department
        }

        public Department GetDepartment(int id)
        {
            Department department = new Department();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "select * from Department_info where ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Department departmentbyid = new Department
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Department_Name"],
                                DepartmentManager = (string)reader["Department_Manager"]

                            };
                            department = departmentbyid;
                        }
                    }
                }
                conn.Close();
            }
            return department;
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "select * from Department_info";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Department_Name"],
                                DepartmentManager = (string)reader["Department_Manager"]
                                
                            };
                            departments.Add(department);
                        }
                    }
                }
                conn.Close();
            }
            return departments;
        }

        public int GetLatestDepartmentId()
        {
            throw new NotImplementedException();
            // gaan we niet gebruiken?
        }

        
    }
}
