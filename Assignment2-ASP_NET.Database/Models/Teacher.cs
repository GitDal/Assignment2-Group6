using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_ASP_NET.Database.Models
{
    public class Teacher
    {
        [Required]
        public string AuId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        //Navigational properties
        public List<TeacherCourse> Courses { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}
