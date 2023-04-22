using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ISectionRepo
    {
        int GetLatestSectionId(); // used for id generation
        Section GetSection(int id);
        List<Section> GetSections();
    }
}
