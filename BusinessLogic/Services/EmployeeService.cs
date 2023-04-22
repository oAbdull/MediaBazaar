using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class EmployeeService
    {
        private IEmployeeRepo employeeRepo;
        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public int GetLatestEmployeeId()
        {
            return employeeRepo.GetLatestEmployeeId();
        }
        public List<Employee> GetEmployees(Section section)
        {
            return employeeRepo.GetEmployees(section.Id);
        }
        public List<Employee> GetEmployees(Section section, Department department)
        {
            return employeeRepo.GetEmployees(section.Id, department.Id);
        }
        public void CreateEmployee(Section section, Employee employee)
        {
            employeeRepo.CreateEmployee(section.Id, employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            employeeRepo.UpdateEmployee(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            employeeRepo.DeleteEmployee(employee);
        }
        public void AddShiftToEmployee(Section section, Department department, Employee employee, Shift shift)
        {
            employeeRepo.AddShiftToEmployee(section.Id, department.Id, employee.EmployeeId, shift.Id);
        }

    }
}
