using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ShiftService
    {
        private IShiftRepo shiftRepo;
        public ShiftService(IShiftRepo shiftRepo)
        {
            this.shiftRepo = shiftRepo;
        }

        public int GetLatestShiftId()
        {
            return shiftRepo.GetLatestShiftId();
        }
        public List<Shift> GetShifts(Section section)
        {
            return shiftRepo.GetShifts(section.Id);
        }
        public List<Shift> GetShifts(Section section, Department department)
        {
            return shiftRepo.GetShifts(section.Id, department.Id);
        }
        public void CreateShift(Section section, Shift shift)
        {
            shiftRepo.CreateShift(section.Id, shift);
        }
        public void UpdateShift(Shift shift)
        {
            shiftRepo.UpdateShift(shift);
        }
        public void DeleteShift(Shift shift)
        {
            shiftRepo.DeleteShift(shift);
        }
    }
}
