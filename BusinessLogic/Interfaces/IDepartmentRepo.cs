using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IDepartmentRepo
    {
        int GetLatestDepartmentId(); // used for id generation
        Department GetDepartment(int id);
        List<Department> GetDepartmentsBySectionId(int sectionId);
        void CreateDepartment(int sectionId, Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);

        void AddToDepartment(int sectionId, int departmentId, Employee employee);
        void AddToDepartment(int sectionId, int departmentId, Product product);
        void AddToDepartment(int sectionId, int departmentId, Shift shift);
        void RemoveFromDepartment(Employee employee);
        void RemoveFromDepartment(Product product);
        void RemoveFromDepartment(Shift shift);
    }
}
