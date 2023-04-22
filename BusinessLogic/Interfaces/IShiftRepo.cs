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
        List<Shift> GetShifts(int sectionId);
        List<Shift> GetShifts(int sectionId, int departmentId);
        void CreateShift(int sectionId, Shift shift);
        void UpdateShift(Shift shift);
        void DeleteShift(Shift shift);
    }
}
