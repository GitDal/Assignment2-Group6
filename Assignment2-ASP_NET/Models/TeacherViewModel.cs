using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    
    public class TeacherViewModel
    {
        public TeacherViewModel()
        {
            Courses = new List<CourseResponsibility>();
        }

        public TeacherViewModel(Teacher teacher, IEnumerable<Course> courses)
        {
            Teacher = teacher;
            Courses = new List<CourseResponsibility>();
            foreach (var course in courses)
            {
                Courses.Add(new CourseResponsibility()
                {
                    CourseTag = course.CourseId,
                    IsResponsible = false
                });
            }
        }

        public Teacher Teacher { get; set; }
        public string Semester { get; set; }
        public List<CourseResponsibility> Courses { get; set; }
    }

    public class CourseResponsibility
    {
        public string CourseTag { get; set; }
        public bool IsResponsible { get; set; }
    }
}
