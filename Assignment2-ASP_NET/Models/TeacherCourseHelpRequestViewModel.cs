using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    public class TeacherCourseHelpRequestViewModel
    {
        public TeacherCourseHelpRequestViewModel() { }
        public TeacherCourseHelpRequestViewModel(IEnumerable<Exercise> exercises, IEnumerable<Assignment> assignments, Teacher teacher, Course course)
        {
            Exercises = exercises;
            Assignments = assignments;
            Teacher = teacher;
            Course = course;
        }

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
    }
}
