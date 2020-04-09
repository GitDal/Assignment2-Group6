using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    public class StudentHelpRequestsViewModel
    {
        public StudentHelpRequestsViewModel() { }
        public StudentHelpRequestsViewModel(IEnumerable<Exercise> exercises, IEnumerable<Assignment> assignments)
        {
            Exercises = exercises;
            Assignments = assignments;
        }

        public Student Student { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
    }
}
