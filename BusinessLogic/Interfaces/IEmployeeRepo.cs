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
        List<Employee> GetEmployees(int sectionId);
        List<Employee> GetEmployees(int sectionId, int departmentId);
        void CreateEmployee(int sectionId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        void AddShiftToEmployee(int sectionId, int departmentId, int employeeId, int shiftId);

    }
}
