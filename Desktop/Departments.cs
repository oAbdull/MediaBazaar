using BusinessLogic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Departments : Form
    {

        private Company Companycompany;

        SqlConnection conn = new SqlConnection("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");

        public Departments()
        {
            InitializeComponent();
            Companycompany = new Company(new BusinessLogic.Interfaces(), new BusinessLogic.Services());
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
                Datagridview_employees.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}