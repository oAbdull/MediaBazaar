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
    public class SectionDAL : ISectionRepo
    {

        string connString = ("server=mssqlstud.fhict.local;Database=dbi505917_media;user id=dbi505917_media;password=Media123;");

        SqlConnection conn;
        int count = 0;

        public int GetLatestSectionId()
        {
            throw new NotImplementedException();
        }

        public Section GetSection(int id)
        {
            throw new NotImplementedException();
        }

        public List<Section> GetSections()
        {
            throw new NotImplementedException();
        }
    }
}
