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
        private string name;
        private List<Employee> employees;
        private List<Product> products;
        private List<Shift> shifts;

        public Department(int id, string name)
        {
            this.departmentId = id;
            this.name = name;
            employees = new List<Employee>();
            products = new List<Product>();
            shifts = new List<Shift>();
        }

        public int Id
        {
            get { return departmentId; }
        }
        public string Name
        {
            get { return name; }
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
    }
}
