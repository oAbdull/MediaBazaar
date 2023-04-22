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
        public List<Department> GetDepartments(Section section)
        {
            return departmentRepo.GetDepartmentsBySectionId(section.Id);
        }
        public void CreateDepartment(Section section, Department department)
        {
            departmentRepo.CreateDepartment(section.Id, department);
        }
        public void UpdateDepartment(Department department)
        {
            departmentRepo.UpdateDepartment(department);
        }
        public void DeleteDepartment(Department department)
        {
            departmentRepo.DeleteDepartment(department);
        }

        public void AddToDepartment(Section section, Department department, Employee employee)
        {
            departmentRepo.AddToDepartment(section.Id, department.Id, employee);
        }
        public void AddToDepartment(Section section, Department department, Product product)
        {
            departmentRepo.AddToDepartment(section.Id, department.Id, product);
        }
        public void AddToDepartment(Section section, Department department, Shift shift)
        {
            departmentRepo.AddToDepartment(section.Id, department.Id, shift);
        }
        public void RemoveFromDepartment(Employee employee)
        {
            departmentRepo.RemoveFromDepartment(employee);
        }
        public void RemoveFromDepartment(Product product)
        {
            departmentRepo.RemoveFromDepartment(product);
        }
        public void RemoveFromDepartment(Shift shift)
        {
            departmentRepo.RemoveFromDepartment(shift);
        }
    }
}
