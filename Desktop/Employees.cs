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
    public partial class Employees : Form
    {

        private Company Companycompany;

        SqlConnection conn = new SqlConnection("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");


        public Employees()
        {
            InitializeComponent();
            Companycompany = new Company(new MediaBazaarDAL.UserRepo(), new MediaBazaarDAL.SectionRepo());
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            display_Employees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string Firstname = txbFirstname.Text;
            string Lastname = txbLastname.Text;
            string Email = txbEmail.Text;
            int Phonenumber = Convert.ToInt32(txbPhonenumber.Text);
            string Username = txbUsername.Text;
            string Password = txbPassword.Text;

            Employee emp = new Employee(id, Firstname, Lastname, Email, Phonenumber, Username, Password);

            var message = Companycompany.CreateEmployee(emp);

            MessageBox.Show(message);
            display_Employees();
            panel1.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string Firstname = txbFirstname.Text;
            string Lastname = txbLastname.Text;
            string Email = txbEmail.Text;
            int Phonenumber = Convert.ToInt32(txbPhonenumber.Text);
            string Username = txbUsername.Text;
            string Password = txbPassword.Text;

            int departmentid = Companycompany.GetEmployees().FirstOrDefault(e => e.EmployeeId == id).DepartmentId;

            Employee emp = new Employee(id, Firstname, Lastname, Email, Phonenumber, Username, Password);
            emp.DepartmentId = departmentid;

            var message = Companycompany.UpdateEmployee(emp);

            MessageBox.Show(message);
            display_Employees();
            panel1.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            string Firstname = txbFirstname.Text;
            string Lastname = txbLastname.Text;
            string Email = txbEmail.Text;
            int Phonenumber = Convert.ToInt32(txbPhonenumber.Text);
            string Username = txbUsername.Text;
            string Password = txbPassword.Text;

            Employee emp = new Employee(id, Firstname, Lastname, Email, Phonenumber, Username, Password);

            var message = Companycompany.DeleteEmployee(emp);

            MessageBox.Show(message);
            display_Employees();
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
                cmd.CommandText = "select * from Employee_info where id = " + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txbID.Text = dr["ID"].ToString();
                    txbFirstname.Text = dr["Firstname"].ToString();
                    txbLastname.Text = dr["Lastname"].ToString();
                    txbEmail.Text = dr["Email"].ToString();
                    txbPhonenumber.Text = dr["Phone_number"].ToString();
                    txbUsername.Text = dr["username"].ToString();
                    txbPassword.Text = dr["password"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void display_Employees()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employee_info";
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
