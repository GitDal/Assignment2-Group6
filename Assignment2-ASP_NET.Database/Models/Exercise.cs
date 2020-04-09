using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_ASP_NET.Database.Models
{
    public class Exercise
    {
        
        public int Number { get; set; }
        public string Lecture { get; set; }
        public string HelpWhere { get; set; }

        public string CourseId { get; set; }
        public string TeacherId { get; set; }
        public string StudentId { get; set; }

        //Navigational properties
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
