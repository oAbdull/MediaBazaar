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
        public List<Employee> GetEmployees()
        {
            return employeeRepo.GetEmployees();
        }
        public List<Employee> GetEmployees(Department department)
        {
            return employeeRepo.GetEmployees(department.Id);
        }
        public void CreateEmployee(Employee employee)
        {
            employeeRepo.CreateEmployee(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            employeeRepo.UpdateEmployee(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            employeeRepo.DeleteEmployee(employee);
        }
        public void AddShiftToEmployee(Department department, Employee employee, Shift shift)
        {
            employeeRepo.AddShiftToEmployee(department.Id, employee.EmployeeId, shift.Id);
        }

    }
}
