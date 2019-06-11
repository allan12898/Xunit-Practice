using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentAccess
    {
        static SectionRepos sec = new SectionRepos();
        public List<Student> StudentList = new List<Student>();
        Student newStuda = new Student()
        {
            FirstName = "Arnold",
            MiddleName = "Villaruel",
            LastName = "Mendoza",
            Course = "BSIT",
            Section = sec.SectionList[0],
            Email = "amendoza@blastasia.com"
        };
        public StudentAccess()
        {
            StudentList.Add(newStuda);
        }

        public void AddStudent(Student stud)
        {
            StudentList.Add(stud);
        }
        public List<Student> GetAllStudentBySection(Section section)
        {
            List<Student> output = StudentList.Where<Student>(x => x.Section.SectionId == section.SectionId).ToList(); ;
            return output;
        }

        public int GetIndex(string email)
        {
            var index = StudentList.FindIndex(c => c.Email == email);
            return index;
        }
    }
}
