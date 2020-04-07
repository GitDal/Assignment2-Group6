using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class Assignment
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string TeacherId { get; set; }

        //Navigational properties
        public List<StudentAssignment> StudentAssignments { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
