using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Repository
{
    public class SectionRepos
    {
        public List<Section> SectionList = new List<Section>()
        { new Section
        {
            SectionName="BSIT101"
        }
        };

        public void AddSection(Section section)
        {
            SectionList.Add(section);
        }
        public List<Section> GetAllSection()
        {
            return SectionList;
        }

    }
}
