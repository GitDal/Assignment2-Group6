using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_ASP_NET.Database.Models
{
    public class Course
    {
        [Required]
        [Display(Name = "Course Tag")]
        public string CourseId { get; set; }
        [Required]
        public string Name { get; set; }

        //Navigational properties
        public List<TeacherCourse> Teachers { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<StudentCourse> Students { get; set; }
    }
}
