using BusinessLogic;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class FakeDepartmentRepo : IDepartmentRepo
    {
        private List<Department> departments;
        public FakeDepartmentRepo()
        {
            departments = new List<Department>()
            {
                new Department(1, "Huishoud"),
                new Department(2, "Garden"),
                new Department(3, "Electronics")
            };
        }
        public void CreateDepartment(Department department)
        {
            departments.Add(department);
        }

        public void DeleteDepartment(Department department)
        {
            departments.Remove(department);
        }

        public Department GetDepartment(int id)
        {
            return departments.FirstOrDefault(d => d.Id == id);
        }

        public int GetLatestDepartmentId()
        {
            throw new NotImplementedException(); // dont know
        }
        public void UpdateDepartment(Department department)
        {
            foreach (Department dep in departments)
            {
                if (dep.Id == department.Id)
                {
                    dep.Name = department.Name;
                }
            }
        }
    }
}
