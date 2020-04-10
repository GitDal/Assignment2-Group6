using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_ASP_NET.Database.Models
{
    public class Exercise
    {
        [Required]
        public int HelpRequestId { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string Lecture { get; set; }
        [Required]
        [Display(Name = "Help Where")]
        public string HelpWhere { get; set; }
        public bool Open { get; set; }

        [Display(Name = "Course Tag")]
        public string CourseId { get; set; }
        public string TeacherId { get; set; }
        public string StudentId { get; set; }

        //Navigational properties
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
