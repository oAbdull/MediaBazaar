using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class SectionService
    {
        private ISectionRepo sectionRepo;

        public SectionService(ISectionRepo sectionRepo)
        {
            this.sectionRepo = sectionRepo;
        }
        public int GetLatestSectionId()
        {
            return sectionRepo.GetLatestSectionId();
        }
        public Section GetSectionOfId(int id)
        {
            return sectionRepo.GetSection(id);
        }
        public List<Section> GetSections()
        {
            return sectionRepo.GetSections();
        }
    }
}
