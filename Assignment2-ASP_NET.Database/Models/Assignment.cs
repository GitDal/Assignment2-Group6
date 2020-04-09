using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_ASP_NET.Database.Models
{
    public class Assignment
    {
        public string Name { get; set; }
        public string HelpWhere { get; set; }
        public string CourseId { get; set; }
        public string TeacherId { get; set; }

        //Navigational properties
        public List<StudentAssignment> Students { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
