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
    public class ProductDAL : IProductRepo
    {
        string connString = ("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");

        SqlConnection conn;
        int count = 0;


        public void CreateProduct(int sectionId, Product product)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "insert into Product_info (id, product_name, product_price, product_quantity)" +
                        "values (@ID, @Product_Name, @Product_Price, @Product_Quantity)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", product.Id);
                    cmd.Parameters.AddWithValue("@Product_Name", product.Name);
                    cmd.Parameters.AddWithValue("@Product_Price", product.Price);
                    cmd.Parameters.AddWithValue("@Product_Quantity", product.Quantity);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Product_info WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", product.Id);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public void UpdateProduct(Product product)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = "UPDATE Product_info set Product_Name = @Product_Name, Product_Price = @Product_Price, Product_Quantity = @Product_Quantity WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", product.Id);
                    cmd.Parameters.AddWithValue("@Product_Name", product.Name);
                    cmd.Parameters.AddWithValue("@Product_Price", product.Price);
                    cmd.Parameters.AddWithValue("@Product_Quantity", product.Quantity);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Product> GetProducts(int sectionId)
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "select * from Product_info";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                Id = (int)reader["ID"],
                                Name = (string)reader["Product_Name"],
                                Price = (int)reader["Product_Price"],
                                Quantity = (int)reader["Product_Quantity"],
                                DepartmentId = (int)reader["Department_ID"] //is deze nodig?
                            };
                            products.Add(product);
                        }
                    }
                }
                conn.Close();
            }
            return products;
        }

        public int GetLatestProductId()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(int sectionId, int departmentId)
        {
            throw new NotImplementedException();
        }

        
    }
}
