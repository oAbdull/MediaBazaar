using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class OldSectionService
    {
        private IOldSectionRepo sectionRepo;

        public OldSectionService(IOldSectionRepo sectionRepo)
        {
            this.sectionRepo = sectionRepo;

        }


        public int GetSectionIdByName(string name)
        {
            return sectionRepo.GetSectionIdByName(name);
        }
        public int GetLatestSectionId()
        {
            return sectionRepo.GetLatestSectionId();
        }
        public Section GetSectionOfId(int id)
        {
            return sectionRepo.GetSectionOfId(id);
        }
        public List<Section> GetSections()
        {
            return sectionRepo.GetSections();
        }


        //-----------Department----------------------------------------------------------------//

        public int GetLatestDepartmentId()
        {
            return sectionRepo.GetLatestDepartmentId();
        }
        public Department GetDepartmentOfId(int id)
        {
            return sectionRepo.GetDepartmentOfId(id);
        }
        public List<Department> GetDepartments(Section section)
        {
            return GetDepartments(section);
        }
        public void CreateDepartment(Section section, Department department)
        {
            sectionRepo.CreateDepartment(section, department);
        }
        public void UpdateDepartment(Department department)
        {
            sectionRepo.UpdateDepartment(department);
        }
        public void DeleteDepartment(Department department)
        {
            sectionRepo.DeleteDepartment(department);
        }


        //---------Employee---------------------------------------------------------------------//

        public int GetLatestEmployeeId()
        {
            return sectionRepo.GetLatestEmployeeId();
        }
        public List<Employee> GetEmployees(Section section)
        {
            return sectionRepo.GetEmployees(section);
        }
        public List<Employee> GetEmployees(Section section, Department department)
        {
            return GetEmployees(section, department);
        }
        public void CreateEmployee(Section section, Employee employee)
        {
            sectionRepo.CreateEmployee(section, employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            sectionRepo.UpdateEmployee(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            sectionRepo.DeleteEmployee(employee);
        }



        //-----------Product-------------------------------------------------------------------//


        public int GetLatestProductId()
        {
            return sectionRepo.GetLatestProductId();
        }
        public List<Product> GetProducts(Section section)
        {
            return GetProducts(section);
        }
        public List<Product> GetProducts(Section section, Department department)
        {
            return GetProducts(section, department);
        }
        public void CreateProduct(Section section, Product product)
        {
            sectionRepo.CreateProduct(section, product);
        }
        public void UpdateProduct(Product product)
        {
            sectionRepo.UpdateProduct(product);
        }
        public void DeleteProduct(Product product)
        {
            sectionRepo.DeleteProduct(product);
        }



        //---------Shifts------------------------------------------------------------------------//

        public int GetLatestShiftId()
        {
            return sectionRepo.GetLatestShiftId();
        }
        public List<Shift> GetShifts(Section section)
        {
            return GetShifts(section);
        }
        public List<Shift> GetShifts(Section section, Department department)
        {
            return GetShifts(section, department);
        }
        public void CreateShift(Section section, Shift shift)
        {
            sectionRepo.CreateShift(section, shift);
        }
        public void UpdateShift(Shift shift)
        {
            sectionRepo.UpdateShift(shift);
        }
        public void DeleteShift(Shift shift)
        {
            sectionRepo.DeleteShift(shift);
        }



        //----------Add-To-Department-----------------------------------------------------------------//

        public void AddToDepartment(Section section, Department department, Employee employee)
        {
            sectionRepo.AddToDepartment(section, department, employee);
        }
        public void AddToDepartment(Section section, Department department, Product product)
        {
            sectionRepo.AddToDepartment(section, department, product);
        }
        public void AddToDepartment(Section section, Department department, Shift shift)
        {
            sectionRepo.AddToDepartment(section, department, shift);
        }
        public void RemoveFromDepartment(Employee employee)
        {
            sectionRepo.RemoveFromDepartment(employee);
        }
        public void RemoveFromDepartment(Product product)
        {
            sectionRepo.RemoveFromDepartment(product);
        }
        public void RemoveFromDepartment(Shift shift)
        {
            sectionRepo.RemoveFromDepartment(shift);
        }



        //---------Assign-Shift------------------------------------------------------------------------//


        public void AddShiftToEmployee(Section section, Department department, Employee employee, Shift shift)
        {
            sectionRepo.AddShiftToEmployee(section, department, employee, shift);
        }
    }
}
