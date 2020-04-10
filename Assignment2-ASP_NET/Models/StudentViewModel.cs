using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Courses = new List<CourseSignUp>();
        }

        public StudentViewModel(Student student, IEnumerable<Course> courses)
        {
            Student = student;
            Courses = new List<CourseSignUp>();
            foreach (var course in courses)
            {
                Courses.Add(new CourseSignUp()
                {
                    CourseTag = course.CourseId,
                    IsSignedUp = false
                });
            }
        }

        public Student Student { get; set; }
        public string Semester { get; set; }
        public List<CourseSignUp> Courses { get; set; }
    }

    public class CourseSignUp
    {
        public string CourseTag { get; set; }
        public bool IsSignedUp { get; set; }
    }
}
