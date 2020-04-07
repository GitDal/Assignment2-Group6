using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_EF_Core.Models
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
