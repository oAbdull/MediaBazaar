using BusinessLogic;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class FakeSectionRepo : ISectionRepo
    {
        private List<Section> sections;
        public FakeSectionRepo()
        {
            sections = new List<Section>()
            {
                // add mockdata here
                new Section("sales")
            };
        }
        public int GetLatestSectionId()
        {
            throw new NotImplementedException(); // need db for this i think
        }

        public Section GetSection(int id)
        {
            return sections.FirstOrDefault(s => s.Id == id);
        }

        public List<Section> GetSections()
        {
            return sections;
        }
    }
}
