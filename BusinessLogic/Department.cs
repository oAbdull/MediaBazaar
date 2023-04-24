using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Department
    {
        private int departmentId;
        private string Department_Name;
        private string Department_Manager;
        private List<Employee> employees;
        private List<Product> products;
        private List<Shift> shifts;

        public Department()
        {
        }

        public Department(int id, string name)
        {
            this.departmentId = id;
            this.Department_Name = name;
            employees = new List<Employee>();
            products = new List<Product>();
            shifts = new List<Shift>();
        }

        public int Id
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        public string Name
        {
            get { return Department_Name; }
            set { Department_Name = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
        }
        public List<Product> Products
        {
            get { return products; }
        }
        public List<Shift> Shifts
        {
            get { return shifts; }
        }
        public string DepartmentManager
        {
            get { return Department_Manager; }
            set { Department_Manager = value;}
        }
    }
}
