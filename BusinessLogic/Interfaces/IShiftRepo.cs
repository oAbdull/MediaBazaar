using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IShiftRepo
    {
        int GetLatestShiftId();
        List<Shift> GetShifts();
        List<Shift> GetShifts(int departmentId);
        void CreateShift(Shift shift);
        void UpdateShift(Shift shift);
        void DeleteShift(Shift shift);

        void AddToDepartment(int departmentId, Shift shift);
        void RemoveFromDepartment(Shift shift);
    }
}
