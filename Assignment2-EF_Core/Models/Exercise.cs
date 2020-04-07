using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class Exercise
    {
        
        public int Number { get; set; }
        public string Lecture { get; set; }
        public string HelpWhere { get; set; }

        public int CourseId { get; set; }
        public string TeacherId { get; set; }

        //Navigational properties
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
