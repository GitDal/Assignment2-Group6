using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    public class HelpRequestsViewModel
    {
        public HelpRequestsViewModel() { }
        public HelpRequestsViewModel(IEnumerable<Exercise> exercises, IEnumerable<Assignment> assignments)
        {
            Exercises = exercises;
            Assignments = assignments;
        }

        public IEnumerable<Exercise> Exercises { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
    }
}
