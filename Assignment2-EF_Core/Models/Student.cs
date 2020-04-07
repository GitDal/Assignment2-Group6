using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class Student
    {
        [Required]
        public string auId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        //Navigational properties
        public List<Exercise> Exercises { get; set; }
        public List<StudentAssignment> Assignments { get; set; }
        public List<StudentCourse> Courses { get; set; }

    }
}
