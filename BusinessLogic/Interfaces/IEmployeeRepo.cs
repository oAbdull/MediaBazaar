using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IEmployeeRepo
    {
        int GetLatestEmployeeId();
        List<Employee> GetEmployees();
        List<Employee> GetEmployees(int departmentId);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        void AddShiftToEmployee(int departmentId, int employeeId, int shiftId);
        void AddToDepartment(int departmentId, Employee employee);
        void RemoveFromDepartment(Employee employee);
    }
}
