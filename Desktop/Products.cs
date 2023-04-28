using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Products : Form
    {
        private Company Companycompany;

        SqlConnection conn = new SqlConnection("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");


        public Products()
        {
            InitializeComponent();
            Companycompany = new Company(new MediaBazaarDAL.UserRepo(), new MediaBazaarDAL.SectionRepo());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string Productname = txbProductName.Text;
            int Productprice = Convert.ToInt32(txbProductPrice.Text);
            int ProductQuantity = Convert.ToInt32(txbProductQuantity.Text);

            Product prd = new Product(id, Productname, Productprice, ProductQuantity);

            var message = Companycompany.CreateProduct(prd);

            MessageBox.Show(message);
            display_Products();
            panel1.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string Productname = txbProductName.Text;
            int Productprice = Convert.ToInt32(txbProductPrice.Text);
            int ProductQuantity = Convert.ToInt32(txbProductQuantity.Text);

            int Departmentid = Companycompany.GetProducts().FirstOrDefault(p => p.Id == id).DepartmentId;

            Product prd = new Product(id, Productname, Productprice, ProductQuantity);
            prd.DepartmentId = Departmentid;

            var message = Companycompany.UpdateProduct(prd);


            MessageBox.Show(message);
            display_Products();
            panel1.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string Productname = txbProductName.Text;
            int Productprice = Convert.ToInt32(txbProductPrice.Text);
            int ProductQuantity = Convert.ToInt32(txbProductQuantity.Text);

            Product prd = new Product(id, Productname, Productprice, ProductQuantity);

            var message = Companycompany.DeleteProduct(prd);

            MessageBox.Show(message);
            display_Products();
            panel1.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Product_info where id = " + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txbID.Text = dr["ID"].ToString();
                    txbProductName.Text = dr["Product_name"].ToString();
                    txbProductPrice.Text = dr["Product_Price"].ToString();
                    txbProductQuantity.Text = dr["Product_Quantity"].ToString();
                }

                conn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void display_Products()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Product_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

    }
}
