using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Shift
    {
        private int shiftId;
        private string shiftName;
        private int departmentId;
        private List<Employee> employees;

        public Shift(int shiftId, string shiftName)
        {
            this.shiftId = shiftId;
            this.shiftName = shiftName;

            employees = new List<Employee>();
        }

        public int Id
        {
            get { return shiftId; }
        }
        public string ShiftName
        {
            get { return shiftName; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
        }

        public void UpdateShift(Shift shift)
        {
            this.shiftName = shift.ShiftName;
            this.departmentId = shift.DepartmentId;
            this.employees = shift.Employees;
        }
    }
}
