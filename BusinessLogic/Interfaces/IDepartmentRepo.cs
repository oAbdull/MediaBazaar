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
        List<Department> GetDepartments();
        string CreateDepartment(Department department);
        void UpdateDepartment(Department department);
        string DeleteDepartment(Department department);
    }
}
