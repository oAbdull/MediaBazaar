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
