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
