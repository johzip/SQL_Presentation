using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_DEMO.Model
{
    //Placeholderclass for the for each lines of the requested Table
    public class ListingClass 
    {
        //Faculty
        public int Fac_FacultyID { get; set; }
        public string Fac_FacultyName { get; set; }
        //Student
        public string Stu_firstName { get; set; }
        public string Stu_lastName { get; set; }
        public int Stu_age { get; set; }
        public int Stu_studentID { get; set; }
        //Subjekt
        public int Sub_SubjectID { get; set; }
        public string Sub_SubjektName { get; set; }
        public int Sub_TeacherID { get; set; }
        public int Sub_FacultyID { get; set; }
        //Teacher
        public int Tea_TeacherID { get; set; }
        public String Tea_TeacherName { get; set; }
    }
}
