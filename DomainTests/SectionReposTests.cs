using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DomainTests
{
    public class SectionReposTests
    {
        SectionRepos sect = new SectionRepos(); 
        [Fact]
        public void AddSection_ShouldWork()
        {
            Section newSection = new Section()
            {
                SectionId = new Guid(),
                SectionName = "BSIT102"
            };
            sect.AddSection(newSection);
            var actual = sect.SectionList;
            Assert.Contains(newSection, actual);

        }
        [Fact]
        public void GetAllSection_ShouldWork()
        {
            var expected = sect.SectionList;
            var actual = sect.GetAllSection().ToList();

            Assert.Equal(expected,actual);
            
        }
    }
}
