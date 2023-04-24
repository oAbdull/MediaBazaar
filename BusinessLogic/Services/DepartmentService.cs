using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class DepartmentService
    {
        private IDepartmentRepo departmentRepo;
        public DepartmentService(IDepartmentRepo departmentRepo)
        {
            this.departmentRepo = departmentRepo;
        }

        public int GetLatestDepartmentId()
        {
            return departmentRepo.GetLatestDepartmentId();
        }
        public Department GetDepartmentOfId(int id)
        {
            return departmentRepo.GetDepartment(id);
        }
        public List<Department> GetDepartments()
        {
            return departmentRepo.GetDepartments();
        }
        public void CreateDepartment(Department department)
        {
            departmentRepo.CreateDepartment(department);
        }
        public void UpdateDepartment(Department department)
        {
            departmentRepo.UpdateDepartment(department);
        }
        public void DeleteDepartment(Department department)
        {
            departmentRepo.DeleteDepartment(department);
        }

        
    }
}
