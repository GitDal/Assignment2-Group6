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
            Courses = new List<AttendingCourse>();
        }

        public StudentViewModel(Student student, IEnumerable<Course> courses)
        {
            Student = student;
            Courses = new List<AttendingCourse>();
            foreach (var course in courses)
            {
                Courses.Add(new AttendingCourse()
                {
                    CourseTag = course.CourseId,
                    IsAttending = false
                });
            }
        }

        public Student Student { get; set; }
        public string Semester { get; set; }
        public List<AttendingCourse> Courses { get; set; }
    }

    public class AttendingCourse
    {
        public string CourseTag { get; set; }
        public bool IsAttending { get; set; }
    }
}
