using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IOldSectionRepo
    {
        int GetSectionIdByName(string name);
        int GetLatestSectionId();
        Section GetSectionOfId(int sectionId);
        List<Section> GetSections();

        int GetLatestDepartmentId();
        Department GetDepartmentOfId(int departmentId);
        List<Department> GetDepartments(Section section);
        void CreateDepartment(Section section, Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);

        int GetLatestEmployeeId();
        List<Employee> GetEmployees(Section section);
        List<Employee> GetEmployees(Section section, Department department);
        void CreateEmployee(Section section, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        int GetLatestProductId();
        List<Product> GetProducts(Section section);
        List<Product> GetProducts(Section section, Department department);
        void CreateProduct(Section section, Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        int GetLatestShiftId();
        List<Shift> GetShifts(Section section);
        List<Shift> GetShifts(Section section, Department department);
        void CreateShift(Section section, Shift shift);
        void UpdateShift(Shift shift);
        void DeleteShift(Shift shift);

        void AddToDepartment(Section section, Department department, Employee employee);
        void AddToDepartment(Section section, Department department, Product product);
        void AddToDepartment(Section section, Department department, Shift shift);
        void RemoveFromDepartment(Employee employee);
        void RemoveFromDepartment(Product product);
        void RemoveFromDepartment(Shift shift);

        void AddShiftToEmployee(Section section, Department department, Employee employee, Shift shift);

    }
}
