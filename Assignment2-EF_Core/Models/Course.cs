using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class Course
    {
        [Required]
        public int CourseId { get; set; }
        [Required]
        public string Name { get; set; }

        //Navigational properties
        public List<TeacherCourse> Teachers { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<StudentCourse> Students { get; set; }
    }
}
