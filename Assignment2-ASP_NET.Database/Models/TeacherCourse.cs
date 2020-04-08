using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_ASP_NET.Database.Models
{
    public class TeacherCourse
    {
        public string TeacherId { get; set; }
        public int CourseId { get; set; }

        //Navigational properties
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
    }
}
