using BusinessLogic;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class FakeEmployeeRepo : IEmployeeRepo
    {
        private List<Employee> employees;
        public FakeEmployeeRepo()
        {
            employees = new List<Employee>()
            {

            };
        }

        public void AddShiftToEmployee(int departmentId, int employeeId, int shiftId)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeId == employeeId)
                {
                    // to be implemented
                }
            }
        }

        public void AddToDepartment(int departmentId, Employee employee)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeId == employee.EmployeeId)
                {
                    emp.DepartmentId = departmentId;
                }
            }
        }

        public void CreateEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Employee> GetEmployees(int departmentId)
        {
            List<Employee> departmentEmployees = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.DepartmentId == departmentId)
                {
                    departmentEmployees.Add(emp);
                }
            }
            return departmentEmployees;
        }

        public int GetLatestEmployeeId()
        {
            throw new NotImplementedException(); // dont know
        }

        public void RemoveFromDepartment(Employee employee)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeId == employee.EmployeeId)
                {
                    emp.DepartmentId = 0;
                }
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeId == employee.EmployeeId)
                {
                    emp.Username = employee.Username;
                    emp.Password = employee.Password;
                    emp.PhoneNumber = employee.PhoneNumber;
                    emp.Email = employee.Email;
                    emp.FirstName = employee.FirstName;
                    emp.LastName = employee.LastName;
                }
            }
        }
    }
}
