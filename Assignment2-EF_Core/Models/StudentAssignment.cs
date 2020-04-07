using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class StudentAssignment
    {
        public string StudentId { get; set; }
        public string AssignmentName { get; set; }

        //Navigational properties
        public Student Student { get; set; }
        public Assignment Assignment { get; set; }
    }
}
