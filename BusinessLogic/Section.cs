using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Section
    {
        private int sectionId;
        private string name;
        private List<Department> departments;
        private List<Employee> employees;
        private List<Shift> shifts;
        private List<Product> products;

        public Section(string name)
        {

            this.name = name;
            if (name == "Sales")
            {
                departments = new List<Department>();
                products = new List<Product>();
            }
            employees = new List<Employee>();
            shifts = new List<Shift>();
        }

        public int Id
        {
            get { return sectionId; }
        }
        public string Name
        {
            get { return name; }
        }
        public List<Department> Departments
        {
            get { return departments; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
        }
        public List<Shift> Shifts
        {
            get { return shifts; }
        }
        public List<Product> Products
        {
            get { return products; }
        }
    }
}
