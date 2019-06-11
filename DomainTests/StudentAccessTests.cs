using Domain;
using Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DomainTests
{
    public class StudentAccessTests
    {
        StudentAccess studAccess = new StudentAccess();
        Section section = new Section()
        {
            SectionName = "BSIT"
        };
        [Fact]
        public void AddStudent_ShouldWork()
        {

            Student newStud = new Student()
            {
                FirstName = "Arnold",
                MiddleName = "Villaruel",
                LastName = "Mendoza",
                Course = "BSIT",
                Section = section,
                Email = "amendoza@blastasia.com"
            };
            studAccess.AddStudent(newStud);
            var actual = studAccess.StudentList;
            Assert.Contains(newStud,actual);
        }
        
        [Fact]
        public void GetAllStudentBySection_ShouldWork()
        {

            //Arrange

            var expected = studAccess.StudentList.Where(sect => sect.Section.SectionId.Equals(section.SectionId)).ToList().Count;
            //Act
            var actual = studAccess.GetAllStudentBySection(section).Count;
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
