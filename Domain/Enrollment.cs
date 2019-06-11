using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Enrollment
    {
        StudentAccess StudAccess = new StudentAccess();
        SectionRepos sectAccess = new SectionRepos();
        Student stud = new Student();
        Section sect = new Section();

        public void Enroll( string FName, string MName, string LName, string Course, Section section)
        {
            stud.FirstName = FName;

            stud.MiddleName = MName;

            stud.LastName = LName;

            stud.Course = Course;

            stud.Section = section;

            StudAccess.AddStudent(stud);

        }
        public void CreateSection(string sectionName)
        {
            sect.SectionName = sectionName;
            sectAccess.AddSection(sect);
        }

        public void EditStudentInfo(string email,Student updatedStudent)
        {
            int index = StudAccess.GetIndex(email);
            StudAccess.StudentList[index] = updatedStudent;

            
        }
    }
}



