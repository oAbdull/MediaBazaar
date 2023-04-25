using BusinessLogic.Interfaces;
using BusinessLogic;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ShiftDAL : IShiftRepo
    {
        string connString = ("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");

        SqlConnection conn;
        int count = 0;

        public void AddToDepartment(int departmentId, Shift shift)
        {
            throw new NotImplementedException();
        }

        public void CreateShift(Shift shift)
        {
                throw new NotImplementedException();
        }

        public void DeleteShift(Shift shift)
        {
            throw new NotImplementedException();
        }

        public int GetLatestShiftId()
        {
            throw new NotImplementedException();
        }

        public List<Shift> GetShifts()
        {
            throw new NotImplementedException();
        }

        public List<Shift> GetShifts(int departmentId)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromDepartment(Shift shift)
        {
            throw new NotImplementedException();
        }

        public void UpdateShift(Shift shift)
        {
            throw new NotImplementedException();
        }
    }
}
