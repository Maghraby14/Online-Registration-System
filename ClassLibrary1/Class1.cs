using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class RegisteredCourseDto
    {
        public int CourseId { get; set; }
        public int GroupId { get; set; }
    }
    public class StudentViewModel
        {
            public int Id { get; set; }
        public string departmentName { get; set; }
        public string collegeName { get; set; }
           public int password { get; set; }

        public bool hasSchedule { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public double GPA { get; set; }
            public int tot_achived { get; set; }
            public string sponser { get; set; }
            public int term { get; set; }

        public int departmrntId { get; set; }
        }
    public class CreateDepartmentDto
    {
        public string Name { get; set; }
        public string CollegeName { get; set; } // Only the College ID
      
        public int num_of_Credit { get; set; }
    }
    public class CreateDTA
    {
        public string Name { get; set; }
        public string DeptName { get; set; } // Only the College ID

        public string CollegeName { get; set; }

    }
    public class CollegesAdd
    {
        public string Name { get; set; }
    }
    public class MultipleCollegesAdd
    {
        public List<CollegesAdd> Colleges { get; set; }
    }
    public class addCourses
    {
        public string Name { get; set; }
        public int crd_hrs { get; set; }
        public string type { get; set; }
        public string term_given { get; set; }

        public string DeptName { get; set; }

        public string CollegeId { get; set; }

        public int prequisite {  get; set; }
       

        
    }
    public class addStudents
    {
        public int Id { get; set; }

        public int Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public int tot_achived { get; set; }
        public string sponser { get; set; }
        public int term { get; set; }

        public string departmentName { get; set; }
    }
    public class addTimeTable
    {
        public int DoctorId { get; set; }
        public int TAId { get; set; }
        public int GroupId { get; set; }
        public int LecRoomId { get; set; }
        public int SecRoomId { get; set; }
        public int CourseId { get; set; }
        public DateTime LectFrom { get; set; }

        public DateTime LectTo { get; set; }

        public string Lectday { get; set; }

        public DateTime SectFrom { get; set; }

        public DateTime SectTo { get; set; }

        public string Sectday { get; set; }
        public int departmentId {  get; set; }


    }
    public class addFinished
    {
        public int StudentId { get; set; }
        public int CourseId {get; set; }
    }
    public class ScheduleviewModel
    {
       
      

        public int CourseGroupId { get; set; }
        public string DoctorName {  get; set; }
        public string TAName { get; set; }
        public string Lecday { get; set; }
        public string Secday { get; set; }
        public int LecSlot { get; set; }
        public int SecSlot { get; set; }
       
        public int Id { get; set; }
        public int capacity { get; set; }
    }


    public class ScheduleGroupViewModel
    {
        public int CourseCreditHours { get; set; }
        public string CourseName { get; set; }
        public string CoursePeriod { get; set; }

        public int CourseId { get; set; } // Group by CourseId
        public List<ScheduleviewModel> Schedules { get; set; }
    }
    public class addSchedule
    {
        public int studentId { get; set; }
        public int GroupId { get; set; }
        public int CourseId { get; set; }

    }

    public class Registeredadd
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int GroupId { get; set; }
    }
}
